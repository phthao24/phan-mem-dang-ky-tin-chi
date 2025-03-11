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
    public partial class frmTKB : Form
    {
        private string TenDN;

        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        string sql, constr, para1, para2;
        public frmTKB(string tenDN)
        {
            InitializeComponent();
            TenDN = tenDN;
        }

        private void btnRpt_Click(object sender, EventArgs e)
        {
            sql = "select ThoiGian, MaLHP, TenHP, SoTinChi, SySo, DiaDiem from vw_KetQuaDK " +
                "where MSV = @TenDN and TTLHP != N'Đã hủy' and KyHoc = '" + comKyHoc.Text + "' order by ThoiGian";

            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@TenDN", TenDN);
            da = new SqlDataAdapter(cmd);
            dt.Clear();
            da.Fill(dt);
            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.ReportEmbeddedResource = "DangKyTinChi.rptTKB.rdlc";
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        //private void btnQuayVe_Click(object sender, EventArgs e)
        //{
        //    Form.ActiveForm.Close();
        //}

        private void frmTKB_Load(object sender, EventArgs e)
        {
            constr = "Data Source=LAPTOP-MGOO2M8J;Initial Catalog=TinChiSQL;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
        }    
    }
}

