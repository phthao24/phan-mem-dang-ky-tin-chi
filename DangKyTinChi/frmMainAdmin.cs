using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DangKyTinChi
{
    public partial class frmMainAdmin : Form
    {
        public frmMainAdmin()
        {
            InitializeComponent();
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            Form frm = new frmMainAdmin();
            frm.ShowDialog();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            Form a = new frmDangNhap();
            a.Show();
        }

        private void btnDMLHP_Click(object sender, EventArgs e)
        {
            Form formDMLHP =new frmDMLHP();
            formDMLHP.Show();
        }

        private void btnDMHP_Click(object sender, EventArgs e)
        {
            Form formDMHP = new frmDMHP();
            formDMHP.Show();
        }

        private void btnSVLHP_Click(object sender, EventArgs e)
        {
            Form formDMSVLHP = new frmDMSVLHP();
            formDMSVLHP.Show();
        }

        private void frmMainAdmin_Load(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBCLHP_Click(object sender, EventArgs e)
        {
            Form frmQuanlyLHP = new frmQuanlyLHP();
            frmQuanlyLHP.Show();
        }

        private void btnBCLHPHuy_Click(object sender, EventArgs e)
        {
            Form a = new frmRptLHPHuy();
            a.Show();
        }

        private void btnBCSVLHP_Click(object sender, EventArgs e)
        {
            Form a = new frmSVLHP();
            a.Show();
        }
    }
}
