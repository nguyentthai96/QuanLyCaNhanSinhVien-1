using QuanLyCaNhanSinhVien_BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaoTaiKhoan_WFC;

namespace WFAQuanLyCaNhanSinhVien
{
    public partial class FDangKyTaiKhoan : Form
    {
        private string strMaSV;
        public FDangKyTaiKhoan(string strMaSV)
        {
            this.strMaSV = strMaSV;
            InitializeComponent();
            ucDangKyTK1.StrTaiKhoan = strMaSV;
        }
        private void ucDangKy_GhiDuLieu_TaoTaiKhoan(UCDangKyTK sender, EventArgs e)
        {
            if(new CAccountSinhVien_BLL().addAcountSinhVien(sender.StrTaiKhoan,sender.StrMatKhau))
            {
                MessageBox.Show("Đăng ký thành công bạn có thể đăng nhập bằng account này.");
                this.Close();
                return;
            }
            MessageBox.Show("Đăng ký thất bại.");
            return;
        }
    }
}
