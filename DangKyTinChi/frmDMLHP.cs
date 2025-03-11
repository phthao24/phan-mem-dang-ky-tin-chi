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
    public partial class frmDMLHP : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        string sql, constr;
        DataTable comdt = new DataTable();
        Boolean addNewFlag = false;
        public frmDMLHP()
        {
            InitializeComponent();
        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void NapCT()
        {
            int i = grdData.CurrentRow.Index;//lấy số thứ tự dòng hiện thời
            txtMaLHP.Text = grdData.Rows[i].Cells["MaLHP"].Value.ToString();
            txtMaHP.Text = grdData.Rows[i].Cells["MaHP"].Value.ToString();
            txtSySo.Text = grdData.Rows[i].Cells["SySo"].Value.ToString();
            txtThoiGian.Text = grdData.Rows[i].Cells["ThoiGian"].Value.ToString();
            txtDiaDiem.Text = grdData.Rows[i].Cells["DiaDiem"].Value.ToString();
            txtGiangVien.Text = grdData.Rows[i].Cells["MaGV"].Value.ToString();
        }

        private void frmDMLHP_Load(object sender, EventArgs e)
        {
            constr = "Data Source=LAPTOP-MGOO2M8J;Initial Catalog=TinChiSQL;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            
                sql = "Select LopHP.MaLHP, LopHP.MaHP,HocPhan.TenHP, LopHP.SySo, LopHP.ToiThieu, LopHP.ToiDa, LopHP.ThoiGian, LopHP.KyHoc, LopHP.DiaDiem, LopHP.MaGV,"
                + "LopHP.TTLHP From LopHP INNER JOIN HocPhan ON LopHP.MaHP= HocPhan.MaHP ";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            grdData.DataSource = dt;
            grdData.Refresh();
            NapCT();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            grdData.CurrentCell = grdData[0, 0];
            NapCT();
        }

        private void btnPrv_Click(object sender, EventArgs e)
        {
            int i = grdData.CurrentCell.RowIndex;
            if (i > 0)
            {
                grdData.CurrentCell = grdData[0, i - 1];
            }
            NapCT();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int i = grdData.CurrentCell.RowIndex;
            if (i < grdData.RowCount - 1)
            {
                grdData.CurrentCell = grdData[0, i + 1];
            }
            NapCT();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            grdData.CurrentCell = grdData[0, grdData.RowCount - 1];
            NapCT();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(comTenTruong.Text))
            {
                sql = "Select LopHP.MaLHP, LopHP.MaHP,HocPhan.TenHP, LopHP.SySo, LopHP.ToiThieu, LopHP.ToiDa, LopHP.ThoiGian, LopHP.KyHoc, LopHP.DiaDiem, LopHP.MaGV,"
                + " LopHP.TTLHP From LopHP INNER JOIN HocPhan ON LopHP.MaHP= HocPhan.MaHP Where HocPhan. " + comTenTruong.Text + " = N'" + comGT.Text + "'";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt);
                grdData.DataSource = dt;
                grdData.Refresh();
                NapCT();
            }
            
          
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            sql = "Select LopHP.MaLHP, LopHP.MaHP,HocPhan.TenHP, LopHP.SySo, LopHP.ToiThieu, LopHP.ToiDa, LopHP.ThoiGian, LopHP.KyHoc, LopHP.DiaDiem, LopHP.MaGV," 
                + " LopHP.TTLHP From LopHP INNER JOIN HocPhan ON LopHP.MaHP= HocPhan.MaHP ";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            grdData.DataSource = dt;
            grdData.Refresh();
            NapCT();
        }

        private void comTenTruong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comTenTruong.Text == "TenHP")
            {
                sql = "Select Distinct HocPhan.TenHP From LopHP INNER JOIN HocPhan ON LopHP.MaHP = HocPhan.MaHP order by TenHP";
                da = new SqlDataAdapter(sql, conn);
                comdt.Clear();
                da.Fill(comdt);
                comGT.DataSource = comdt;
                comGT.DisplayMember = comTenTruong.Text;
                comGT.ValueMember = comTenTruong.Text;
            }
            else
            {
                sql = "Select Distinct " + comTenTruong.Text + " From LopHP order by " + comTenTruong.Text;
                da = new SqlDataAdapter(sql, conn);
                comdt.Clear();
                da.Fill(comdt);
                comGT.DataSource = comdt;
                comGT.DisplayMember = comTenTruong.Text;
                comGT.ValueMember = comTenTruong.Text;
            }
                
            
        }

        private void grdDataDMLHP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }
        public void NapLai()
        {
            sql = "Select LopHP.MaLHP, LopHP.MaHP,HocPhan.TenHP, LopHP.SySo, LopHP.ToiThieu, LopHP.ToiDa, LopHP.ThoiGian, LopHP.KyHoc, LopHP.DiaDiem, LopHP.MaGV,"
                + " LopHP.TTLHP From LopHP INNER JOIN HocPhan ON LopHP.MaHP= HocPhan.MaHP ";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            grdData.DataSource = dt;
            grdData.Refresh();
            NapCT();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addNewFlag = true;
            txtThoiGian.Visible = false;
            comThoiGian.Visible = true;
            txtMaLHP.Text = "";
            txtMaHP.Text = "";
            txtSySo.Text = "0";
            txtDiaDiem.Text = "";
            txtGiangVien.Text = "";
            txtMaLHP.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (addNewFlag)
            {
                sql = " Insert Into LopHP (MaLHP, MaHP, SySo, ToiThieu, ToiDa, ThoiGian, KyHoc, DiaDiem, MaGV, TTLHP)"
                      + "values (N'" + txtMaLHP.Text + "',N'" + txtMaHP.Text + "',N'" + txtSySo.Text + "',10,25,N'" 
                      + comThoiGian.Text + "','2023-2024-2',N'" + txtDiaDiem.Text + "',N'" + txtGiangVien.Text
                      + "',N'Đang mở')";
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã thêm mới thành công");
                NapLai();
                comThoiGian.Visible = false;
                txtThoiGian.Visible = true;
                addNewFlag = false;
            }
            else
            {
                int n = grdData.RowCount;
                int i = 0;
                for (i = 0; i < n - 1; i++)
                {
                    sql = "Update LopHP set MaHP=N'" + grdData.Rows[i].Cells["MaHP"].Value
                        + "',ThoiGian=N'" + grdData.Rows[i].Cells["ThoiGian"].Value
                        + "',DiaDiem=N'" + grdData.Rows[i].Cells["DiaDiem"].Value
                        + "' where MaLHP='" + grdData.Rows[i].Cells["MaLHP"].Value + "'";
                    cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Đã cập nhật thành công!");
                NapLai();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hãy thực hiện sửa nội dung dữ liệu trên ô lưới. Kết thúc bằng việc bấm cập nhật");
            addNewFlag = false;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn hủy lớp học phần hiện thời?", "Xác nhận yêu cầu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "Update LopHP set TTLHP=N'Đã hủy' where MaLHP='" + txtMaLHP.Text + "'";
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                NapLai();
            }
        }

        private void comKyHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql = "Select LopHP.MaLHP, LopHP.MaHP,HocPhan.TenHP, LopHP.SySo, LopHP.ToiThieu, LopHP.ToiDa, LopHP.ThoiGian, LopHP.KyHoc, LopHP.DiaDiem, LopHP.MaGV,"      
                + " LopHP.TTLHP From LopHP INNER JOIN HocPhan ON LopHP.MaHP= HocPhan.MaHP where KyHoc='" + comKyHoc.Text +"'";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            grdData.DataSource = dt;
            grdData.Refresh();

        }

        private void btnLichSu_Click(object sender, EventArgs e)
        {
            Form formLichSuCS = new frmLichSuLHP();
            formLichSuCS.Show();
        }

        private void btnLHPFinal_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn chốt các lớp học phần hiện thời?", "Xác nhận yêu cầu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                    sql = "Update LopHP set TTLHP=N'Đã hủy' where SySo < ToiThieu and TTLHP =N'Đang mở'";
                    cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                    sql = "Update LopHP set TTLHP=N'Đã chốt' where SySo >= ToiThieu and TTLHP=N'Đang mở'";
                    cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                MessageBox.Show("Đã cập nhật thành công!");
                NapLai();
            }
               
        }

        private void btnQuayVe_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }
    }
}
