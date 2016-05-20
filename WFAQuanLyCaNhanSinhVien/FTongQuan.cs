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
using static WFCTableList.LinesTableUC;

namespace WFAQuanLyCaNhanSinhVien
{
    public partial class FTongQuan : Form
    {
        private string strMaSV;
        /// <summary>
        /// Index lấy cho next prev của Sự kiện quản lý trên suKiens
        /// </summary>
        int indexSuKien = 0;
        /// <summary>
        /// Chứa thông tin hoạt động sự kiện đổ lên các label trên panel
        /// </summary>
        DataTable suKiens;
        /// <summary>
        /// Chứa dữ liệu load lên từ cơ sở dữ liệu
        /// </summary>
        DataTable lichHocs;
        /// <summary>
        /// Chứa dữ liệu có thể đổ xuống lineTableUC, cần phải chuyển dữ liệu từ lichHocs sang
        /// </summary>
        List<SuKien> listSuKienUC;

        public FTongQuan(string strMaSV)
        {
            this.strMaSV = strMaSV;
            loadLichHocTrongNgay();
            InitializeComponent();
            linesTableUC.lists = listSuKienUC;
        }

        private void FTongQuan_Load(object sender, EventArgs e)
        {
            #region In ra dòng xin chào
            if (4 < DateTime.Now.Hour && DateTime.Now.Hour < 11)
            {
                lblChaoMung.Text = "Buổi sáng học tập tốt.";
            }
            else
            {
                if (DateTime.Now.Hour < 1)
                {
                    lblChaoMung.Text = "Buổi trưa thật nóng";
                }
                else
                {
                    if (DateTime.Now.Hour < 18)
                    {
                        lblChaoMung.Text = "Buổi chiều học tốt";
                    }
                    else
                    {
                        if (DateTime.Now.Hour < 22)
                        {
                            lblChaoMung.Text = "Buổi tối phấn đấu";
                        }
                        else
                        {
                            lblChaoMung.Text = "Khuya rồi đi ngủ thôi";
                        }
                    }
                }
            }
            #endregion

            loadSuKienGhiChu();
        }
        
        /// <summary>
        /// Su kiện của ghi chú.
        /// </summary>
        private void loadSuKienGhiChu()
        {
            suKiens = CHoatDong_BLL.loadSuKienTrongNgay(strMaSV);

            try
            {
                lblThoiGian.Text = DateTime.Parse(suKiens.Rows[indexSuKien]["GioBD"].ToString()).ToShortDateString() + "\n"
                       + DateTime.Parse( suKiens.Rows[indexSuKien]["GioKT"].ToString()).ToShortDateString();
                lblThongTin.Text = CMonHoc_BLL.loadTenMon(suKiens.Rows[indexSuKien]["MaMon"].ToString()) +
                   "\n" + suKiens.Rows[indexSuKien]["GhiChuHD"].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi load dữ liệu sự kiện, không có sự kiện nào");
            }
            
            if (suKiens.Rows.Count <= 1)
                lblNext.Enabled = false;
        }
        
        /// <summary>
        /// Load dữ liệu lịch học từ database và đưa đến listSuKienUC để sau đó đưa vào lineTableUC
        /// </summary>
        private bool loadLichHocTrongNgay() 
        {
            lichHocs = CHoatDong_BLL.loadLichHocTrongNgay(strMaSV);
                if (lichHocs == null)
                {
                    listSuKienUC = null;
                return false;
                }
            
                listSuKienUC = new List<SuKien>();
            foreach (DataRow dr in lichHocs.Rows)
            {
                Color clSuKien = Color.FromArgb(int.Parse(dr["MauMucDo"].ToString()));
                SuKien sk = new SuKien(clSuKien,DateTime.Parse(dr["GioBD"].ToString()),DateTime.Parse(dr["GioKT"].ToString()),
                                        CMonHoc_BLL.loadTenMon(dr["MaMon"].ToString()));
                listSuKienUC.Add(sk);
            }
            return true;
        }

        private void FTongQuan_SizeChanged(object sender, EventArgs e)
        {
            pnlCacSuKien.Location = new Point(this.Width / 2 - pnlCacSuKien.Width - 31, pnlCacSuKien.Location.Y);
            linesTableUC.Location = new Point(this.Width / 2 + 30, linesTableUC.Location.Y);
            lblChaoMung.Width = this.Width;
        }

        private void tmiThemSuKien_Click(object sender, EventArgs e)
        {
            //ToDo
            //FThemSuKien frm = new FThemSuKien(strMaSV);
            //frm.StartPosition = FormStartPosition.CenterScreen;
            //frm.ShowDialog();
            //suKiens = new CHoatDong_BLL().loadSuKienTrongNgay(strMaSV);
            //indexSuKien = -1;
            //if (suKiens.Count!=0)
            //{
            //    lblNext_Click(this.lblNext, new EventArgs());
            //    lblPrev.Enabled = false;
            //}
        }

        private void lblNext_Click(object sender, EventArgs e)
        {
            indexSuKien++;
            try
            {
                lblThoiGian.Text = suKiens.Rows[indexSuKien]["GioBD"].ToString() + "\n"
                           + suKiens.Rows[indexSuKien]["GioKT"].ToString();
                lblThongTin.Text = CMonHoc_BLL.loadTenMon(suKiens.Rows[indexSuKien]["MaMon"].ToString()) +
                       "\n" + suKiens.Rows[indexSuKien]["GhiChuHD"];
                
                lblPrev.Enabled = true;
            }
            catch (Exception)
            {

                MessageBox.Show("Có phải bạn không để dữ có sự kiện nào không?");
            }
            if (suKiens.Rows.Count == indexSuKien + 1)
            {
                lblNext.Enabled = false;
            }
            else
            {
                lblNext.Enabled = true;
            }
        }
        private void lblPrev_Click(object sender, EventArgs e)
        {
            indexSuKien--;
            if (indexSuKien == 0)
            {
                lblPrev.Enabled = false;
            }
            lblThoiGian.Text = suKiens.Rows[indexSuKien]["GioBD"].ToString() + "\n"
                       + suKiens.Rows[indexSuKien]["GioKT"].ToString();
            lblThongTin.Text = CMonHoc_BLL.loadTenMon(suKiens.Rows[indexSuKien]["MaMon"].ToString()) +
                   "\n" + suKiens.Rows[indexSuKien]["GhiChuHD"];
            if (suKiens.Rows.Count > indexSuKien + 1)
                lblNext.Enabled = true;
        }

        private void tmiThemLich_Click(object sender, EventArgs e)
        {
            FThemMonThoiKhoaBieu thoiKhoaBieu = new FThemMonThoiKhoaBieu(strMaSV);
            thoiKhoaBieu.StartPosition = FormStartPosition.CenterScreen;
            thoiKhoaBieu.ShowDialog();

            loadLichHocTrongNgay();
            linesTableUC.lists = listSuKienUC;
            linesTableUC.loadUserControl();
        }
        //Todo
        //FDSThoiKhoaBieu dsThoiKhoaBieu;
        private void tmiThoiKhoaBieu_Click(object sender, EventArgs e)
        {
            //ToDo
            //dsThoiKhoaBieu = new FDSThoiKhoaBieu(strMaSV);
            //dsThoiKhoaBieu.MdiParent= this.ParentForm;
            //dsThoiKhoaBieu.WindowState = FormWindowState.Maximized;
            //dsThoiKhoaBieu.Show();
            this.Close();
        }
    }
}
