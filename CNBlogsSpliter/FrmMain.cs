using System;
using System.Xml;
using System.ServiceModel.Syndication;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CNBlogsSpliter
{
    public partial class FrmMain : Form
    {

        SyndicationFeed sf;

        public FrmMain()
        {
            InitializeComponent();
        }

        private readonly List<string> titles = new List<string>();


        private void BtnGet_Click(object sender, EventArgs e)
        {
            titles.Clear();
            clb.Items.Clear();

            sf = SyndicationFeed.Load(XmlReader.Create(tbPath.Text));

            foreach (var item in sf.Items)
            {
                titles.Add(item.Title.Text);
            }

            clb.Items.AddRange(titles.ToArray());
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            CBridge.InfoPak info;
            info.IsSavePic = cbSavePic.Checked;
            info.IsMarkDown = rbMD.Checked;
            info.OutputDir = tbOut.Text;

            var len = clb.CheckedIndices.Count;
            SyndicationItem[] items = new SyndicationItem[len];
            for (int i = 0; i < len; i++)
            {
                items[i] = sf.Items.ElementAt(clb.CheckedIndices[i]);
            }

            info.Items = items;
            new FrmPrograss(info).ShowDialog();
        }

        private void BtnSelAll_Click(object sender, EventArgs e)
        {
            int length = clb.Items.Count;
            for (int i = 0; i < length; i++)
            {
                clb.SetItemChecked(i, true);
            }
        }
        private void BtnRSel_Click(object sender, EventArgs e)
        {
            int length = clb.Items.Count;
            for (int i = 0; i < length; i++)
            {
                clb.SetItemChecked(i, !clb.GetItemChecked(i));
            }
        }

        private void BtnNoSel_Click(object sender, EventArgs e)
        {
            int length = clb.Items.Count;
            for (int i = 0; i < length; i++)
            {
                clb.SetItemChecked(i, false);
            }
        }

        private void BtnLoad1_Click(object sender, EventArgs e)
        {
            if (od.ShowDialog()== DialogResult.OK)
            {
                tbPath.Text = od.FileName;
                od.FileName = string.Empty;
            }
        }

        private void BtnLoad2_Click(object sender, EventArgs e)
        {
            if (fd.ShowDialog()== DialogResult.OK)
            {
                tbOut.Text = fd.SelectedPath;
            }
        }

        private void TbPath_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Link;
        }

        private void TbPath_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string filename= ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
                if (File.Exists(filename))
                {
                    tbPath.Text = filename;
                }
                else
                {
                    MessageBox.Show("非法文件名！！！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void TbOut_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Link;
        }

        private void TbOut_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string foldername = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
                if (Directory.Exists(foldername))
                {
                    tbOut.Text = foldername;
                }
                else
                {
                    MessageBox.Show("非法文件夹！！！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void TBPathChanged(object sender, EventArgs e)
        {
            var obj = sender as TextBox;
            tt.SetToolTip(obj, obj.Text);
        }

        private void ClearPath_Click(object sender, EventArgs e)
        {
            tbPath.Clear();
        }

        private void ClearOut_Click(object sender, EventArgs e)
        {
            tbOut.Clear();
        }


    }
}
