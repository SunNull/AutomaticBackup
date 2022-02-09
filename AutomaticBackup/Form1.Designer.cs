namespace AutomaticBackup
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnOK = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.lblold = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxold = new System.Windows.Forms.TextBox();
            this.tbxnew = new System.Windows.Forms.TextBox();
            this.btnAuto = new System.Windows.Forms.Button();
            this.btnNoAuto = new System.Windows.Forms.Button();
            this.btnNoAutoBak = new System.Windows.Forms.Button();
            this.nfi = new System.Windows.Forms.NotifyIcon(this.components);
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnA = new System.Windows.Forms.ToolStripMenuItem();
            this.btnexit = new System.Windows.Forms.ToolStripMenuItem();
            this.cms.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(80, 102);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(81, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "保存";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(189, 102);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(92, 23);
            this.btncancel.TabIndex = 0;
            this.btncancel.Text = "关闭";
            this.btncancel.UseVisualStyleBackColor = true;
            // 
            // lblold
            // 
            this.lblold.AutoSize = true;
            this.lblold.Location = new System.Drawing.Point(30, 25);
            this.lblold.Name = "lblold";
            this.lblold.Size = new System.Drawing.Size(44, 17);
            this.lblold.TabIndex = 1;
            this.lblold.Text = "原路径";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "备份路径";
            // 
            // tbxold
            // 
            this.tbxold.Location = new System.Drawing.Point(80, 22);
            this.tbxold.Name = "tbxold";
            this.tbxold.Size = new System.Drawing.Size(201, 23);
            this.tbxold.TabIndex = 3;
            // 
            // tbxnew
            // 
            this.tbxnew.Location = new System.Drawing.Point(80, 62);
            this.tbxnew.Name = "tbxnew";
            this.tbxnew.Size = new System.Drawing.Size(201, 23);
            this.tbxnew.TabIndex = 3;
            // 
            // btnAuto
            // 
            this.btnAuto.Location = new System.Drawing.Point(12, 131);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(81, 23);
            this.btnAuto.TabIndex = 4;
            this.btnAuto.Text = "自动备份";
            this.btnAuto.UseVisualStyleBackColor = true;
            // 
            // btnNoAuto
            // 
            this.btnNoAuto.Location = new System.Drawing.Point(99, 131);
            this.btnNoAuto.Name = "btnNoAuto";
            this.btnNoAuto.Size = new System.Drawing.Size(92, 23);
            this.btnNoAuto.TabIndex = 0;
            this.btnNoAuto.Text = "取消自动备份";
            this.btnNoAuto.UseVisualStyleBackColor = true;
            // 
            // btnNoAutoBak
            // 
            this.btnNoAutoBak.Location = new System.Drawing.Point(200, 131);
            this.btnNoAutoBak.Name = "btnNoAutoBak";
            this.btnNoAutoBak.Size = new System.Drawing.Size(81, 23);
            this.btnNoAutoBak.TabIndex = 4;
            this.btnNoAutoBak.Text = "手动备份";
            this.btnNoAutoBak.UseVisualStyleBackColor = true;
            // 
            // nfi
            // 
            this.nfi.ContextMenuStrip = this.cms;
            this.nfi.Icon = ((System.Drawing.Icon)(resources.GetObject("nfi.Icon")));
            this.nfi.Text = "自动备份";
            this.nfi.Visible = true;
            // 
            // cms
            // 
            this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnA,
            this.btnexit});
            this.cms.Name = "cms";
            this.cms.Size = new System.Drawing.Size(181, 70);
            // 
            // btnA
            // 
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(180, 22);
            this.btnA.Text = "手动备份";
            // 
            // btnexit
            // 
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(180, 22);
            this.btnexit.Text = "退出";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 174);
            this.Controls.Add(this.btnNoAutoBak);
            this.Controls.Add(this.btnAuto);
            this.Controls.Add(this.tbxnew);
            this.Controls.Add(this.tbxold);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblold);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnNoAuto);
            this.Controls.Add(this.btnOK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "自动备份";
            this.cms.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnOK;
        private Button btncancel;
        private Label lblold;
        private Label label2;
        private TextBox tbxold;
        private TextBox tbxnew;
        private Button btnAuto;
        private Button btnNoAuto;
        private Button btnNoAutoBak;
        private NotifyIcon nfi;
        private ContextMenuStrip cms;
        private ToolStripMenuItem btnA;
        private ToolStripMenuItem btnexit;
    }
}