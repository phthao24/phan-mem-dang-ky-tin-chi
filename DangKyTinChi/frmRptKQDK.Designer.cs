namespace DangKyTinChi
{
    partial class frmRptKQDK
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnInBC = new Guna.UI2.WinForms.Guna2Button();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.comKyHoc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblKyHoc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(98, 194);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1255, 467);
            this.reportViewer1.TabIndex = 0;
            // 
            // btnInBC
            // 
            this.btnInBC.AutoRoundedCorners = true;
            this.btnInBC.BorderRadius = 24;
            this.btnInBC.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInBC.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInBC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInBC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInBC.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnInBC.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInBC.ForeColor = System.Drawing.Color.Black;
            this.btnInBC.Location = new System.Drawing.Point(1115, 109);
            this.btnInBC.Name = "btnInBC";
            this.btnInBC.Size = new System.Drawing.Size(183, 51);
            this.btnInBC.TabIndex = 1;
            this.btnInBC.Text = "In báo cáo";
            this.btnInBC.Click += new System.EventHandler(this.btnInBC_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoRoundedCorners = true;
            this.btnExit.BorderRadius = 24;
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(1143, 688);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(183, 51);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Kết thúc";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // comKyHoc
            // 
            this.comKyHoc.BackColor = System.Drawing.Color.Transparent;
            this.comKyHoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comKyHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comKyHoc.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comKyHoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comKyHoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comKyHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comKyHoc.ItemHeight = 30;
            this.comKyHoc.Items.AddRange(new object[] {
            "2023-2024-1",
            "2023-2024-2"});
            this.comKyHoc.Location = new System.Drawing.Point(220, 124);
            this.comKyHoc.Name = "comKyHoc";
            this.comKyHoc.Size = new System.Drawing.Size(209, 36);
            this.comKyHoc.TabIndex = 3;
            // 
            // lblKyHoc
            // 
            this.lblKyHoc.AutoSize = true;
            this.lblKyHoc.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKyHoc.Location = new System.Drawing.Point(153, 133);
            this.lblKyHoc.Name = "lblKyHoc";
            this.lblKyHoc.Size = new System.Drawing.Size(59, 19);
            this.lblKyHoc.TabIndex = 4;
            this.lblKyHoc.Text = "Kỳ học";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(542, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "KẾT QUẢ ĐĂNG KÝ TÍN CHỈ";
            // 
            // frmRptKQDK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 820);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblKyHoc);
            this.Controls.Add(this.comKyHoc);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnInBC);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(358, 169);
            this.Name = "frmRptKQDK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmRptKQDK";
            this.Load += new System.EventHandler(this.frmRptKQDK_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Guna.UI2.WinForms.Guna2Button btnInBC;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2ComboBox comKyHoc;
        private System.Windows.Forms.Label lblKyHoc;
        private System.Windows.Forms.Label label1;
    }
}