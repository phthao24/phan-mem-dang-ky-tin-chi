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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace DangKyTinChi
{
    public partial class frmDMHP : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        string sql, constr;
        DataTable comdt = new DataTable();
        Boolean addNewFlag = false;
        public frmDMHP()
        {
            InitializeComponent();
        }

        private void frmDMHP_Load(object sender, EventArgs e)
        {
            constr = "Data Source=LAPTOP-MGOO2M8J;Initial Catalog=TinChiSQL;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            sql = "Select MaHP, TenHP, SoTinChi, MaMonTQ From HocPhan ";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
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
                txtMaHP.Text = grdData.Rows[i].Cells["MaHP"].Value.ToString();
                txtTenHP.Text = grdData.Rows[i].Cells["TenHP"].Value.ToString();
                txtSoTC.Text = grdData.Rows[i].Cells["SoTinChi"].Value.ToString();
                txtMaMonTQ.Text = grdData.Rows[i].Cells["MaMonTQ"].Value.ToString();
            }
           
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
                sql = "Select MaHP, TenHP, SoTinChi, MaMonTQ From HocPhan Where " + comTenTruong.Text + "=N'" + comGT.Text + "'";
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
            sql = "Select MaHP, TenHP, SoTinChi, MaMonTQ From HocPhan ";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            grdData.DataSource = dt;
            grdData.Refresh();
            NapCT();
        }

        private void comTenTruong_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql = "Select Distinct " + comTenTruong.Text + " From HocPhan order by " + comTenTruong.Text;
            da = new SqlDataAdapter(sql, conn);
            comdt.Clear();
            da.Fill(comdt);
            comGT.DataSource = comdt;
            comGT.DisplayMember = comTenTruong.Text;
            comGT.ValueMember = comTenTruong.Text;
        }

        private void grdDataDMHP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

        private void btnLichSu_Click(object sender, EventArgs e)
        {
            Form formLSHP = new frmLichSuHP();
            formLSHP.Show();
        }

        private void comCN_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql ="Select MaHP, TenHP, SoTinChi, MaMonTQ From HocPhan Where MaHP in (Select MaHP From CTDT Where MaCN in (Select MaCN From ChuyenNganh Where TenCN = N'" + comCN.Text + "'))";
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
            txtMaHP.Text = "";
            txtTenHP.Text = "";
            txtSoTC.Text = "";
            txtMaMonTQ.Text = "";
            txtMaHP.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (addNewFlag)
            {
                if (txtMaMonTQ.Text != "")
                {
                    //string maMonTQ = string.IsNullOrWhiteSpace(txtMaMonTQ.Text) ? "NULL" : $"N'{txtMaMonTQ.Text}'";
                    sql = " Insert Into HocPhan (MaHP, TenHP, SoTinChi, MaMonTQ)"
                      + " values (N'" + txtMaHP.Text + "',N'" + txtTenHP.Text + "',N'" + txtSoTC.Text + "',{"
                      + txtMaMonTQ + "})";
                    cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đã thêm mới thành công");
                    NapLai();
                    addNewFlag = false;
                }
                else
                {
                    sql = " Insert Into HocPhan (MaHP, TenHP, SoTinChi,MaMonTQ)"
                      + " values (N'" + txtMaHP.Text + "',N'" + txtTenHP.Text + "',N'" + txtSoTC.Text + "',NULL)";
                    cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đã thêm mới thành công");
                    NapLai();
                    addNewFlag = false;
                }

            }
            else
            {
                int n = grdData.RowCount;
                int i = 0;
                for (i = 0; i < n - 1; i++)
                {
                    sql = "Update HocPhan set TenHP=N'" + grdData.Rows[i].Cells["TenHP"].Value
                        + "',SoTinChi=N'" + grdData.Rows[i].Cells["SoTinChi"].Value
                        + "' where MaHP='" + grdData.Rows[i].Cells["MaHP"].Value + "'";
                    cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Đã cập nhật thành công!");
                NapLai();
            }
        }
        public void NapLai()
        {
            sql = "Select MaHP, TenHP, SoTinChi, MaMonTQ From HocPhan ";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            grdData.DataSource = dt;
            grdData.Refresh();
            NapCT();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hãy thực hiện sửa nội dung dữ liệu trên ô lưới. Kết thúc bằng việc bấm cập nhật");
            addNewFlag = false;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xoá bản ghi hiện thời?", "Xác nhận yêu cầu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "Delete from HocPhan where MaHP = '" + txtMaHP.Text + "'";
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                NapLai();
            }
        }

        private void btnQuayVe_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }
    }
}
