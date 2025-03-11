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
using System.Windows.Forms;

namespace DangKyTinChi
{
    public partial class frmRptLHPHuy : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        string sql, constr, para1, para2;

        private void btnInBC_Click(object sender, EventArgs e)
        {
            sql = "Select MaHP, MaLHP, SySo, ToiThieu, ToiDa, ThoiGian, DiaDiem, MaGV, TTLHP from LopHP" +
                " where KyHoc = '" + comKyHoc.Text + "' and TTLHP = N'Đã hủy'";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            ReportDataSource rds = new ReportDataSource("dtsLHPHuy", dt);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.ReportEmbeddedResource = "DangKyTinChi.rptLHPHuy.rdlc";
            para1 = "Kỳ học: " + comKyHoc.Text;
            para2 = "Từ ngày " + dtTuNgay.Text + " đến ngày " + dtDenNgay.Text;
            ReportParameter[] reportParameters = new ReportParameter[]
            {
                new ReportParameter("prKyHoc",para1),
                new ReportParameter("prThoiGian",para2)
            };
            reportViewer1.LocalReport.SetParameters(reportParameters);
            reportViewer1.RefreshReport();
        }

        private void frmRptLHPHuy_Load(object sender, EventArgs e)
        {
            constr = "Data Source=LAPTOP-MGOO2M8J;Initial Catalog=TinChiSQL;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
        }

        public frmRptLHPHuy()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
