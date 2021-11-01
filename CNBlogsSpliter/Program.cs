using System;
using System.Windows.Forms;

namespace CNBlogsSpliter
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);

            Application.Run(new FrmMain());
        }
    }
}
