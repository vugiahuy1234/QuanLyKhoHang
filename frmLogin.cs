using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhoHang
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtDangNhap.Text == "admin" && txtMatKhau.Text == "123456" || txtDangNhap.Text == "giahuy" && txtMatKhau.Text =="1234" || txtDangNhap.Text == "kytrung" && txtMatKhau.Text =="1234")
            {
                FrmMain frm = new FrmMain();
                this.Visible = false;
                frm.ShowDialog();
                
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
