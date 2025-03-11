namespace DangKyTinChi
{
    partial class frmTKB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTKB));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRpt = new Guna.UI2.WinForms.Guna2Button();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.lblfrmTKB = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label2 = new System.Windows.Forms.Label();
            this.comKyHoc = new System.Windows.Forms.ComboBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Navy;
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Location = new System.Drawing.Point(1, 1);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1505, 39);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(64, 0);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(49, 39);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 5;
            this.guna2PictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(133, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Thời khoá biểu";
            // 
            // btnRpt
            // 
            this.btnRpt.AutoRoundedCorners = true;
            this.btnRpt.BorderRadius = 19;
            this.btnRpt.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRpt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRpt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRpt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRpt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRpt.ForeColor = System.Drawing.Color.Black;
            this.btnRpt.Location = new System.Drawing.Point(1144, 137);
            this.btnRpt.Margin = new System.Windows.Forms.Padding(4);
            this.btnRpt.Name = "btnRpt";
            this.btnRpt.Size = new System.Drawing.Size(141, 41);
            this.btnRpt.TabIndex = 1;
            this.btnRpt.Text = "In báo cáo";
            this.btnRpt.Click += new System.EventHandler(this.btnRpt_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoRoundedCorners = true;
            this.btnExit.BorderRadius = 19;
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(1144, 623);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(141, 41);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "&Kết thúc";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblfrmTKB
            // 
            this.lblfrmTKB.AutoSize = true;
            this.lblfrmTKB.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfrmTKB.Location = new System.Drawing.Point(456, 65);
            this.lblfrmTKB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfrmTKB.Name = "lblfrmTKB";
            this.lblfrmTKB.Size = new System.Drawing.Size(437, 35);
            this.lblfrmTKB.TabIndex = 3;
            this.lblfrmTKB.Text = "THỜI KHÓA BIỂU SINH VIÊN";
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DangKyTinChi.rptTKB.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(47, 202);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1237, 406);
            this.reportViewer1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(205, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Kỳ học";
            // 
            // comKyHoc
            // 
            this.comKyHoc.FormattingEnabled = true;
            this.comKyHoc.Items.AddRange(new object[] {
            "2023-2024-2"});
            this.comKyHoc.Location = new System.Drawing.Point(272, 138);
            this.comKyHoc.Margin = new System.Windows.Forms.Padding(4);
            this.comKyHoc.Name = "comKyHoc";
            this.comKyHoc.Size = new System.Drawing.Size(165, 24);
            this.comKyHoc.TabIndex = 13;
            // 
            // frmTKB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1505, 873);
            this.Controls.Add(this.comKyHoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.lblfrmTKB);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRpt);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(327, 177);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmTKB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmTKB";
            this.Load += new System.EventHandler(this.frmTKB_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnRpt;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private System.Windows.Forms.Label lblfrmTKB;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comKyHoc;
    }
}