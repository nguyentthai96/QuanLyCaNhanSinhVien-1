using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyCaNhanSinhVien_BLL;

namespace WFAQuanLyCaNhanSinhVien
{
    public partial class FThemSinhVien : Form
    {
        private string strMaSV;
        public FThemSinhVien()
        {
            InitializeComponent();
            button1.Enabled = false;
        }
        public FThemSinhVien(string strMaSV)
        {
            InitializeComponent();
            this.strMaSV = strMaSV;
            txtMaSinhVien.Enabled = false;
            btnThem.Enabled = false;

            txtMaSinhVien.Text = strMaSV;
            DataTable tb = new DataTable();
            tb = CSinhVien_BLL.loadSinhVienInfor(strMaSV);
            txtHoTen.Text = tb.Rows[0]["HoTen"].ToString();
            txtDiaChi.Text = tb.Rows[0]["DiaChi"].ToString();
            txtThongTinKhac.Text = tb.Rows[0]["CacThongTinKhac"].ToString();
            dtmpNgaySinh.Value = DateTime.Parse(tb.Rows[0]["NgaySinh"].ToString());
            if (tb.Rows[0]["GioiTinh"].ToString()=="True")
            {
                rdoNam.Checked = true;
                rdoNu.Checked = false;
            }
            else
            {
                rdoNam.Checked = false;
                rdoNu.Checked = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            this.strMaSV = txtMaSinhVien.Text;
            if (CSinhVien_BLL.themSinhVien(strMaSV, txtHoTen.Text, rdoNam.Checked, dtmpNgaySinh.Value.Date, txtDiaChi.Text, txtThongTinKhac.Text))
            {
                #region Tạo account để sử dụng
                FDangKyTaiKhoan frmDangKyTaiKhoan = new FDangKyTaiKhoan(strMaSV);
                frmDangKyTaiKhoan.StartPosition = FormStartPosition.CenterParent;
                frmDangKyTaiKhoan.ShowDialog();
                
                #endregion
                
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm Thất bại.");
            }
        }

        private void FThemSinhVien_Load(object sender, EventArgs e)
        {
        
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (CSinhVien_BLL.suaSinhVien(strMaSV, txtHoTen.Text, rdoNam.Checked, dtmpNgaySinh.Value.Date, txtDiaChi.Text, txtThongTinKhac.Text))
            {
                MessageBox.Show("Sửa Thành công.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Sửa Thất bại.");
            }
        }
    }
}
