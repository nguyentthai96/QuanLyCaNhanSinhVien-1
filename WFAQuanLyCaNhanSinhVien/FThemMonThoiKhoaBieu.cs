using QuanLyCaNhanSinhVien_BLL;
using QuanLyCaNhanSinhVien_DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAQuanLyCaNhanSinhVien
{
    public partial class FThemMonThoiKhoaBieu : Form
    {
        private string strMaSV;
        public FThemMonThoiKhoaBieu()
        {
            InitializeComponent();
        }
        public FThemMonThoiKhoaBieu(string strMaSV)
        {
            InitializeComponent();
            this.strMaSV = strMaSV;
        }

        private void lblMauLich_Click(object sender, EventArgs e)
        {
            cold.ShowDialog();
            (sender as Label).BackColor = cold.Color;
        }

        private void numbTiet_ValueChanged(object sender, EventArgs e)
        {
            //TODO Trả ra h của tiết đó cho hai cái dtm
        }

        private void FThemMonThoiKhoaBieu_Load(object sender, EventArgs e)
        {
            loadCmbMonHoc();
        }
        private bool loadCmbMonHoc()
        {
            cmbMonHoc.DataSource = new CMonHoc_BLL().loadDSMon();
            cmbMonHoc.ValueMember = "MaMon";
            cmbMonHoc.DisplayMember = "TenMon";
            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            CHoatDong_DTO hd = layDuLieuTuFrom();
            int iThu = (int)numbThu.Value;
            if(new CHoatDong_BLL().themLichHoc(hd,iThu, strMaSV)==false)
            {
                MessageBox.Show("Thêm lỗi");
                return;
            }
            this.Close();
            return;
        }
        private CHoatDong_DTO layDuLieuTuFrom()
        {
            CHoatDong_DTO hd;
            int iCoutHD = new CHoatDong_BLL().countHoatDong();
            hd = new CHoatDong_DTO("HD"+iCoutHD, cmbMonHoc.SelectedValue.ToString(), true, (int)numbTiet.Value, dtmpTu.Value, dtmpDen.Value, txtMoTa.Text,lblMauLich.BackColor.ToArgb());
            return hd;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
