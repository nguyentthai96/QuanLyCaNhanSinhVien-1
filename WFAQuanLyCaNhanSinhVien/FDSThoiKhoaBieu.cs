using QuanLyCaNhanSinhVien_BLL;
using QuanLyCaNhanSinhVien_DAL;
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
    public partial class FDSThoiKhoaBieu : Form
    {
        private string strMaSV;
        CHoatDong_DTO lichSelect;
        int iThuSelect;
        public FDSThoiKhoaBieu()
        {
            InitializeComponent();
        }

        public FDSThoiKhoaBieu(string strMaSV)
        {
            this.strMaSV = strMaSV;
            InitializeComponent();
        }

        private void FDSThoiKhoaBieu_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 8; i++)
            {
                loadLichHocThu(i);
            }
        }
        private bool loadLichHocThu(int iThu)
        {
            List<CHoatDong_DTO> list;
            list=new CHoatDong_BLL().loadLichHocThu(strMaSV,iThu);
            if (list==null)
            {
                return false;
            }
            string[] thuTuan = new string[] { "Chủ nhật", "Thứ 2", "Thứ 3", "Thứ 4", "Thứ 5", "Thứ 6", "Thứ 7" };
            TabPage tabPage = new TabPage(thuTuan[iThu-1]);
            DataGridView dtgv = new DataGridView();
            tabControl.TabPages.Add(tabPage);
            tabControl.Size = this.Size;
            dtgv.Size = tabControl.Size;
            tabPage.Controls.Add(dtgv);
            dtgv.DataSource = list;
            columDesignDtgv(ref dtgv);
            dtgv.ContextMenuStrip = cmsThoiKhoaBieu;
            dtgv.ReadOnly = true;
            dtgv.CellMouseDown += new DataGridViewCellMouseEventHandler(dtgv_CellMouseDown);
            dtgv.CellEndEdit += new DataGridViewCellEventHandler(dtgv_CellEndEdit);
            return true;
        }

        private void dtgv_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridView dtgv = (sender as DataGridView);
                dtgv.ClearSelection();
                dtgv.Rows[e.RowIndex].Selected = true;
                dtgv.Refresh();
                lichSelect = new CHoatDong_DTO(dtgv["StrMaHD", e.RowIndex].Value.ToString(), dtgv["StrMaMon", e.RowIndex].Value.ToString(), true, DateTime.Parse(dtgv["DtmGioBD", e.RowIndex].Value.ToString()), DateTime.Parse(dtgv["DtmGioKT", e.RowIndex].Value.ToString()), dtgv["StrGhiChuHD", e.RowIndex].Value.ToString());
                List<string> thuTuan = new List<string> { "Chủ nhật", "Thứ 2", "Thứ 3", "Thứ 4", "Thứ 5", "Thứ 6", "Thứ 7" };
                 iThuSelect = thuTuan.IndexOf(tabControl.SelectedTab.Text) + 1;
            }
            catch (Exception) { }
        }

        private void columDesignDtgv(ref DataGridView dtgv)
        {
            dtgv.Columns["StrMaHD"].Visible = false;
            dtgv.Columns["StrMaMon"].Visible = false;
            dtgv.Columns["BChinhKhoa"].Visible = false;
            dtgv.Columns["ClorMauMucDo"].Visible = false;
            dtgv.Columns.Add("StrTenMon", "Tên Môn");
            dtgv.Columns["StrTenMon"].DisplayIndex = 0;
            foreach (DataGridViewRow dr in dtgv.Rows)
            {
                dr.Cells["StrTenMon"].Value = new CMonHoc_BLL().loadTenMon(dr.Cells["StrMaMon"].Value.ToString());
            }
        }

        private void thêmThờiKhóaKiểuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FThemMonThoiKhoaBieu frmThemThoiKhoaBieu = new FThemMonThoiKhoaBieu(strMaSV);
            frmThemThoiKhoaBieu.ShowDialog();
            ///Load lai du liệu tại tabPage
            /// 
            tabControl.TabPages.Clear();
            for (int i = 1; i < 8; i++)
            {
                loadLichHocThu(i);
            }
        }

        private void dtgv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult diaResult = MessageBox.Show("Bạn có muốn lưu xuống cơ sở dữ liệu không?\nNếu bạn còn muốn sửa tiếp dòng này Cancel", "Thông báo", MessageBoxButtons.YesNoCancel);
            if (diaResult == DialogResult.Cancel)
            {
                return;
            }
            if (diaResult == DialogResult.No)
            {
                DataGridView dtgv = (sender as DataGridView);
                List<CHoatDong_DTO> list;
                List<string> thuTuan = new List<string> { "Chủ nhật", "Thứ 2", "Thứ 3", "Thứ 4", "Thứ 5", "Thứ 6", "Thứ 7" };
                int iThu = thuTuan.IndexOf(tabControl.SelectedTab.Text) + 1;
                list = new CHoatDong_BLL().loadLichHocThu(strMaSV, iThu);
                dtgv.DataSource = list;
            }
            if (diaResult == DialogResult.Yes)
            {
                DataGridView dtgv = (sender as DataGridView);
                List<CHoatDong_DTO> list;
                List<string> thuTuan = new List<string> { "Chủ nhật", "Thứ 2", "Thứ 3", "Thứ 4", "Thứ 5", "Thứ 6", "Thứ 7" };
                int iThu = thuTuan.IndexOf(tabControl.SelectedTab.Text) + 1;
                
                //new CHoatDong_BLL().suaLichHocThu(lichSelect);
            }
        }
        private void xóaHoạtĐộngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CHoatDong_BLL().xoaLichHocThu(strMaSV,iThuSelect,lichSelect);
            ///Load lai du liệu tại tabPage
            /// 
            tabControl.TabPages.Clear();
            

            for (int i = 1; i < 8; i++)
            {
                loadLichHocThu(i);
            }
        }

        private void FDSThoiKhoaBieu_Resize(object sender, EventArgs e)
        {
            this.tabControl.Size = this.Size;
            int index=tabControl.SelectedIndex;
            try
            {
                tabControl.TabPages[index].Controls[0].Select();
                tabControl.TabPages[index].GetContainerControl().ActiveControl.Size = this.tabControl.Size;
            }
            catch (Exception) { }
        }
    }
}
