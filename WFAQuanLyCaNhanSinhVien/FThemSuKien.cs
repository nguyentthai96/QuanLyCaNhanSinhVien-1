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
using QuanLyCaNhanSinhVien_DTO;

namespace WFAQuanLyCaNhanSinhVien
{
    public partial class FThemSuKien : Form
    {
        public FThemSuKien()
        {
            InitializeComponent();
        }

        private void FThemSuKien_Load(object sender, EventArgs e)
        {
            cmbMonHoc.DataSource = new CMonHoc_BLL().loadDSMon();
            cmbMonHoc.ValueMember = "MaMon";
            cmbMonHoc.DisplayMember = "TenMon";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int iCountHD = new CHoatDong_BLL().countHoatDong();
            CHoatDong_DTO hoatDong = new CHoatDong_DTO("HD" + iCountHD, cmbMonHoc.SelectedValue.ToString(), false,1,
                    DateTime.Parse(dtmpNgayBatDau.Value.ToShortDateString() +" "+ dtmpThoiGianBatDau.Value.ToShortTimeString()),
                    DateTime.Parse( dtmpNgayDen.Value.ToShortDateString() +" "+ dtmpThoiGianDen.Value.ToShortTimeString()), txtMoTa.Text);
            if (hoatDong.DtmGioBD>hoatDong.DtmGioKT)
            {
                MessageBox.Show("Thời gian bạn nhập không hợp lý.");
                return;
            }
            if (new CHoatDong_BLL().themHoatDong(hoatDong))
            {
                MessageBox.Show("Thêm thành công.");
                this.Close();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
