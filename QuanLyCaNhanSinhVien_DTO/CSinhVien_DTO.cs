using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCaNhanSinhVien_DTO
{
    public class CSinhVien_DTO
    {
        private string strMaSV;
        private string strHoTen;
        private bool bGioiTinh; //true Nam
        private DateTime dtmNgaySinh;
        private string strDiaChi;
        private string strCacThongTin;

        public CSinhVien_DTO(string strMaSV, string strHoTen, bool bGioiTinh, DateTime dtmNgaySinh, string strDiaChi, string strCacThongTin)
        {
            this.strMaSV = strMaSV;
            this.strHoTen = strHoTen;
            this.bGioiTinh = bGioiTinh;
            this.dtmNgaySinh = dtmNgaySinh;
            this.strDiaChi = strDiaChi;
            this.strCacThongTin = strCacThongTin;
        }

        public CSinhVien_DTO()
        {
        }

        public string StrMaSV
        {
            get
            {
                return strMaSV;
            }

            set
            {
                this.strMaSV = value;
            }
        }

        public string StrHoTen
        {
            get
            {
                return strHoTen;
            }

            set
            {
                this.strHoTen = value;
            }
        }

        public string StrCacThongTin
        {
            get
            {
                return strCacThongTin;
            }

            set
            {
                this.strCacThongTin = value;
            }
        }

        public bool BGioiTinh
        {
            get
            {
                return bGioiTinh;
            }

            set
            {
                this.bGioiTinh = value;
            }
        }

        public DateTime DtmNgaySinh
        {
            get
            {
                return dtmNgaySinh;
            }

            set
            {
                this.dtmNgaySinh = value;
            }
        }

        public string StrDiaChi
        {
            get
            {
                return strDiaChi;
            }

            set
            {
                this.strDiaChi = value;
            }
        }
    }
}
