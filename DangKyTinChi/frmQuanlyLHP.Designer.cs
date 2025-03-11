namespace DangKyTinChi
{
    partial class frmQuanlyLHP
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblKyHoc = new System.Windows.Forms.Label();
            this.comKyHoc = new System.Windows.Forms.ComboBox();
            this.btnInBC = new Guna.UI2.WinForms.Guna2Button();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dtTuNgay = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(428, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(467, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "BÁO CÁO DANH SÁCH LỚP HỌC PHẦN ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblKyHoc
            // 
            this.lblKyHoc.AutoSize = true;
            this.lblKyHoc.Location = new System.Drawing.Point(59, 118);
            this.lblKyHoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKyHoc.Name = "lblKyHoc";
            this.lblKyHoc.Size = new System.Drawing.Size(47, 16);
            this.lblKyHoc.TabIndex = 1;
            this.lblKyHoc.Text = "Kỳ học";
            // 
            // comKyHoc
            // 
            this.comKyHoc.FormattingEnabled = true;
            this.comKyHoc.Items.AddRange(new object[] {
            "2023-2024-2"});
            this.comKyHoc.Location = new System.Drawing.Point(147, 116);
            this.comKyHoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comKyHoc.Name = "comKyHoc";
            this.comKyHoc.Size = new System.Drawing.Size(149, 24);
            this.comKyHoc.TabIndex = 2;
            // 
            // btnInBC
            // 
            this.btnInBC.AutoRoundedCorners = true;
            this.btnInBC.BorderRadius = 15;
            this.btnInBC.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInBC.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInBC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInBC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInBC.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnInBC.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInBC.ForeColor = System.Drawing.Color.Black;
            this.btnInBC.Location = new System.Drawing.Point(1150, 116);
            this.btnInBC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInBC.Name = "btnInBC";
            this.btnInBC.Size = new System.Drawing.Size(141, 33);
            this.btnInBC.TabIndex = 3;
            this.btnInBC.Text = "In báo cáo";
            this.btnInBC.Click += new System.EventHandler(this.btnInBC_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoRoundedCorners = true;
            this.btnExit.BorderRadius = 15;
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnExit.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(1229, 685);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(141, 33);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "&Kết thúc";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(23, 180);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1347, 478);
            this.reportViewer1.TabIndex = 5;
            // 
            // dtDenNgay
            // 
            this.dtDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dtDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDenNgay.Location = new System.Drawing.Point(785, 116);
            this.dtDenNgay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtDenNgay.Name = "dtDenNgay";
            this.dtDenNgay.Size = new System.Drawing.Size(213, 22);
            this.dtDenNgay.TabIndex = 14;
            // 
            // dtTuNgay
            // 
            this.dtTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTuNgay.Location = new System.Drawing.Point(416, 116);
            this.dtTuNgay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtTuNgay.Name = "dtTuNgay";
            this.dtTuNgay.Size = new System.Drawing.Size(213, 22);
            this.dtTuNgay.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(707, 118);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Đến ngày";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Từ ngày";
            // 
            // frmQuanlyLHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 820);
            this.Controls.Add(this.dtDenNgay);
            this.Controls.Add(this.dtTuNgay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnInBC);
            this.Controls.Add(this.comKyHoc);
            this.Controls.Add(this.lblKyHoc);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(358, 169);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmQuanlyLHP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmQuanlyLHP";
            this.Load += new System.EventHandler(this.frmQuanlyLHP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblKyHoc;
        private System.Windows.Forms.ComboBox comKyHoc;
        private Guna.UI2.WinForms.Guna2Button btnInBC;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.DateTimePicker dtDenNgay;
        private System.Windows.Forms.DateTimePicker dtTuNgay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}