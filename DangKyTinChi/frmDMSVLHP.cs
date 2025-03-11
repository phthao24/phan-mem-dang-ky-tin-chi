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
    public partial class frmDMSVLHP : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        string sql, constr;
        DataTable comdt = new DataTable();
        Boolean addNewFlag = false;
        public frmDMSVLHP()
        {
            InitializeComponent();
        }

        private void btnQuayVe_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        private void frmDMSVLHP_Load(object sender, EventArgs e)
        {
            constr = "Data Source=LAPTOP-MGOO2M8J;Initial Catalog=TinChiSQL;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            sql = "Select vw_KetQuaDK.MaDK, vw_KetQuaDK.MSV, SinhVien.TenSV,vw_KetQuaDK.MaLHP, vw_KetQuaDK.ThoiGianDK, vw_KetQuaDK.TTDK, vw_KetQuaDK.TTLHP"
                + " From vw_KetQuaDK INNER JOIN SinhVien ON vw_KetQuaDK.MSV = SinhVien.MSV";
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
                sql = "Select vw_KetQuaDK.MaDK, vw_KetQuaDK.MSV, SinhVien.TenSV,vw_KetQuaDK.MaLHP, vw_KetQuaDK.ThoiGianDK, vw_KetQuaDK.TTDK, vw_KetQuaDK.TTLHP From vw_KetQuaDK INNER JOIN SinhVien ON vw_KetQuaDK.MSV = SinhVien.MSV Where vw_KetQuaDK."
                    + comTenTruong.Text + "=N'" + comGT.Text + "'";
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
            sql = "Select vw_KetQuaDK.MaDK, vw_KetQuaDK.MSV, SinhVien.TenSV,vw_KetQuaDK.MaLHP, vw_KetQuaDK.ThoiGianDK, vw_KetQuaDK.TTDK, vw_KetQuaDK.TTLHP"
                + " From vw_KetQuaDK INNER JOIN SinhVien ON vw_KetQuaDK.MSV = SinhVien.MSV";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            grdData.DataSource = dt;
            grdData.Refresh();
            NapCT();
        }

        private void comTenTruong_SelectedIndexChanged(object sender, EventArgs e)
        {
                sql = "Select Distinct " + comTenTruong.Text + " From vw_KetQuaDK order by " + comTenTruong.Text;
                da = new SqlDataAdapter(sql, conn);
                comdt.Clear();
                da.Fill(comdt);
                comGT.DataSource = comdt;
                comGT.DisplayMember = comTenTruong.Text;
                comGT.ValueMember = comTenTruong.Text;
            
        }

        private void grdDataDMSVLHP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

        private void btnLichSu_Click(object sender, EventArgs e)
        {
            Form formLichSuCS = new frmLichSuSVLHP();
            formLichSuCS.Show();
        }

        private void comLHP_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //addNewFlag = true;
            //txtMSV.Text = "";
            //txtTenSV.Visible = false;
            //txtMaLHP.Text = "";
            //txtMaLHP.Focus();
        }
        public void NapLai()
        {
            sql = "Select vw_KetQuaDK.MaDK, vw_KetQuaDK.MSV, SinhVien.TenSV,vw_KetQuaDK.MaLHP, vw_KetQuaDK.ThoiGianDK, vw_KetQuaDK.TTDK, vw_KetQuaDK.TTLHP"               
                + " From vw_KetQuaDK INNER JOIN SinhVien ON vw_KetQuaDK.MSV = SinhVien.MSV";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            grdData.DataSource = dt;
            grdData.Refresh();
            NapCT();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //if (addNewFlag)
            //{
            //    sql = " Insert Into TinChi (MaDK, MaLHP, MSV, TTDK)"
            //          + "values ((SELECT ISNULL(MAX(MaDK), 0) + 1 FROM TinChi),N'" + txtMaLHP.Text + "',N'" + txtMSV.Text + "',N'Đăng ký')";
            //    cmd = new SqlCommand(sql, conn);
            //    cmd.ExecuteNonQuery();
            //    MessageBox.Show("Đã thêm mới thành công");
            //    NapLai();
            //    addNewFlag = false;
            //}
            //else
            //{
            //    int n = grdData.RowCount;
            //    int i = 0;
            //    for (i = 0; i < n - 1; i++)
            //    {
            //        sql = "Update MaLHP set MaLHP=N'" + grdData.Rows[i].Cells["MaLHP"].Value
            //            + "',MSV=N'" + grdData.Rows[i].Cells["MSV"].Value
            //            + "' where MaDK='" + grdData.Rows[i].Cells["MaDK"].Value + "'";
            //        cmd = new SqlCommand(sql, conn);
            //        cmd.ExecuteNonQuery();
            //    }
            //    MessageBox.Show("Đã cập nhật thành công!");
            //    NapLai();
            //}
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hãy thực hiện sửa nội dung dữ liệu trên ô lưới. Kết thúc bằng việc bấm cập nhật");
            //addNewFlag = false;
        }

        public void NapCT()
        {
            int i = grdData.CurrentRow.Index;//lấy số thứ tự dòng hiện thời
            txtMSV.Text = grdData.Rows[i].Cells["MSV"].Value.ToString();
            txtTenSV.Text = grdData.Rows[i].Cells["TenSV"].Value.ToString();
            txtMaLHP.Text = grdData.Rows[i].Cells["MaLHP"].Value.ToString();
        }
    }
}
