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
    public partial class frmDangNhap : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        string sql, constr;


        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            constr = "Data Source=LAPTOP-MGOO2M8J;Initial Catalog=TinChiSQL;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            sql = "Select * From Login where TenDN = '" + txtUserName.Text + "' and MatKhau= '" + txtPassWord.Text + "'";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                string quyen = dt.Rows[0]["Quyen"].ToString();

                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();

                // Mở form tương ứng dựa trên quyền
                if (quyen == "user")
                {
                    Form formUser = new frmMainSV(txtUserName.Text);
                    formUser.ShowDialog();
                }
                else if (quyen == "admin")
                {
                    Form formAdmin = new frmMainAdmin();
                    formAdmin.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng đăng nhập lại");
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
