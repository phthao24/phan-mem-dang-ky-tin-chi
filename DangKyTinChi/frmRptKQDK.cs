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

namespace DangKyTinChi
{
    public partial class frmRptKQDK : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        string sql, constr, para1, para2;
        string TenDN;
        public frmRptKQDK(string tenDN)
        {
            InitializeComponent();
            TenDN = tenDN;
        }

        private void frmRptKQDK_Load(object sender, EventArgs e)
        {
            constr = "Data Source=LAPTOP-MGOO2M8J;Initial Catalog=TinChiSQL;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInBC_Click(object sender, EventArgs e)
        {
            sql = "SELECT MaDK, MaLHP, TenHP, SySo, SoTinChi, ThoiGian, DiaDiem, TTDK " +
                "FROM vw_KetQuaDK " +
                "where MSV = @TenDN and KyHoc = '" + comKyHoc.Text + "' and TTLHP != 'Đã hủy';";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@TenDN", TenDN);
            da = new SqlDataAdapter(cmd);
            dt.Clear();
            da.Fill(dt);
            ReportDataSource rds = new ReportDataSource("dtsKQDK", dt);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.ReportEmbeddedResource = "DangKyTinChi.rptKQDK.rdlc";
            para1 = "Kỳ học: " + comKyHoc.Text;
            para2 = "Mã sinh viên: " + TenDN;
            ReportParameter[] reportParameters = new ReportParameter[]
            {
                new ReportParameter("prKyHoc",para1),
                new ReportParameter("prMSV",para2)
            };
            reportViewer1.LocalReport.SetParameters(reportParameters);
            reportViewer1.RefreshReport();
        }
    }
}
