using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyCaNhanSinhVien_DTO;
using QuanLyCaNhanSinhVien_BLL;

namespace WFAQuanLyCaNhanSinhVien
{
    public partial class FThemSinhVien : Form
    {
        public FThemSinhVien()
        {
            InitializeComponent();
        }
        CSinhVien_DTO sv;
        public FThemSinhVien(CSinhVien_DTO sv)
        {
            InitializeComponent();
            this.sv = sv;
            txtMaSinhVien.Enabled = false;
            btnThem.Enabled = false;

            txtMaSinhVien.Text = sv.StrMaSV;
            txtHoTen.Text = sv.StrHoTen;
            txtDiaChi.Text = sv.StrDiaChi;
            txtThongTinKhac.Text = sv.StrCacThongTin;
            dtmpNgaySinh.Value = sv.DtmNgaySinh;
            if (sv.BGioiTinh)
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
            CSinhVien_DTO sv = new CSinhVien_DTO(txtMaSinhVien.Text, txtHoTen.Text,rdoNam.Checked,dtmpNgaySinh.Value.Date,txtDiaChi.Text,txtThongTinKhac.Text);
            if (new CSinhVien_BLL().themSinhVien(sv))
            {
                MessageBox.Show("Thêm Thành công.");
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
            sv = new CSinhVien_DTO(txtMaSinhVien.Text, txtHoTen.Text, rdoNam.Checked, dtmpNgaySinh.Value.Date, txtDiaChi.Text, txtThongTinKhac.Text);
            if (new CSinhVien_BLL().suaSinhVien(sv))
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
