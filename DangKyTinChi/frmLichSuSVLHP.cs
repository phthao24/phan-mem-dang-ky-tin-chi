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
    public partial class frmLichSuSVLHP : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        string sql, constr;
        public frmLichSuSVLHP()
        {
            InitializeComponent();
        }

        private void btnQuayVe_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            grdDataLSSVLHP.CurrentCell = grdDataLSSVLHP[0, 0];
        }

        private void btnPrv_Click(object sender, EventArgs e)
        {
            int i = grdDataLSSVLHP.CurrentCell.RowIndex;
            if (i > 0)
            {
                grdDataLSSVLHP.CurrentCell = grdDataLSSVLHP[0, i - 1];
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int i = grdDataLSSVLHP.CurrentCell.RowIndex;
            if (i < grdDataLSSVLHP.RowCount - 1)
            {
                grdDataLSSVLHP.CurrentCell = grdDataLSSVLHP[0, i + 1];
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            grdDataLSSVLHP.CurrentCell = grdDataLSSVLHP[0, grdDataLSSVLHP.RowCount - 1];
        }

        private void grdDataLSSVLHP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmLichSuSVLHP_Load(object sender, EventArgs e)
        {
            constr = "Data Source=LAPTOP-MGOO2M8J;Initial Catalog=TinChiSQL;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            sql = "Select * From TinChi ";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            grdDataLSSVLHP.DataSource = dt;
            grdDataLSSVLHP.Refresh();
        }
    }
}
