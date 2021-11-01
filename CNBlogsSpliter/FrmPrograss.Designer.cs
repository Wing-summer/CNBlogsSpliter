
namespace CNBlogsSpliter
{
    partial class FrmPrograss
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbInfo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.prBar = new System.Windows.Forms.ProgressBar();
            this.btnCancel = new System.Windows.Forms.Button();
            this.bworker = new System.ComponentModel.BackgroundWorker();

            this.SuspendLayout();
            // 
            // tbInfo
            // 
            this.tbInfo.BackColor = System.Drawing.Color.Black;
            this.tbInfo.ForeColor = System.Drawing.Color.White;
            this.tbInfo.Location = new System.Drawing.Point(30, 138);
            this.tbInfo.Multiline = true;
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.ReadOnly = true;
            this.tbInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbInfo.Size = new System.Drawing.Size(535, 291);
            this.tbInfo.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "进度：";

            // 
            // bworker
            // 
            this.bworker.WorkerReportsProgress = true;
            this.bworker.WorkerSupportsCancellation = true;
            this.bworker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Bworker_DoWork);
            this.bworker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.Bworker_ProgressChanged);
            this.bworker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.Bworker_RunWorkerCompleted);

            // 
            // prBar
            // 
            this.prBar.Location = new System.Drawing.Point(97, 25);
            this.prBar.Name = "prBar";
            this.prBar.Size = new System.Drawing.Size(468, 31);
            this.prBar.TabIndex = 22;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(214, 80);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(167, 40);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // FrmPrograss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 457);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.prBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbInfo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrograss";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "正在处理中……";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrograss_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPrograss_FormClosed);
            this.Shown += new System.EventHandler(this.FrmPrograss_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar prBar;
        private System.Windows.Forms.Button btnCancel;
        public System.ComponentModel.BackgroundWorker bworker;

    }
}