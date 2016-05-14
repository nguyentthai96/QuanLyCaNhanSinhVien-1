using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaoTaiKhoan_WFC
{
    public delegate void DangKy(UCDangKyTK sender, EventArgs e);
    public partial class UCDangKyTK: UserControl
    {
        public string StrTaiKhoan;
        public string StrMatKhau;
        public event DangKy TaoTaiKhoan;
        public UCDangKyTK()
        {
            InitializeComponent();
        }
        public UCDangKyTK(string StrTaiKhoan)
        {
            this.StrTaiKhoan = StrTaiKhoan;
            InitializeComponent();
            txtTaiKhoan.Text = StrTaiKhoan;
        }
        private void txtTaiKhoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                txtMatKhau.Focus();
            }
        }

        private void txtMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnTao.Focus();
            }
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            if (TaoTaiKhoan != null)
            {
                StrTaiKhoan = txtTaiKhoan.Text;
                StrMatKhau = txtMatKhau.Text;
                TaoTaiKhoan(this, e);
            }
        }
    }
}
