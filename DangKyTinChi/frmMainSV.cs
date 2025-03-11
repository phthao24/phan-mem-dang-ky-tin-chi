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
    public partial class frmMainSV : Form
    {

        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        SqlCommand cmdctdt = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable comdt = new DataTable();
        string sql,sqlctdt, sqlchuyennganh,constr;


        private string TenDN;
        public frmMainSV(string tenDN)
        {
            InitializeComponent();
            TenDN = tenDN;
            
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            Form formDangKy = new frmDangKy(TenDN);
            formDangKy.Show();
        }

        private void btnLichSu_Click(object sender, EventArgs e)
        {
            Form formLichSuDK = new frmLichSuDK(TenDN); 
            formLichSuDK.Show();
        }

        private void btnKetQua_Click(object sender, EventArgs e)
        {
            Form formKetQuaDK = new frmKetQuaDK(TenDN);
            formKetQuaDK.Show();
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            Form formTraCuu = new frmTraCuu(TenDN);
            formTraCuu.Show();
        }

        private void btnTKB_Click(object sender, EventArgs e)
        {

            Form formTKB = new frmTKB(TenDN);
            formTKB.Show();
        }

        private void btnDangXuat_Click_1(object sender, EventArgs e)
        {
            Form formDangNhap = new frmDangNhap();
            formDangNhap.Show();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void grdDataCN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

        private void btnFillter_Click(object sender, EventArgs e)
        {
           if (!string.IsNullOrWhiteSpace(comTentruong.Text))
            {
                sql = "SELECT hp.MaHP,hp.TenHP,hp.SoTinChi,hp.MaMonTQ FROM SinhVien sv "
               + "JOIN  LopCN lcn ON sv.MaLopCN = lcn.MaLopCN JOIN  ChuyenNganh cn ON lcn.MaCN = cn.MaCN "
               + "JOIN  CTDT ctdt ON cn.MaCN = ctdt.MaCN "
               + $"JOIN  HocPhan hp ON ctdt.MaHP = hp.MaHP WHERE sv.MSV = @TenDN AND hp. {comTentruong.Text} = N'{comGiatri.Text}' ";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@TenDN", TenDN);
                da = new SqlDataAdapter(cmd);
                dt.Clear();
                da.Fill(dt);
                grdData.DataSource = dt;
                grdData.Refresh();
            }

           

        }

        private void btnNaplai_Click(object sender, EventArgs e)
        {

            sqlctdt = "SELECT hp.MaHP,hp.TenHP,hp.SoTinChi,hp.MaMonTQ FROM SinhVien sv "
                + "JOIN  LopCN lcn ON sv.MaLopCN = lcn.MaLopCN JOIN  ChuyenNganh cn ON lcn.MaCN = cn.MaCN "
                + "JOIN    CTDT ctdt ON cn.MaCN = ctdt.MaCN JOIN   HocPhan hp ON ctdt.MaHP = hp.MaHP WHERE sv.MSV = @TenDN ";
            cmdctdt = new SqlCommand(sqlctdt, conn);
            cmdctdt.Parameters.AddWithValue("@TenDN", TenDN);
            da = new SqlDataAdapter(cmdctdt);
            da.Fill(dt);
            grdData.DataSource = dt;
            grdData.Refresh();

        }

        private void btnHuongDan_Click(object sender, EventArgs e)
        {

        }

        private void comTentruong_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if(comTentruong.Text != "TenHH")
            {
                //sql = "Select Distinct " + comTentruong.Text + " From tblDMHH ";

                //da = new SqlDataAdapter(sql, conn);
                //comdt.Clear();
                //da.Fill(comdt);
                //comGiatri.DataSource = comdt;
                //comGiatri.DisplayMember = comTentruong.Text;

                sql = "SELECT hp. "+ comTentruong.Text + " FROM SinhVien sv "
                + "JOIN  LopCN lcn ON sv.MaLopCN = lcn.MaLopCN JOIN  ChuyenNganh cn ON lcn.MaCN = cn.MaCN "
                + "JOIN    CTDT ctdt ON cn.MaCN = ctdt.MaCN JOIN   HocPhan hp ON ctdt.MaHP = hp.MaHP WHERE sv.MSV = @TenDN ";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@TenDN", TenDN);
                da = new SqlDataAdapter(cmd);
                comdt.Clear();
                da.Fill(comdt);
                comGiatri.DataSource = comdt;
                comGiatri.DisplayMember = comTentruong.Text;

                



            }
            //else
            //{
            //    sql = "Select Distinct MaHH, TenHH  From tblDMHH ";
            //    da = new SqlDataAdapter(sql, conn);
            //    comdt.Clear();
            //    da.Fill(comdt);
            //    comGiatri.DataSource = comdt;
            //    comGiatri.DisplayMember = "TenHH";
            //}

        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmMainSV_Load(object sender, EventArgs e)
        {
            lblMSV.Text = @TenDN;


            constr = "Data Source=LAPTOP-MGOO2M8J;Initial Catalog=TinChiSQL;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();

            sql = " select TenSV from SinhVien Where MSV = @TenDN ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@TenDN", TenDN);
            string TenSV = (string)cmd.ExecuteScalar();
            lblTenSV.Text = TenSV;

            sqlchuyennganh = "select ChuyenNganh. TenCN from ChuyenNganh "
                +" JOIN LopCN on ChuyenNganh. MaCN = LopCN. MaCN "
                +"join SinhVien on SinhVien. MaLopCN = LopCn. MaLopCN where SinhVien. MSV = @TenDN";
            SqlCommand cmdcn = new SqlCommand(sqlchuyennganh, conn);
            cmdcn.Parameters.AddWithValue("@TenDN", TenDN);
            string chuyennganh = (string)cmdcn.ExecuteScalar();
            txtChuyennganh.Text = chuyennganh;




            sqlctdt = "SELECT hp.MaHP,hp.TenHP,hp.SoTinChi,hp.MaMonTQ FROM SinhVien sv "
                + "JOIN  LopCN lcn ON sv.MaLopCN = lcn.MaLopCN JOIN  ChuyenNganh cn ON lcn.MaCN = cn.MaCN "
                + "JOIN    CTDT ctdt ON cn.MaCN = ctdt.MaCN JOIN   HocPhan hp ON ctdt.MaHP = hp.MaHP WHERE sv.MSV = @TenDN ";
            cmdctdt = new SqlCommand(sqlctdt, conn);
            cmdctdt.Parameters.AddWithValue("@TenDN", TenDN);
            da = new SqlDataAdapter(cmdctdt);
            da.Fill(dt);
            grdData.DataSource = dt;
            grdData.Refresh();


        }
    }
}
