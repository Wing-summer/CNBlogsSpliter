using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel.Syndication;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNBlogsSpliter
{
    public partial class FrmPrograss : Form
    {
        private const string useragent
    = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/92.0.4515.131";
        private const string host = "images.cnblogs.com";
        private const string accept
            = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9";
        private const string acceptencoding = "gzip, deflate";
        private const string acceptlanguage = "zh-CN,zh;q=0.9,en;q=0.8,en-GB;q=0.7,en-US;q=0.6";
        private const string secchua = "\"Microsoft Edge\";v=\"95\", \"Chromium\";v=\"95\", \";Not A Brand\";v=\"99\"";

        private int prograss;

        public int Prograss
        {
            get
            {
                return prograss;
            }
            set
            {
                if (value >= 0 && value <= prBar.Maximum)
                {
                    prograss = value;
                    Invoke(new Action(() => prBar.Value = value));
                }
            }
        }

        private const string md = ".md";
        private const string html = ".html";
        private readonly List<string> links = new List<string>();
        private readonly Regex imgRegex = new Regex(@"<img\b[^<>]*?\bsrc[\s\t\r\n]*=[\s\t\r\n]*[""']?[\s\t\r\n]*(?<imgUrl>[^\s\t\r\n""'<>]*)[^<>]*?/?[\s\t\r\n]*>", RegexOptions.IgnoreCase);
        private readonly Regex timgRegex = new Regex(@"!\[img\]\([\s\t\r\n]*(?<imgUrl>[^\s\t\r\n""'<>]*)[\s\t\r\n]*\)");
        private readonly WebHeaderCollection headerCollection = new WebHeaderCollection();
        private readonly Random random = new Random();
        CBridge.InfoPak info;

        public bool Loaded { get; set; }

        public FrmPrograss(CBridge.InfoPak infoPak)
        {
            InitializeComponent();

            headerCollection.Add(HttpRequestHeader.AcceptEncoding, acceptencoding);
            headerCollection.Add(HttpRequestHeader.AcceptLanguage, acceptlanguage);
            headerCollection.Add("Cache-Control", "max-age=0");
            headerCollection.Add("DNT", "1");
            headerCollection.Add("sec-ch-ua", secchua);
            headerCollection.Add("sec-ch-ua-mobile", "?0");
            headerCollection.Add("sec-ch-ua-platform", "\"Windows\"");
            headerCollection.Add("Sec-Fetch-Dest", "document");
            headerCollection.Add("Sec-Fetch-Mode", "navigate");
            headerCollection.Add("Sec-Fetch-Site", "none");
            headerCollection.Add("Sec-Fetch-User", "?1");
            headerCollection.Add("sec-gpc", "1");
            headerCollection.Add("Upgrade-Insecure-Requests", "1");

            info = infoPak;
        }

        private static bool RemoteCertificateValidate(object sender, X509Certificate cert, X509Chain chain, SslPolicyErrors error)
        {
            return true;
        }


        private void GetPic(string url, string path, out string name)
        {
            var i = url.LastIndexOf('/');
            name = url.Substring(i + 1);
            var filename = Path.Combine(path, "img", name);
            AppendLineInfo($"> 正在初始化下载 {filename} ……");

            var request = WebRequest.CreateHttp(url);

            request.Headers = headerCollection;

            request.Method = "GET";
            request.Accept = accept;
            request.UserAgent = useragent;
            request.Host = host;
            request.KeepAlive = true;
            request.ServerCertificateValidationCallback = RemoteCertificateValidate;

            try
            {
                AppendLineInfo("> 请求下载……");
                using (var res = request.GetResponse())
                {
                    using (var stream = res.GetResponseStream())
                    {
                        AppendLineInfo($"> 正在创建 {filename} ……");
                        using (var writer = File.Create(filename))
                        {
                            stream.CopyTo(writer);
                            writer.Flush();
                        }
                        AppendLineInfo($"> {filename} 下载完毕！");
                    }
                }
            }
            catch (Exception e)
            {
                AppendLineInfo($"> 出现异常， {filename} 无法继续下载：");
                AppendLineInfo(e.ToString());
            }
        }



        private void BtnCancel_Click(object sender, EventArgs e)
        {
            bworker.CancelAsync();
            Close();
        }

        public void AppendLineInfo(string info)
        {
           new Task(() => Invoke(new Action(()=> tbInfo.AppendText($"{info}\r\n"))), TaskCreationOptions.PreferFairness).Start();
        }

        private void FrmPrograss_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (bworker.IsBusy)
            {
                if (MessageBox.Show("任务仍在进行中，你确定取消吗？", "询问",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }
                else
                {
                    bworker.CancelAsync();
                }
            }
        }

        private void FrmPrograss_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
        }

        private void FrmPrograss_Shown(object sender, EventArgs e)
        {
            bworker.RunWorkerAsync();
        }

        private void Bworker_DoWork(object sender, DoWorkEventArgs e)
        {
            Invoke(new Action(() => Focus()));

            var outpath = info.OutputDir;
            if (outpath.Length == 0 || !Directory.Exists(outpath))
            {
                MessageBox.Show("文件夹路径不存在！！！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Invoke(new Action(() => Enabled = false));

            links.Clear();
            StreamWriter outputfile;
            var ext = md;

            if (!info.IsMarkDown)
            {
                ext = html;
            }

            AppendLineInfo($"> 确认使用 {ext} 文件扩展名中……");

            int total = 0;
            var per = 100 / info.Items.Length;

            foreach (SyndicationItem item in info.Items)
            {
                var content = item.Summary.Text;
                var titile = item.Title.Text;
                var inper = per;

                string outfilename;
                string filewithext = string.Concat(titile, ext);

                AppendLineInfo($"> 开始处理 {titile} 文件中……");

                if (info.IsSavePic)
                {
                    AppendLineInfo($"> 开始匹配 {titile} 文件中的图片……");

                    var match = imgRegex.Matches(content);
                    foreach (Match m in match)
                    {
                        links.Add(m.Groups[1].Value);
                    }

                    match = timgRegex.Matches(content);
                    foreach (Match m in match)
                    {
                        links.Add(m.Groups[1].Value);
                    }

                    AppendLineInfo($"> 匹配完毕，{titile} 文件中的图片总共 {links.Count} 个。");

                    inper /= links.Count;

                    var dir = Directory.CreateDirectory(Path.Combine(outpath, titile));

                    var imgdir = dir.CreateSubdirectory("img");

                    AppendLineInfo($"> 创建 {dir.Name} 完毕，初始化文件更改中……");

                    StringBuilder builder = new StringBuilder(content);

                    foreach (var link in links)
                    {
                        AppendLineInfo($"> 开始下载 {link} 文件中……");
                        GetPic(link, dir.FullName, out string filename);
                        Thread.Sleep(random.Next(0, 1000));

                        AppendLineInfo($"> 修正图片路径中……");
                        builder.Replace(link, $@"..\{imgdir.Parent.Name}\{imgdir.Name}\{filename}");
                        AppendLineInfo($"> 修正图片路径完毕：{filename}。");

                        total += inper;
                        bworker.ReportProgress(total);
                    }

                    content = builder.ToString();
                    builder.Clear();
                    outfilename = Path.Combine(outpath, titile, filewithext);
                }
                else
                {
                    outfilename = Path.Combine(outpath, filewithext);
                }



                AppendLineInfo($"> 正在保存 {filewithext} 中……");
                outputfile = new StreamWriter(outfilename);
                outputfile.Write(content);
                outputfile.Flush();
                outputfile.Close();

                AppendLineInfo($"> 正在保存 {filewithext} 完毕！");
                total += per;

                bworker.ReportProgress(total);
            }
            bworker.ReportProgress(100);
        }

        private void Bworker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Prograss = e.ProgressPercentage;
        }

        private void Bworker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
                MessageBox.Show("已被用户取消！！！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("保存完毕！！！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Close();
        }
    }
}
