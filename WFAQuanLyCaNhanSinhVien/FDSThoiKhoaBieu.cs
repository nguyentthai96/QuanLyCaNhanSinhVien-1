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
    public partial class FDSThoiKhoaBieu : Form
    {
        private string strMaSV;
        private DataSet dsLichHoc;
        int iThuSelect=0;
        //Quan ly index cua databinding
        string[] strThu = new string[] { "Chủ nhật", "Thứ hai", "Thứ ba", "Thứ tư", "Thứ năm", "Thứ sáu", "Thứ bảy" };
        public FDSThoiKhoaBieu(string strMaSV)
        {
            this.strMaSV = strMaSV;
            InitializeComponent();
            this.dsLichHoc = new DataSet();
            iThuSelect = 0;
        }

        private void FDSThoiKhoaBieu_Load(object sender, EventArgs e)
        {
            //Đổi tên Form
            this.Text = "Thời khóa biểu " + strThu[iThuSelect].ToString();
            btnPrevThu.Enabled = false;
            dsLichHoc = CHoatDong_BLL.loadDSLichHocTuan(strMaSV);
            loadDataGrid();
        }

        private void btnNextThu_Click(object sender, EventArgs e)
        {
            //Đổi tên Form
            this.Text = "Thời khóa biểu " + strThu[iThuSelect].ToString();
            iThuSelect += 1;
            if (iThuSelect == dsLichHoc.Tables.Count-1)
            {
                btnNextThu.Enabled = false;
            }
            btnPrevThu.Enabled = true;
            loadDataGrid();
        }

        private void btnPrevThu_Click(object sender, EventArgs e)
        {
            //Đổi tên Form
            this.Text = "Thời khóa biểu " + strThu[iThuSelect].ToString();
            iThuSelect  -= 1;
            if (iThuSelect == 0)
            {
                btnPrevThu.Enabled = false;
            }
            btnNextThu.Enabled = true;
            loadDataGrid();
        }

        private void loadDataGrid()
        {
            dgvThu.DataSource = dsLichHoc.Tables[iThuSelect];
            dgvThu.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
        }
    }
}
