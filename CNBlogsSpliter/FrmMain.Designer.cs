
namespace CNBlogsSpliter
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ToolStripStatusLabel tssl;
            System.Windows.Forms.StatusStrip statusStrip1;
            System.Windows.Forms.GroupBox groupBox1;
            this.tsslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.cbSavePic = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNoSel = new System.Windows.Forms.Button();
            this.btnRSel = new System.Windows.Forms.Button();
            this.btnSelAll = new System.Windows.Forms.Button();
            this.btnGet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.ms1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.清空ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.tbOut = new System.Windows.Forms.TextBox();
            this.ms2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clb = new System.Windows.Forms.CheckedListBox();
            this.btnLoad1 = new System.Windows.Forms.Button();
            this.btnLoad2 = new System.Windows.Forms.Button();
            this.od = new System.Windows.Forms.OpenFileDialog();
            this.fd = new System.Windows.Forms.FolderBrowserDialog();
            this.tt = new System.Windows.Forms.ToolTip(this.components);
            this.rbMD = new System.Windows.Forms.RadioButton();
            this.rbHTML = new System.Windows.Forms.RadioButton();
            tssl = new System.Windows.Forms.ToolStripStatusLabel();
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            groupBox1 = new System.Windows.Forms.GroupBox();
            statusStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            this.ms1.SuspendLayout();
            this.ms2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tssl
            // 
            tssl.Name = "tssl";
            tssl.Size = new System.Drawing.Size(54, 20);
            tssl.Text = "状态：";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            tssl,
            this.tsslStatus});
            statusStrip1.Location = new System.Drawing.Point(0, 558);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new System.Drawing.Size(953, 26);
            statusStrip1.TabIndex = 15;
            statusStrip1.Text = "statusStrip1";
            // 
            // tsslStatus
            // 
            this.tsslStatus.ForeColor = System.Drawing.Color.Red;
            this.tsslStatus.Name = "tsslStatus";
            this.tsslStatus.Size = new System.Drawing.Size(884, 20);
            this.tsslStatus.Spring = true;
            this.tsslStatus.Text = "就绪";
            this.tsslStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(this.cbSavePic);
            groupBox1.Controls.Add(this.btnSave);
            groupBox1.Controls.Add(this.btnNoSel);
            groupBox1.Controls.Add(this.btnRSel);
            groupBox1.Controls.Add(this.btnSelAll);
            groupBox1.Controls.Add(this.btnGet);
            groupBox1.Location = new System.Drawing.Point(544, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(378, 252);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "操作";
            // 
            // cbSavePic
            // 
            this.cbSavePic.AutoSize = true;
            this.cbSavePic.Location = new System.Drawing.Point(61, 196);
            this.cbSavePic.Name = "cbSavePic";
            this.cbSavePic.Size = new System.Drawing.Size(91, 24);
            this.cbSavePic.TabIndex = 10;
            this.cbSavePic.Text = "保存图片";
            this.cbSavePic.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(33, 114);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(146, 48);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "保存选中";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnNoSel
            // 
            this.btnNoSel.Location = new System.Drawing.Point(208, 183);
            this.btnNoSel.Name = "btnNoSel";
            this.btnNoSel.Size = new System.Drawing.Size(146, 48);
            this.btnNoSel.TabIndex = 8;
            this.btnNoSel.Text = "取消选择";
            this.btnNoSel.UseVisualStyleBackColor = true;
            this.btnNoSel.Click += new System.EventHandler(this.BtnNoSel_Click);
            // 
            // btnRSel
            // 
            this.btnRSel.Location = new System.Drawing.Point(208, 114);
            this.btnRSel.Name = "btnRSel";
            this.btnRSel.Size = new System.Drawing.Size(146, 48);
            this.btnRSel.TabIndex = 8;
            this.btnRSel.Text = "反选";
            this.btnRSel.UseVisualStyleBackColor = true;
            this.btnRSel.Click += new System.EventHandler(this.BtnRSel_Click);
            // 
            // btnSelAll
            // 
            this.btnSelAll.Location = new System.Drawing.Point(208, 39);
            this.btnSelAll.Name = "btnSelAll";
            this.btnSelAll.Size = new System.Drawing.Size(146, 48);
            this.btnSelAll.TabIndex = 8;
            this.btnSelAll.Text = "全选";
            this.btnSelAll.UseVisualStyleBackColor = true;
            this.btnSelAll.Click += new System.EventHandler(this.BtnSelAll_Click);
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(33, 39);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(146, 48);
            this.btnGet.TabIndex = 8;
            this.btnGet.Text = "拉取";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.BtnGet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "博客园备份：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbPath
            // 
            this.tbPath.AllowDrop = true;
            this.tbPath.ContextMenuStrip = this.ms1;
            this.tbPath.Location = new System.Drawing.Point(126, 21);
            this.tbPath.Name = "tbPath";
            this.tbPath.ReadOnly = true;
            this.tbPath.Size = new System.Drawing.Size(362, 27);
            this.tbPath.TabIndex = 10;
            this.tbPath.TextChanged += new System.EventHandler(this.TBPathChanged);
            this.tbPath.DragDrop += new System.Windows.Forms.DragEventHandler(this.TbPath_DragDrop);
            this.tbPath.DragEnter += new System.Windows.Forms.DragEventHandler(this.TbPath_DragEnter);
            // 
            // ms1
            // 
            this.ms1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ms1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.清空ToolStripMenuItem});
            this.ms1.Name = "ms1";
            this.ms1.Size = new System.Drawing.Size(109, 28);
            // 
            // 清空ToolStripMenuItem
            // 
            this.清空ToolStripMenuItem.Name = "清空ToolStripMenuItem";
            this.清空ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.清空ToolStripMenuItem.Text = "清空";
            this.清空ToolStripMenuItem.Click += new System.EventHandler(this.ClearPath_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "备份目录：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbOut
            // 
            this.tbOut.AllowDrop = true;
            this.tbOut.ContextMenuStrip = this.ms2;
            this.tbOut.Location = new System.Drawing.Point(126, 71);
            this.tbOut.Name = "tbOut";
            this.tbOut.ReadOnly = true;
            this.tbOut.Size = new System.Drawing.Size(362, 27);
            this.tbOut.TabIndex = 10;
            this.tbOut.TextChanged += new System.EventHandler(this.TBPathChanged);
            this.tbOut.DragDrop += new System.Windows.Forms.DragEventHandler(this.TbOut_DragDrop);
            this.tbOut.DragEnter += new System.Windows.Forms.DragEventHandler(this.TbOut_DragEnter);
            // 
            // ms2
            // 
            this.ms2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ms2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.ms2.Name = "ms";
            this.ms2.Size = new System.Drawing.Size(109, 28);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(108, 24);
            this.toolStripMenuItem1.Text = "清空";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.ClearOut_Click);
            // 
            // clb
            // 
            this.clb.CheckOnClick = true;
            this.clb.FormattingEnabled = true;
            this.clb.Location = new System.Drawing.Point(25, 121);
            this.clb.Name = "clb";
            this.clb.Size = new System.Drawing.Size(503, 422);
            this.clb.TabIndex = 18;
            // 
            // btnLoad1
            // 
            this.btnLoad1.Location = new System.Drawing.Point(485, 21);
            this.btnLoad1.Name = "btnLoad1";
            this.btnLoad1.Size = new System.Drawing.Size(43, 27);
            this.btnLoad1.TabIndex = 20;
            this.btnLoad1.Text = "···";
            this.btnLoad1.UseVisualStyleBackColor = true;
            this.btnLoad1.Click += new System.EventHandler(this.BtnLoad1_Click);
            // 
            // btnLoad2
            // 
            this.btnLoad2.Location = new System.Drawing.Point(485, 71);
            this.btnLoad2.Name = "btnLoad2";
            this.btnLoad2.Size = new System.Drawing.Size(43, 27);
            this.btnLoad2.TabIndex = 20;
            this.btnLoad2.Text = "···";
            this.btnLoad2.UseVisualStyleBackColor = true;
            this.btnLoad2.Click += new System.EventHandler(this.BtnLoad2_Click);
            // 
            // od
            // 
            this.od.Filter = "xml文件|*.xml|所有文件|*.*";
            // 
            // fd
            // 
            this.fd.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // rbMD
            // 
            this.rbMD.AutoSize = true;
            this.rbMD.Checked = true;
            this.rbMD.Location = new System.Drawing.Point(614, 305);
            this.rbMD.Name = "rbMD";
            this.rbMD.Size = new System.Drawing.Size(109, 24);
            this.rbMD.TabIndex = 21;
            this.rbMD.TabStop = true;
            this.rbMD.Text = "MarkDown";
            this.rbMD.UseVisualStyleBackColor = true;
            // 
            // rbHTML
            // 
            this.rbHTML.AutoSize = true;
            this.rbHTML.Location = new System.Drawing.Point(778, 305);
            this.rbHTML.Name = "rbHTML";
            this.rbHTML.Size = new System.Drawing.Size(74, 24);
            this.rbHTML.TabIndex = 21;
            this.rbHTML.Text = "HTML";
            this.rbHTML.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(953, 584);
            this.Controls.Add(this.rbHTML);
            this.Controls.Add(this.rbMD);
            this.Controls.Add(this.btnLoad2);
            this.Controls.Add(this.btnLoad1);
            this.Controls.Add(this.clb);
            this.Controls.Add(groupBox1);
            this.Controls.Add(statusStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbOut);
            this.Controls.Add(this.tbPath);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cnblog备份分割";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            this.ms1.ResumeLayout(false);
            this.ms2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbOut;
        private System.Windows.Forms.ToolStripStatusLabel tsslStatus;
        private System.Windows.Forms.CheckedListBox clb;
        private System.Windows.Forms.CheckBox cbSavePic;
        private System.Windows.Forms.Button btnNoSel;
        private System.Windows.Forms.Button btnRSel;
        private System.Windows.Forms.Button btnSelAll;
        private System.Windows.Forms.Button btnLoad1;
        private System.Windows.Forms.Button btnLoad2;
        private System.Windows.Forms.OpenFileDialog od;
        private System.Windows.Forms.FolderBrowserDialog fd;
        private System.Windows.Forms.ToolTip tt;
        private System.Windows.Forms.ContextMenuStrip ms1;
        private System.Windows.Forms.ToolStripMenuItem 清空ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip ms2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.RadioButton rbMD;
        private System.Windows.Forms.RadioButton rbHTML;
    }
}

