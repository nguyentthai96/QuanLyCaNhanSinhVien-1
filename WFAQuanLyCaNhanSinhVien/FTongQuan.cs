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

namespace WFAQuanLyCaNhanSinhVien
{
    public partial class FTongQuan : Form
    {
        private string strMaSV;
        private string[,] arrStrThongTinLH = new string[2,5];
        public FTongQuan(string strMaSV)
        {
            InitializeComponent();
            creatLineVertical(70, 32);
           
            this.strMaSV = strMaSV;
        }

        private void FTongQuan_SizeChanged(object sender, EventArgs e)
        {
            pnlCacSuKien.Location = new Point(this.Width / 2 - pnlCacSuKien.Width - 31 , pnlCacSuKien.Location.Y);
            pnlThongTin.Location = new Point(this.Width / 2 + 30, pnlThongTin.Location.Y);
            lblChaoMung.Width = this.Width;
            btnThemSuKien.Location = new Point(pnlCacSuKien.Location.X, btnThemSuKien.Location.Y);
        }

        List<CHoatDong_DTO> suKiens;
        List<CHoatDong_DTO> lichHocs;
        int indexSuKien = 0;
        private void loadLichHoc()
        {
            suKiens = new List<CHoatDong_DTO>();
            lichHocs = new List<CHoatDong_DTO>();
            suKiens = new CHoatDong_BLL().loadSuKienTrongNgay();
            lichHocs= new CHoatDong_BLL().loadLichHocTrongNgay();
            lblThoiGian.Text = suKiens[indexSuKien].DtmGioBD.ToShortTimeString() + "\n"
                       + suKiens[indexSuKien].DtmGioKT.ToShortTimeString();
            lblThongTin.Text = new CMonHoc_BLL().loadTenMon(suKiens[indexSuKien].StrMaMon) +
                   "\n"+ suKiens[indexSuKien].StrGhiChuHD;

            if (suKiens.Count == 0)
                lblNext.Enabled = false;
            
            int index = 0;
            foreach (CHoatDong_DTO lh in lichHocs)
            {
                    arrStrThongTinLH[0, index] = new CMonHoc_BLL().loadTenMon(lh.StrMaMon);
                    arrStrThongTinLH[1, index++] = lh.DtmGioBD.ToShortTimeString() +
                            "\n" + lh.DtmGioKT.ToShortTimeString();
                if(index>4) break;
            }

            creatLineHorizotal(0, 32,  arrStrThongTinLH[0,0], arrStrThongTinLH[1,0]);
            creatLineHorizotal(0, 86,  arrStrThongTinLH[0,1], arrStrThongTinLH[1,1]);
            creatLineHorizotal(0, 140, arrStrThongTinLH[0,2], arrStrThongTinLH[1,2]);
            creatLineHorizotal(0, 194, arrStrThongTinLH[0,3], arrStrThongTinLH[1,3]);
            creatLineHorizotal(0, pnlThongTin.Height - 2, arrStrThongTinLH[0,4], arrStrThongTinLH[1,4]);
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
            loadLichHoc();
        }

        private void lblNext_Click(object sender, EventArgs e)
        {
            lblPrev.Enabled = true;
            indexSuKien++;
            lblThoiGian.Text = suKiens[indexSuKien].DtmGioBD.ToShortTimeString() + "\n"
                       + suKiens[indexSuKien].DtmGioKT.ToShortTimeString();
            lblThongTin.Text = new CMonHoc_BLL().loadTenMon(suKiens[indexSuKien].StrMaMon) +
                   "\n" + suKiens[indexSuKien].StrGhiChuHD;
            if (suKiens.Count == indexSuKien+1)
                lblNext.Enabled = false;
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
            lichHocs = new CHoatDong_BLL().loadLichHocTrongNgay();
            indexSuKien = -1;
            lblNext_Click(this.lblPrev,new EventArgs());
            lblPrev.Enabled = false;
        }
    }
}
