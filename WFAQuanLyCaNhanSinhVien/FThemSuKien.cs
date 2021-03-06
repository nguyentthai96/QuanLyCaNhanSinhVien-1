﻿using System;
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
    public partial class FThemSuKien : Form
    {
        private string strMaSV;
        public FThemSuKien()
        {
            InitializeComponent();
        }
        public FThemSuKien(string strMaSV)
        {
            this.strMaSV = strMaSV;
            InitializeComponent();
        }

        private void FThemSuKien_Load(object sender, EventArgs e)
        {
            cmbMonHoc.DataSource = CMonHoc_BLL.loadDSMon();
            cmbMonHoc.ValueMember = "MaMon";
            cmbMonHoc.DisplayMember = "TenMon";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int iCountHD = CHoatDong_BLL.countHoatDong();
               DateTime DtmGioBD = DateTime.Parse(dtmpNgayBatDau.Value.ToShortDateString() + " " + dtmpThoiGianBatDau.Value.ToShortTimeString());
            DateTime DtmGioKT = DateTime.Parse(dtmpNgayDen.Value.ToShortDateString() + " " + dtmpThoiGianDen.Value.ToShortTimeString());
         
            if (DtmGioBD> DtmGioKT)
            {
                MessageBox.Show("Thời gian bạn nhập không hợp lý.");
                return;
            }
            if (CHoatDong_BLL.themHoatDong(strMaSV, "HD" + iCountHD, cmbMonHoc.SelectedValue.ToString(), false, DtmGioBD, DtmGioKT, txtMoTa.Text))
            {
                MessageBox.Show("Thêm thành công.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm thất bại.");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
