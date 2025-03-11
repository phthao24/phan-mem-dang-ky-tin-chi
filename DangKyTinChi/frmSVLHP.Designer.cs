namespace DangKyTinChi
{
    partial class frmSVLHP
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
            this.lblHP = new System.Windows.Forms.Label();
            this.lblLHP = new System.Windows.Forms.Label();
            this.lblKyHoc = new System.Windows.Forms.Label();
            this.comHP = new Guna.UI2.WinForms.Guna2ComboBox();
            this.comKyHoc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnInBC = new Guna.UI2.WinForms.Guna2Button();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.comLHP = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(347, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(548, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH SINH VIÊN THEO LỚP HỌC PHẦN";
            // 
            // lblHP
            // 
            this.lblHP.AutoSize = true;
            this.lblHP.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHP.Location = new System.Drawing.Point(305, 95);
            this.lblHP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHP.Name = "lblHP";
            this.lblHP.Size = new System.Drawing.Size(78, 19);
            this.lblHP.TabIndex = 1;
            this.lblHP.Text = "Học phần";
            // 
            // lblLHP
            // 
            this.lblLHP.AutoSize = true;
            this.lblLHP.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLHP.Location = new System.Drawing.Point(694, 95);
            this.lblLHP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLHP.Name = "lblLHP";
            this.lblLHP.Size = new System.Drawing.Size(107, 19);
            this.lblLHP.TabIndex = 2;
            this.lblLHP.Text = "Lớp học phần";
            // 
            // lblKyHoc
            // 
            this.lblKyHoc.AutoSize = true;
            this.lblKyHoc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKyHoc.Location = new System.Drawing.Point(18, 95);
            this.lblKyHoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKyHoc.Name = "lblKyHoc";
            this.lblKyHoc.Size = new System.Drawing.Size(59, 19);
            this.lblKyHoc.TabIndex = 3;
            this.lblKyHoc.Text = "Kỳ học";
            // 
            // comHP
            // 
            this.comHP.AutoRoundedCorners = true;
            this.comHP.BackColor = System.Drawing.Color.Transparent;
            this.comHP.BorderRadius = 17;
            this.comHP.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comHP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comHP.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comHP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comHP.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.comHP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comHP.ItemHeight = 30;
            this.comHP.Items.AddRange(new object[] {
            "Cấu trúc dữ liệu và giải thuật",
            "Chủ nghĩa xã hội",
            "Cơ sở lập trình",
            "Hệ thống thông tin quản lý",
            "Kinh tế vĩ mô 1",
            "Lập trình hướng đối tượng",
            "Lập trình nâng cao",
            "Lập trình Web",
            "Lịch sử Đảng Cộng sản Việt Nam",
            "Phát triển các hệ thống thông tin quản lý",
            "Tư tưởng Hồ Chí Minh"});
            this.comHP.Location = new System.Drawing.Point(389, 82);
            this.comHP.Margin = new System.Windows.Forms.Padding(4);
            this.comHP.Name = "comHP";
            this.comHP.Size = new System.Drawing.Size(277, 36);
            this.comHP.TabIndex = 4;
            this.comHP.SelectedIndexChanged += new System.EventHandler(this.comHP_SelectedIndexChanged);
            // 
            // comKyHoc
            // 
            this.comKyHoc.AutoRoundedCorners = true;
            this.comKyHoc.BackColor = System.Drawing.Color.Transparent;
            this.comKyHoc.BorderRadius = 17;
            this.comKyHoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comKyHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comKyHoc.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comKyHoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comKyHoc.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.comKyHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comKyHoc.ItemHeight = 30;
            this.comKyHoc.Items.AddRange(new object[] {
            "2023-2024-2"});
            this.comKyHoc.Location = new System.Drawing.Point(85, 82);
            this.comKyHoc.Margin = new System.Windows.Forms.Padding(4);
            this.comKyHoc.Name = "comKyHoc";
            this.comKyHoc.Size = new System.Drawing.Size(175, 36);
            this.comKyHoc.TabIndex = 6;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(3, 148);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1321, 457);
            this.reportViewer1.TabIndex = 7;
            // 
            // btnInBC
            // 
            this.btnInBC.AutoRoundedCorners = true;
            this.btnInBC.BorderRadius = 16;
            this.btnInBC.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInBC.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInBC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInBC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInBC.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnInBC.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnInBC.ForeColor = System.Drawing.Color.Black;
            this.btnInBC.Location = new System.Drawing.Point(1088, 82);
            this.btnInBC.Margin = new System.Windows.Forms.Padding(4);
            this.btnInBC.Name = "btnInBC";
            this.btnInBC.Size = new System.Drawing.Size(129, 34);
            this.btnInBC.TabIndex = 8;
            this.btnInBC.Text = "In báo cáo";
            this.btnInBC.Click += new System.EventHandler(this.btnInBC_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoRoundedCorners = true;
            this.btnExit.BorderRadius = 16;
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(1098, 635);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(129, 34);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "&Kết thúc";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // comLHP
            // 
            this.comLHP.AutoRoundedCorners = true;
            this.comLHP.BackColor = System.Drawing.Color.Transparent;
            this.comLHP.BorderRadius = 17;
            this.comLHP.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comLHP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comLHP.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comLHP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comLHP.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.comLHP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comLHP.ItemHeight = 30;
            this.comLHP.Items.AddRange(new object[] {
            "CNTT1128(224)_01",
            "CNTT1128(224)_02",
            "CNTT1128(224)_05",
            "CNTT1131(224)_01",
            "CNTT1188(224)_01",
            "KHMA1101(224)_01",
            "KHMA1101(224)_02",
            "LLDL1102(224)_01",
            "LLNL1107(224)_01",
            "LLNL1107(224)_02",
            "LLTT1101(224)_01",
            "LLTT1101(224)_02",
            "TIHT1101(224)_01",
            "TIHT1101(224)_02",
            "TIHT1102(224)_01",
            "TIHT1105(224)_01",
            "TIHT1105(224)_02",
            "TIKT1113(224)_01"});
            this.comLHP.Location = new System.Drawing.Point(808, 82);
            this.comLHP.Margin = new System.Windows.Forms.Padding(4);
            this.comLHP.Name = "comLHP";
            this.comLHP.Size = new System.Drawing.Size(241, 36);
            this.comLHP.TabIndex = 10;
            this.comLHP.SelectedIndexChanged += new System.EventHandler(this.comLHP_SelectedIndexChanged);
            // 
            // frmSVLHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 820);
            this.Controls.Add(this.comLHP);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnInBC);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.comKyHoc);
            this.Controls.Add(this.comHP);
            this.Controls.Add(this.lblKyHoc);
            this.Controls.Add(this.lblLHP);
            this.Controls.Add(this.lblHP);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(358, 169);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSVLHP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmSVLHP";
            this.Load += new System.EventHandler(this.frmSVLHP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHP;
        private System.Windows.Forms.Label lblLHP;
        private System.Windows.Forms.Label lblKyHoc;
        private Guna.UI2.WinForms.Guna2ComboBox comHP;
        private Guna.UI2.WinForms.Guna2ComboBox comKyHoc;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Guna.UI2.WinForms.Guna2Button btnInBC;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2ComboBox comLHP;
    }
}