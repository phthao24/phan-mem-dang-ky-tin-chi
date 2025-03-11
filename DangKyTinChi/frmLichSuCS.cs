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
    public partial class frmLichSuLHP : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        string sql, constr;
        public frmLichSuLHP()
        {
            InitializeComponent();
        }

        private void btnQuayVe_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            grdData.CurrentCell = grdData[0, grdData.RowCount - 1];
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            grdData.CurrentCell = grdData[0, 0];
        }

        private void btnPrv_Click(object sender, EventArgs e)
        {
            int i = grdData.CurrentCell.RowIndex;
            if (i > 0)
            {
                grdData.CurrentCell = grdData[0, i - 1];
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int i = grdData.CurrentCell.RowIndex;
            if (i < grdData.RowCount - 1)
            {
                grdData.CurrentCell = grdData[0, i + 1];
            }
        }

        private void btnKhoiPhuc_Click(object sender, EventArgs e)
        {
            int i = grdData.CurrentCell.RowIndex;
            sql = "Update LopHP set TTLHP=N'Đang mở' where MaLHP='" + grdData.Rows[i].Cells["MaLHP"].Value + "' and TTLHP =N'Đã hủy'";
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            MessageBox.Show("Đã khôi phục thành công!");
            NapLai();
            
        }
        public void NapLai()
        {
            sql = "Select * From LopHP ";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            grdData.DataSource = dt;
            grdData.Refresh();
        }

        private void grdData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmLichSuCS_Load(object sender, EventArgs e)
        {
            constr = "Data Source=LAPTOP-MGOO2M8J;Initial Catalog=TinChiSQL;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            sql = "Select * From LopHP ";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            grdData.DataSource = dt;
            grdData.Refresh();
        }
    }
}
