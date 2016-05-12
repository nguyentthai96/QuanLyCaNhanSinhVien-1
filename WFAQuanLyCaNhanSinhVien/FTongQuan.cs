using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyCaNhanSinhVien_DTO;
using QuanLyCaNhanSinhVien_BLL;
using static WFCTableList.LinesTableUC;

namespace WFAQuanLyCaNhanSinhVien
{
    public partial class FTongQuan : Form
    {
        private string strMaSV;
        List<SuKien> listSuKienUC;
        public FTongQuan(string strMaSV)
        {
          
            loadLichHocTrongNgay();
            InitializeComponent();
           linesTableUC.lists = listSuKienUC;
            this.strMaSV = strMaSV;
        }

        private void FTongQuan_SizeChanged(object sender, EventArgs e)
        {
            pnlCacSuKien.Location = new Point(this.Width / 2 - pnlCacSuKien.Width - 31 , pnlCacSuKien.Location.Y);
          linesTableUC.Location = new Point(this.Width / 2 + 30, linesTableUC.Location.Y);
            lblChaoMung.Width = this.Width;
            btnThemSuKien.Location = new Point(pnlCacSuKien.Location.X, btnThemSuKien.Location.Y);
        }

        List<CHoatDong_DTO> suKiens;
        List<CHoatDong_DTO> lichHocs;
        
        int indexSuKien = 0;
        private void loadSuKienGhiChu()
        {
            suKiens = new List<CHoatDong_DTO>();
            suKiens = new CHoatDong_BLL().loadSuKienTrongNgay();
            
            try
            {
                lblThoiGian.Text = suKiens[indexSuKien].DtmGioBD.ToShortTimeString() + "\n"
                       + suKiens[indexSuKien].DtmGioKT.ToShortTimeString();
                lblThongTin.Text = new CMonHoc_BLL().loadTenMon(suKiens[indexSuKien].StrMaMon) +
                   "\n"+ suKiens[indexSuKien].StrGhiChuHD;
            }
            catch (Exception)
            {

                MessageBox.Show("Lỗi load du liệu tên sự kiện");
            }
            

            if (suKiens.Count == 0)
                lblNext.Enabled = false;
        }
        private void loadLichHocTrongNgay()
        {
            listSuKienUC = new List<SuKien>();
            lichHocs = new List<CHoatDong_DTO>();
            lichHocs = new CHoatDong_BLL().loadLichHocTrongNgay();
            var listBuffer = lichHocs.Select(i => new { ColorSuKien = i.ClorMauMucDo, DtmBegin = i.DtmGioBD, DtmEnd = i.DtmGioKT, StrNoiDung = i.StrGhiChuHD });

            foreach (var l in listBuffer)
            {
                SuKien sk = new SuKien(l.ColorSuKien, l.DtmBegin, l.DtmEnd, l.StrNoiDung);
                listSuKienUC.Add(sk);
            }
            return;
        }
        private void FTongQuan_Load(object sender, EventArgs e)
        {
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
            loadSuKienGhiChu();
        }

        private void lblNext_Click(object sender, EventArgs e)
        {
            lblPrev.Enabled = true;
            indexSuKien++;
            try
            {
            lblThoiGian.Text = suKiens[indexSuKien].DtmGioBD.ToShortTimeString() + "\n"
                       + suKiens[indexSuKien].DtmGioKT.ToShortTimeString();
            lblThongTin.Text = new CMonHoc_BLL().loadTenMon(suKiens[indexSuKien].StrMaMon) +
                   "\n" + suKiens[indexSuKien].StrGhiChuHD;
            }
            catch (Exception)
            {

                MessageBox.Show("Có phải bạn không để dữ có sự kiện nào không?");
            }
            if (suKiens.Count == indexSuKien + 1)
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
            lblThoiGian.Text = suKiens[indexSuKien].DtmGioBD.ToShortTimeString() + "\n"
                       + suKiens[indexSuKien].DtmGioKT.ToShortTimeString();
            lblThongTin.Text = new CMonHoc_BLL().loadTenMon(suKiens[indexSuKien].StrMaMon) +
                   "\n" + suKiens[indexSuKien].StrGhiChuHD;
            if (suKiens.Count > indexSuKien+1)
                lblNext.Enabled = true;
        }

        private void btnThemSuKien_Click(object sender, EventArgs e)
        {
            FThemSuKien frm = new FThemSuKien();
            frm.ShowDialog();
            suKiens = new CHoatDong_BLL().loadSuKienTrongNgay();
            indexSuKien = -1;
            lblNext_Click(this.lblNext,new EventArgs());
            lblPrev.Enabled = false;
        }
    }
}
