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
    public partial class frmLichSuDK : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        string sql, constr;
        private string TenDN;
        DataTable comdt = new DataTable();

        public frmLichSuDK(string tenDN)
        {
            InitializeComponent();
            TenDN = tenDN;
        }

        private void btnQuayVe_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        private void frmLichSuDK_Load(object sender, EventArgs e)
        {
            constr = "Data Source=LAPTOP-MGOO2M8J;Initial Catalog=TinChiSQL;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();


            sql = "SELECT tc.MaLHP,tc.MSV,hp.MaHP,lhp.KyHoc , hp.TenHP, hp.SoTinChi, tc.ThoiGianDK,"
                + "  tc.TTDK FROM  TinChi tc JOIN LopHP lhp ON tc.MaLHP = lhp.MaLHP"
                + " JOIN HocPhan hp ON lhp.MaHP = hp.MaHP WHERE MSV = @TenDN ORDER BY ThoiGianDK DESC ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@TenDN", TenDN);
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            grdData.DataSource = dt;
            grdData.Refresh();
            NapCT();
        }
        public void NapCT()
        {
            if (grdData.CurrentRow != null)
            {
                int i = grdData.CurrentRow.Index;//lấy số thứ tự dòng hiện thời
                txtMaLHP.Text = grdData.Rows[i].Cells["MaLHP"].Value.ToString();
                txtMaHP.Text = grdData.Rows[i].Cells["MaHP"].Value.ToString();

                txtSoTinChi.Text = grdData.Rows[i].Cells["SoTinChi"].Value.ToString();

                txtTenHP.Text = grdData.Rows[i].Cells["TenHP"].Value.ToString();
                txtThoiGianDK.Text = grdData.Rows[i].Cells["ThoiGianDK"].Value.ToString();
                txtKyHoc.Text = grdData.Rows[i].Cells["KyHoc"].Value.ToString();
                txtMSV.Text = grdData.Rows[i].Cells["MSV"].Value.ToString();
                txtTTDK.Text = grdData.Rows[i].Cells["TTDK"].Value.ToString();
            }
            
        }

        private void grdData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

        private void comTentruong_SelectedIndexChanged(object sender, EventArgs e)
        {
                sql = $"SELECT DISTINCT hp. {comTentruong.Text} "
                + " FROM  TinChi tc JOIN LopHP lhp ON tc.MaLHP = lhp.MaLHP"
                + " JOIN HocPhan hp ON lhp.MaHP = hp.MaHP WHERE MSV = @TenDN  ";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@TenDN", TenDN);
                da = new SqlDataAdapter(cmd);
                comdt.Clear();
                da.Fill(comdt);
                comGiatri.DataSource = comdt;
                comGiatri.DisplayMember = comTentruong.Text;
        }

        private void btnFillter_Click(object sender, EventArgs e)
        {
            
            
            if (string.IsNullOrWhiteSpace(comTentruong.Text) && string.IsNullOrWhiteSpace(comKyHoc.Text))
            {
                Naplai();
            }
            else if(string.IsNullOrWhiteSpace(comTentruong.Text))
                {
                        sql = "SELECT tc.MaLHP,tc.MSV,hp.MaHP,lhp.KyHoc,  hp.TenHP, hp.SoTinChi, tc.ThoiGianDK,"
                        + "  tc.TTDK FROM  TinChi tc JOIN LopHP lhp ON tc.MaLHP = lhp.MaLHP"
                        + $" JOIN HocPhan hp ON lhp.MaHP = hp.MaHP WHERE MSV = @TenDN "
                        + $"  and lhp.Kyhoc ='{comKyHoc.Text}' ORDER BY ThoiGianDK DESC ";

                        cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@TenDN", TenDN);
                        da = new SqlDataAdapter(cmd);
                        dt.Clear();
                        da.Fill(dt);
                        grdData.DataSource = dt;
                        grdData.Refresh();
                        NapCT();

                    
                }else if(string.IsNullOrWhiteSpace(comKyHoc.Text))
                     {
                        sql = "SELECT tc.MaLHP,tc.MSV,hp.MaHP,lhp.KyHoc,  hp.TenHP, hp.SoTinChi, tc.ThoiGianDK,"
                        + "  tc.TTDK FROM  TinChi tc JOIN LopHP lhp ON tc.MaLHP = lhp.MaLHP"
                        + $" JOIN HocPhan hp ON lhp.MaHP = hp.MaHP WHERE MSV = @TenDN "
                        + $" AND hp. {comTentruong.Text} = N'{comGiatri.Text}' ORDER BY ThoiGianDK DESC ";

                        cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@TenDN", TenDN);
                        da = new SqlDataAdapter(cmd);
                        dt.Clear();
                        da.Fill(dt);
                        grdData.DataSource = dt;
                        grdData.Refresh();
                        NapCT();
                     }else
                        {
                                sql = "SELECT tc.MaLHP,tc.MSV,hp.MaHP,lhp.KyHoc,  hp.TenHP, hp.SoTinChi, tc.ThoiGianDK,"
                           + "  tc.TTDK FROM  TinChi tc JOIN LopHP lhp ON tc.MaLHP = lhp.MaLHP"
                           + $" JOIN HocPhan hp ON lhp.MaHP = hp.MaHP WHERE MSV = @TenDN "
                           + $" AND hp. {comTentruong.Text} = N'{comGiatri.Text}' and lhp.Kyhoc ='{comKyHoc.Text}' ORDER BY ThoiGianDK DESC ";

                                cmd = new SqlCommand(sql, conn);
                                cmd.Parameters.AddWithValue("@TenDN", TenDN);
                                da = new SqlDataAdapter(cmd);
                                dt.Clear();
                                da.Fill(dt);
                                grdData.DataSource = dt;
                                grdData.Refresh();
                                NapCT();
                         }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Naplai();
        }

        private void Naplai()
        {
            // sql = " select MaDK, MaLHP , MAHP, TenHP, SoTinChi, ThoiGian, DiaDiem,KyHoc, ThoiGianDK, TTLHP FROM vw_KetQuaDK WHERE MSV =@TenDN";

            sql = "SELECT tc.MaLHP,tc.MSV,hp.MaHP, lhp.KyHoc, hp.TenHP, hp.SoTinChi, tc.ThoiGianDK,"
              + "  tc.TTDK FROM  TinChi tc JOIN LopHP lhp ON tc.MaLHP = lhp.MaLHP"
              + " JOIN HocPhan hp ON lhp.MaHP = hp.MaHP WHERE MSV = @TenDN ORDER BY ThoiGianDK DESC ";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@TenDN", TenDN);
            da = new SqlDataAdapter(cmd);
            dt.Clear();
            da.Fill(dt);
            grdData.DataSource = dt;
            grdData.Refresh();
           
            NapCT();
        }

    }
}
