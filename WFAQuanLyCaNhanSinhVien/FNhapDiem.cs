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

        List<CMonHoc_DTO> monHocs;
        private void loadComboBox()
        {
            monHocs = new List<CMonHoc_DTO>();
            monHocs = new CMonHoc_BLL().loadDSMonSV(strMaSV);

            cmbMonHoc.DataSource = monHocs;
            cmbMonHoc.DisplayMember = "StrTenMon";
            cmbMonHoc.ValueMember = "StrMaMon";
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
            int iCountDiem = new CDiemSo_BLL().countDiem(strMaSV);
            CDiemSo_DTO diem;
            try
            {
                diem = new CDiemSo_DTO(cmbMonHoc.SelectedValue.ToString(), strMaSV,strMaHK, "Diem" + iCountDiem, float.Parse(txtSoDiem.Text), float.Parse(txtSoDiem.Text), dtmpNgayDiem.Value.Date);
                if (new CDiemSo_BLL().themDiem(diem) == false)
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
