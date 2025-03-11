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

    public partial class frmDangKy : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlDataAdapter daMaHP = new SqlDataAdapter();
        SqlDataAdapter daThoiGian = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable comdt = new DataTable();
        DataTable dtThoiGian = new DataTable();
        DataTable dtMaHP = new DataTable();
        string sql, constr;
        private string TenDN;
        DataTable txtdt = new DataTable();

        public frmDangKy(string tenDN)
        {
            InitializeComponent();
            TenDN = tenDN;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnQuayVe_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        private void btnKetQuaDK_Click(object sender, EventArgs e)
        {
            Form formKetQuaDK = new frmKetQuaDK(TenDN);
            formKetQuaDK.Show();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmDangKy_Load(object sender, EventArgs e)
        {
             constr = "Data Source=LAPTOP-MGOO2M8J;Initial Catalog=TinChiSQL;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();

            sql = "SELECT LopHP.MaLHP, HocPhan.MaHP, HocPhan.TenHP, HocPhan.SoTinChi,"
                + " LopHP.SySo, LopHP.ToiThieu, LopHP.ToiDa, LopHP.ThoiGian, LopHP.KyHoc,"
                + " LopHP.DiaDiem FROM SinhVien JOIN LopCN ON SinhVien.MaLopCN = LopCN.MaLopCN"
                + " JOIN ChuyenNganh ON LopCN.MaCN = ChuyenNganh.MaCN JOIN CTDT ON ChuyenNganh.MaCN = CTDT.MaCN"
                + " JOIN HocPhan ON CTDT.MaHP = HocPhan.MaHP JOIN LopHP ON HocPhan.MaHP = LopHP.MaHP WHERE LopHP.TTLHP = N'Đang mở' and SinhVien.MSV = @TenDN ;";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@TenDN", TenDN);
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            grdData.DataSource = dt;
            grdData.Refresh();
            Sohocphan();
            TongTin();
            NapCT();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (CheckDKDK())
            {
                DateTime currentTime = DateTime.Now;
                sql = " Insert Into TinChi (MaLHP ,MSV, ThoiGianDK,TTDK)"
               + "Values('" + txtMaLHP.Text + "', @TenDN, @currentTime,N'Đăng ký')";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@TenDN", TenDN);
                cmd.Parameters.AddWithValue("@currentTime", currentTime);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Đăng ký thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Naplai();
            }
        }

        private bool CheckDKDK()
        {
            //Kiểm tra quá số tín hay chưa
            string sqlsotin = "select sum(SoTinChi) AS TongTin from vw_KetQuaDK where MSV = @TenDN group by MSV";
            SqlCommand cmdsotin = new SqlCommand(sqlsotin, conn);
            cmdsotin.Parameters.AddWithValue("@TenDN", TenDN);
            // int tongtin = (int) cmdsotin.ExecuteScalar();

            object result = cmdsotin.ExecuteScalar();
            int tongtin = result != null ? Convert.ToInt32(result) : 0;
            string texttongtin = txtSoTinChi.Text;
            int themtin = Convert.ToInt32(texttongtin);
            if (tongtin + themtin > 14)
            {
               // MessageBox.Show("Không thể đăng ký vì sẽ quá số tín chỉ cho phép");
                MessageBox.Show("Không thể đăng ký vì sẽ quá số tín chỉ cho phép", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // đã đăng ký lớp này, môn này chưa?
            string sqlMaHP = "select MaHP, MSV from vw_KetQuaDK WHERE MaHP = '" + txtMaHP.Text + "' AND MSV = @TenDN ";
            SqlCommand cmdMaHP = new SqlCommand(sqlMaHP, conn);
            cmdMaHP.Parameters.AddWithValue("@TenDN", TenDN);
            daMaHP = new SqlDataAdapter(cmdMaHP);
            dtMaHP.Clear();
            daMaHP.Fill(dtMaHP);

            if (dtMaHP.Rows.Count > 0)
            {
                
                MessageBox.Show("Bạn đã đăng ký môn học này trước đó!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


            //kiểm tra lớp còn chỗ hay không
            string textSySo = txtSySo.Text;
            int SySo = Convert.ToInt32(textSySo);
            string textToiDa = txtToiDa.Text;
            int ToiDa = Convert.ToInt32(textToiDa);

            if (SySo == ToiDa)
            {
               
                MessageBox.Show("Lớp này đã đủ người!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            //đã qua môn tiên quyết hay chưa
            string sqlMonTQ = "SELECT KQHT.KetQua FROM KQHT JOIN HocPhan HP ON KQHT.MaHP = HP.MaMonTQ WHERE HP.MaHP = '" + txtMaHP.Text + "' AND KQHT.MSV = @TenDN ";
            SqlCommand cmdMonTQ = new SqlCommand(sqlMonTQ, conn);
            cmdMonTQ.Parameters.AddWithValue("@TenDN", TenDN);
            string quamon = (string)cmdMonTQ.ExecuteScalar();

            if (quamon == "Trượt")
            {
                
                MessageBox.Show("Bạn chưa hoàn thành môn tiên quyết!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            //có bị trùng lịch hay không 
            string sqlThoiGian = "select MaLHP, ThoiGian FROM vw_KetQuaDK where MSV = @TenDN AND ThoiGian = N'" + txtThoiGian.Text + "'";
            SqlCommand cmdThoiGian = new SqlCommand(sqlThoiGian, conn);
            cmdThoiGian.Parameters.AddWithValue("@TenDN", TenDN);
            daThoiGian = new SqlDataAdapter(cmdThoiGian);
            dtThoiGian.Clear();
            daThoiGian.Fill(dtThoiGian);

            if (dtThoiGian.Rows.Count > 0)
            {
                
                MessageBox.Show("Không thể đăng ký vì trùng lịch với lớp đã đăng ký trước đó!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


            return true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Naplai();
        }

        private void TongTin()
        {
            sql = "select MSV ,sum(SoTinChi) AS TongTin from vw_KetQuaDK where MSV = @TenDN group by MSV ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@TenDN", TenDN);
            da = new SqlDataAdapter(cmd);
            txtdt.Clear();
            da.Fill(txtdt);

            txtSotin.Text = txtdt.Rows[0]["TongTin"].ToString();
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
        private void Naplai()
        {
            sql = "SELECT LopHP.MaLHP, HocPhan.MaHP, HocPhan.TenHP, HocPhan.SoTinChi,"
               + " LopHP.SySo, LopHP.ToiThieu, LopHP.ToiDa, LopHP.ThoiGian, LopHP.KyHoc,"
               + " LopHP.DiaDiem FROM SinhVien JOIN LopCN ON SinhVien.MaLopCN = LopCN.MaLopCN"
               + " JOIN ChuyenNganh ON LopCN.MaCN = ChuyenNganh.MaCN JOIN CTDT ON ChuyenNganh.MaCN = CTDT.MaCN"
               + " JOIN HocPhan ON CTDT.MaHP = HocPhan.MaHP JOIN LopHP ON HocPhan.MaHP = LopHP.MaHP WHERE LopHP.TTLHP = N'Đang mở' and SinhVien.MSV = @TenDN ;";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@TenDN", TenDN);
            da = new SqlDataAdapter(cmd);
            dt.Clear();
            da.Fill(dt);
            grdData.DataSource = dt;
            grdData.Refresh();
            Sohocphan();
            TongTin();
            NapCT();
        }

       

        private void grdData_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

        private void comTentruong_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql = $"SELECT distinct HocPhan. {comTentruong.Text} "
               + "  FROM SinhVien JOIN LopCN ON SinhVien.MaLopCN = LopCN.MaLopCN"
               + " JOIN ChuyenNganh ON LopCN.MaCN = ChuyenNganh.MaCN JOIN CTDT ON ChuyenNganh.MaCN = CTDT.MaCN"
               + " JOIN HocPhan ON CTDT.MaHP = HocPhan.MaHP JOIN LopHP ON HocPhan.MaHP = LopHP.MaHP WHERE LopHP.TTLHP = N'Đang mở' and SinhVien.MSV = @TenDN ;";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@TenDN", TenDN);
            da = new SqlDataAdapter(cmd);
            comdt.Clear();
            da.Fill(comdt);
            comGiatri.DataSource = comdt;
            comGiatri.DisplayMember = comTentruong.Text;

          


        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(comTentruong.Text))
            {
                sql = "SELECT LopHP.MaLHP, HocPhan.MaHP, HocPhan.TenHP, HocPhan.SoTinChi,"
               + " LopHP.SySo, LopHP.ToiThieu, LopHP.ToiDa, LopHP.ThoiGian, LopHP.KyHoc,"
               + " LopHP.DiaDiem FROM SinhVien JOIN LopCN ON SinhVien.MaLopCN = LopCN.MaLopCN"
               + " JOIN ChuyenNganh ON LopCN.MaCN = ChuyenNganh.MaCN JOIN CTDT ON ChuyenNganh.MaCN = CTDT.MaCN"
               + " JOIN HocPhan ON CTDT.MaHP = HocPhan.MaHP JOIN LopHP ON HocPhan.MaHP = LopHP.MaHP"
               + $" WHERE LopHP.TTLHP = N'Đang mở' and SinhVien.MSV = @TenDN AND HocPhan. {comTentruong.Text} = N'{comGiatri.Text}' ;";

                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@TenDN", TenDN);
                da = new SqlDataAdapter(cmd);
                dt.Clear();
                da.Fill(dt);
                grdData.DataSource = dt;
                grdData.Refresh();
            }
            

            

        }

        public void NapCT()
        {
            if (grdData.CurrentRow != null)
            {
                int i = grdData.CurrentRow.Index;//lấy số thứ tự dòng hiện thời
                txtMaLHP.Text = grdData.Rows[i].Cells["MaLHP"].Value.ToString();
                txtMaHP.Text = grdData.Rows[i].Cells["MaHP"].Value.ToString();
                txtSySo.Text = grdData.Rows[i].Cells["SySo"].Value.ToString();
                txtToiDa.Text = grdData.Rows[i].Cells["ToiDa"].Value.ToString();
                txtToiThieu.Text = grdData.Rows[i].Cells["ToiThieu"].Value.ToString();
                txtThoiGian.Text = grdData.Rows[i].Cells["ThoiGian"].Value.ToString();
                txtSoTinChi.Text = grdData.Rows[i].Cells["SoTinChi"].Value.ToString();
                txtDiaDiem.Text = grdData.Rows[i].Cells["DiaDiem"].Value.ToString();
                txtTenHP.Text = grdData.Rows[i].Cells["TenHP"].Value.ToString();
            }
                

        }
    }
}
