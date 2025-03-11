using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls.WebParts;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace DangKyTinChi
{
    public partial class frmSVLHP : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable comdt = new DataTable();
        string sql, constr, para1, para2, para3;
        public frmSVLHP()
        {
            InitializeComponent();
        }

        private void frmSVLHP_Load(object sender, EventArgs e)
        {
            constr = "Data Source=LAPTOP-MGOO2M8J;Initial Catalog=TinChiSQL;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            
        }

        private void comHP_SelectedIndexChanged(object sender, EventArgs e)
        {
            //sql = "SELECT MaHP, TenHP  FROM vw_KetQuaDK ";
            //da = new SqlDataAdapter(sql, conn);
            //DataTable comdt = new DataTable();
            //comdt.Clear();
            //da.Fill(comdt);
            //comLHP.DataSource = comdt;
            //comLHP.DisplayMember = "MaLHP";
            sql = "Select distinct MaLHP From LopHP where TTLHP !=N'Đã hủy' and MaHP in (Select MaHP From HocPhan where TenHP = N'" + comHP.Text + "')";
            da = new SqlDataAdapter(sql, conn);
            comdt.Clear();
            da.Fill(comdt);
            comLHP.DataSource = comdt;
            comLHP.DisplayMember = "MaLHP";
            comLHP.ValueMember = "MaLHP";

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnInBC_Click(object sender, EventArgs e)
        {
            sql = "SELECT SinhVien.MSV, SinhVien.TenSV, SinhVien.NgaySinh, SinhVien.MaLopCN " +
                "FROM SinhVien INNER JOIN vw_KetQuaDK " +
                "ON SinhVien.MSV = vw_KetQuaDK.MSV " +
                "where MaLHP = '" + comLHP.Text + "' and KyHoc = '" + comKyHoc.Text + "'";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            ReportDataSource rds = new ReportDataSource("dtsSVLHP", dt);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.ReportEmbeddedResource = "DangKyTinChi.rptSVLHP.rdlc";
            para1 = comLHP.Text;
            para2 = "Học phần: " + comHP.Text;
            para3 = "Kỳ học: " + comKyHoc.Text;
            ReportParameter[] reportParameters = new ReportParameter[]
            {
                new ReportParameter("prLHP",para1),
                new ReportParameter("prHP",para2),
                new ReportParameter("prKyHoc",para3)
            };
            reportViewer1.LocalReport.SetParameters(reportParameters);
            reportViewer1.RefreshReport();
        }

        private void comLHP_SelectedIndexChanged(object sender, EventArgs e)
        {
            //sql = "SELECT LopHP.MaLHP FROM HocPhan INNER JOIN LopHP ON HocPhan.MaHP = LopHP.MaHP " +
            //    "where TenHP = N'" + comHP.Text + "'";
            //da = new SqlDataAdapter(sql, conn);
            //DataTable comdt = new DataTable();
            //comdt.Clear();
            //da.Fill(comdt);
            //comLHP.DataSource = comdt;
            //comLHP.DisplayMember = "MaLHP";
        }
    }
}
