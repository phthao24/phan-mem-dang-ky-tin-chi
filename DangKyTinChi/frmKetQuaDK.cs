using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DangKyTinChi
{
    public partial class frmKetQuaDK : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable txtdt = new DataTable();
        string sql, constr;
        private string TenDN;
        DataTable comdt = new DataTable();
        public frmKetQuaDK(string tenDN)
        {
            InitializeComponent();
            TenDN = tenDN;
        }

        private void btnQuayVe_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        private void btnHuyDK_Click(object sender, EventArgs e)
        {
            int i = grdData.CurrentRow.Index;
            if( grdData.Rows[i].Cells["TTLHP"].Value.ToString()== "Đang mở")
            {
                if (MessageBox.Show(" Bạn có muốn hủy lớp học phần này?", "Xác nhận yêu cầu xóa"
               , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {


                    DateTime currentTime = DateTime.Now;
                    sql = " Insert Into TinChi (MaLHP ,MSV, ThoiGianDK,TTDK)"
                   + "Values('" + txtMaLHP.Text + "', @TenDN, @currentTime,N'Hủy đăng ký')";
                    cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@TenDN", TenDN);
                    cmd.Parameters.AddWithValue("@currentTime", currentTime);

                    cmd.ExecuteNonQuery();

                    Naplai();
                }
            }

            
            

        }

        private void frmKetQuaDK_Load(object sender, EventArgs e)
        {
            constr = "Data Source=LAPTOP-MGOO2M8J;Initial Catalog=TinChiSQL;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();

            sql = " select MaLHP , MaHP, TenHP, SoTinChi, SySo, ToiThieu, ToiDa, ThoiGian, DiaDiem,KyHoc, ThoiGianDK, TTLHP "
                +" FROM vw_KetQuaDK WHERE MSV =@TenDN" ;
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@TenDN", TenDN);
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            grdData.DataSource = dt;
            grdData.Refresh();
            TongTin();
            Sohocphan();
            NapCT();
        }
        private void TongTin()
        {
            sql = "select MSV ,sum(SoTinChi) AS TongTin from vw_KetQuaDK where MSV = @TenDN group by MSV ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@TenDN", TenDN);
            da = new SqlDataAdapter(cmd);
            txtdt.Clear();
            da.Fill(txtdt);

            txtSoTin.Text = txtdt.Rows[0]["TongTin"].ToString();

        }
        private void Sohocphan()
        {
            sql = "select MSV ,count(MaLHP) AS Sohocphan from vw_KetQuaDK where MSV = @TenDN group by MSV ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@TenDN", TenDN);
            da = new SqlDataAdapter(cmd);
            txtdt.Clear();
            da.Fill(txtdt);

            txtSohocphan.Text = txtdt.Rows[0]["Sohocphan"].ToString();
        }
        public void NapCT()
        {
            int i = grdData.CurrentRow.Index;//lấy số thứ tự dòng hiện thời
            txtMaLHP.Text = grdData.Rows[i].Cells["MaLHP"].Value.ToString();
            //txtMaHP.Text = grdData.Rows[i].Cells["MaHP"].Value.ToString();
            txtThoiGian.Text = grdData.Rows[i].Cells["ThoiGian"].Value.ToString();
            txtSoTinChi.Text = grdData.Rows[i].Cells["SoTinChi"].Value.ToString();
            txtDiaDiem.Text = grdData.Rows[i].Cells["DiaDiem"].Value.ToString();
            txtTenHP.Text = grdData.Rows[i].Cells["TenHP"].Value.ToString();
            txtThoiGianDK.Text = grdData.Rows[i].Cells["ThoiGianDK"].Value.ToString();
            txtSySo.Text = grdData.Rows[i].Cells["SySo"].Value.ToString();
            txtToiThieu.Text = grdData.Rows[i].Cells["ToiThieu"].Value.ToString();
            txtToiDa.Text = grdData.Rows[i].Cells["ToiDa"].Value.ToString();
        }

        private void grdData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

        private void btnXuatphieu_Click(object sender, EventArgs e)
        {
            Form a = new frmRptKQDK(TenDN);
            a.Show();
        }

        private void Naplai()
        {
            sql = " select MaLHP , MAHP, TenHP, SoTinChi,SySo,ToiThieu,ToiDa, ThoiGian, DiaDiem,KyHoc, ThoiGianDK FROM vw_KetQuaDK WHERE MSV =@TenDN";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@TenDN", TenDN);
            da = new SqlDataAdapter(cmd);
            dt.Clear();
            da.Fill(dt);
            grdData.DataSource = dt;
            grdData.Refresh();
            TongTin();
            Sohocphan();
            NapCT();
        }
    }
}
