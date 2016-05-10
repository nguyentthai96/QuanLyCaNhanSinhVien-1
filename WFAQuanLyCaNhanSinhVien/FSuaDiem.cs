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
    public partial class FSuaDiem : Form
    {
        private CDiemSo_DTO diem;

        public FSuaDiem(CDiemSo_DTO diem)
        {
            InitializeComponent();
            this.diem = diem;

            cmbMonHoc.DataSource=new CMonHoc_BLL().loadDSMonHKDiem(diem.StrMaSV);
            cmbMonHoc.ValueMember = "Item1";
            cmbMonHoc.DisplayMember = "Item2";
            cmbMonHoc.SelectedValue = diem.StrMaMon;
            dtmpNgayDiem.Value = diem.DtmNgayDiem;
            txtHeSo.Text = diem.FHeSo.ToString();
            txtSoDiem.Text = diem.FSoDiem.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (suaDiem())
            {
                MessageBox.Show("Sửa điểm thành công.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Sửa điểm thất bại.");
            }
        }

        private bool suaDiem()
        {
            try
            {
                diem = new CDiemSo_DTO(cmbMonHoc.SelectedValue.ToString(),diem.StrMaSV,diem.StrMaHK,diem.StrMaDiem,float.Parse(txtSoDiem.Text), float.Parse(txtHeSo.Text), dtmpNgayDiem.Value);
                if (new CDiemSo_BLL().suaDiem(diem) == false)
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
