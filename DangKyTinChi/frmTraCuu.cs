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
    public partial class frmTraCuu : Form
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

        public frmTraCuu(string tenDN)
        {
            InitializeComponent();
            TenDN = tenDN;
        }

        private void btnQuayVe_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        private void frmTraCuu_Load(object sender, EventArgs e)
        {
            constr = "Data Source=LAPTOP-MGOO2M8J;Initial Catalog=TinChiSQL;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();

            sql = "SELECT LopHP.MaLHP, HocPhan.MaHP, HocPhan.TenHP, HocPhan.SoTinChi,"
                + " LopHP.ToiThieu, LopHP.ToiDa, LopHP.ThoiGian, LopHP.KyHoc,"
                + " LopHP.DiaDiem FROM SinhVien JOIN LopCN ON SinhVien.MaLopCN = LopCN.MaLopCN"
                + " JOIN ChuyenNganh ON LopCN.MaCN = ChuyenNganh.MaCN JOIN CTDT ON ChuyenNganh.MaCN = CTDT.MaCN"
                + " JOIN HocPhan ON CTDT.MaHP = HocPhan.MaHP JOIN LopHP ON HocPhan.MaHP = LopHP.MaHP WHERE LopHP.TTLHP = N'Đang mở' and SinhVien.MSV = @TenDN ;";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@TenDN", TenDN);
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            grdData.DataSource = dt;
            grdData.Refresh();

            
            NapCT();
        }
        private void Naplai()
        {
            sql = "SELECT LopHP.MaLHP, HocPhan.MaHP, HocPhan.TenHP, HocPhan.SoTinChi,"
               + " LopHP.ToiThieu, LopHP.ToiDa, LopHP.ThoiGian, LopHP.KyHoc,"
               + " LopHP.DiaDiem FROM SinhVien JOIN LopCN ON SinhVien.MaLopCN = LopCN.MaLopCN"
               + " JOIN ChuyenNganh ON LopCN.MaCN = ChuyenNganh.MaCN JOIN CTDT ON ChuyenNganh.MaCN = CTDT.MaCN"
               + " JOIN HocPhan ON CTDT.MaHP = HocPhan.MaHP JOIN LopHP ON HocPhan.MaHP = LopHP.MaHP WHERE LopHP.TTLHP =N'Đang mở' and SinhVien.MSV = @TenDN ;";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@TenDN", TenDN);
            da = new SqlDataAdapter(cmd);
            dt.Clear();
            da.Fill(dt);
            grdData.DataSource = dt;
            grdData.Refresh();            
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

        private void btnFillter_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(comTentruong.Text))
            {
                sql = "SELECT LopHP.MaLHP, HocPhan.MaHP, HocPhan.TenHP, HocPhan.SoTinChi,"
              + " LopHP.ToiThieu, LopHP.ToiDa, LopHP.ThoiGian, LopHP.KyHoc,"
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
                NapCT();
            }
            

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Naplai();
        }

        private void grdData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

        private void grdDataTraCuu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void NapCT()
        {
            if (grdData.CurrentRow != null)
            {
                int i = grdData.CurrentRow.Index;//lấy số thứ tự dòng hiện thời
                txtMaLHP.Text = grdData.Rows[i].Cells["MaLHP"].Value.ToString();
                txtMaHP.Text = grdData.Rows[i].Cells["MaHP"].Value.ToString();
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
