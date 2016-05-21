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
    public partial class FSuaDiem : Form
    {
        private string strMaSV;
        private string strMaDiem;
        private string strMaMon;
        private string strMaHK;

        private string v1;
        private string v2;
        private string v3;
        private string v4;
        private float value1;
        private float value2;
        private DateTime dateTime;

        public FSuaDiem(string strMaSV,string strMaMon, string strMaHK, string strMaDiem, DateTime DtmNgayDiem, float FHeSo, float sodiem)
        {
            this.strMaSV = strMaSV;
            this.strMaDiem = strMaDiem;
            this.strMaMon = strMaMon;
            this.strMaHK = strMaHK;
            InitializeComponent();

            cmbMonHoc.DataSource=CMonHoc_BLL.loadDSMonHKDiem(this.strMaSV);
            cmbMonHoc.ValueMember = "Item1";
            cmbMonHoc.DisplayMember = "Item2";
            cmbMonHoc.SelectedValue = strMaMon;
            dtmpNgayDiem.Value = DtmNgayDiem;
            txtHeSo.Text = FHeSo.ToString();
            txtSoDiem.Text = sodiem.ToString();
        }

        public FSuaDiem(string v1, string v2, string v3, string v4, float value1, float value2, DateTime dateTime)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
            this.value1 = value1;
            this.value2 = value2;
            this.dateTime = dateTime;
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
                if (CDiemSo_BLL.suaDiem(cmbMonHoc.SelectedValue.ToString(), strMaSV, strMaHK, strMaDiem, float.Parse(txtSoDiem.Text), float.Parse(txtHeSo.Text), dtmpNgayDiem.Value) == false)
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
