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
            this.strMaSV = strMaSV;
            InitializeComponent();
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
            cmbMonHoc.DataSource = CMonHoc_BLL.loadDSMon();
            cmbMonHoc.ValueMember = "MaMon";
            cmbMonHoc.DisplayMember = "TenMon";
            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            #region LayDuLieuTuForm
            int iCoutHD = CHoatDong_BLL.countHoatDong();
            #endregion
            int iThu = (int)numbThu.Value;
            if(CHoatDong_BLL.themLichHoc(strMaSV, iThu, "HD" + iCoutHD, cmbMonHoc.SelectedValue.ToString(), true, dtmpTu.Value, dtmpDen.Value, txtMoTa.Text, lblMauLich.BackColor.ToArgb()) ==false)
            {
                MessageBox.Show("Thêm lỗi");
                return;
            }
            this.Close();
            return;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
