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
    public partial class FNhapDiem : Form
    {
        private string strMaSV;
        private string strMaMon;
        private string  strMaHK;
        public FNhapDiem(string strMaSV)
        {
            InitializeComponent();
            this.strMaSV = strMaSV;
        }

        public FNhapDiem(string strMaSV, string strMaMon, string strMaHK)
        {
            InitializeComponent();
            this.strMaSV = strMaSV;
            this.strMaMon = strMaMon;
            loadComboBox();
            cmbMonHoc.SelectedValue = strMaMon;
            this.strMaHK = strMaHK;
        }

        DataTable monHocs;
        private void loadComboBox()
        {
            monHocs = new CMonHoc_BLL().loadDSMonSV(strMaSV);

            cmbMonHoc.DataSource = monHocs;
            cmbMonHoc.DisplayMember = "TenMon";
            cmbMonHoc.ValueMember = "MaMon";
        }
       
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (themDiem(strMaHK))
            {
                MessageBox.Show("Thêm điểm thành công.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm điểm thất bại.");
            }
        }

        private bool themDiem(string strMaHK)
        {
            int iCountDiem = CDiemSo_BLL.countDiem(strMaSV);
           
            try
            {
                if (CDiemSo_BLL.themDiem(cmbMonHoc.SelectedValue.ToString(), strMaSV, strMaHK, "Diem" + iCountDiem, float.Parse(txtSoDiem.Text), float.Parse(txtHeSo.Text), dtmpNgayDiem.Value.Date) == false)
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
