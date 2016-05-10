using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCaNhanSinhVien_DTO
{
    public class CHoatDong_DTO
    {
        private string strMaHD;
        private string strMaMon;
        private bool bChinhKhoa;
        private int iTiet;
        private DateTime dtmGioBD;
        private DateTime dtmGioKT;
        private string strGhiChuHD;

        public CHoatDong_DTO(string strMaHD, string strMaMon, bool bChinhKhoa, int iTiet, DateTime dtmGioBD, DateTime dtmGioKT, string strGhiChuHD)
        {
            this.strMaHD = strMaHD;
            this.strMaMon = strMaMon;
            this.bChinhKhoa = bChinhKhoa;
            this.iTiet = iTiet;
            this.dtmGioBD = dtmGioBD;
            this.dtmGioKT = dtmGioKT;
            this.strGhiChuHD = strGhiChuHD;
        }
        public string StrMaHD
        {
            get
            {
                return strMaHD;
            }

            set
            {
                this.strMaHD = value;
            }
        }

        public string StrMaMon
        {
            get
            {
                return strMaMon;
            }

            set
            {
                this.strMaMon = value;
            }
        }

        public bool BChinhKhoa
        {
            get
            {
                return bChinhKhoa;
            }

            set
            {
                this.bChinhKhoa = value;
            }
        }

        public int ITiet
        {
            get
            {
                return iTiet;
            }

            set
            {
                this.iTiet = value;
            }
        }

        public DateTime DtmGioBD
        {
            get
            {
                return dtmGioBD;
            }

            set
            {
                this.dtmGioBD = value;
            }
        }

        public DateTime DtmGioKT
        {
            get
            {
                return dtmGioKT;
            }

            set
            {
                this.dtmGioKT = value;
            }
        }

        public string StrGhiChuHD
        {
            get
            {
                return strGhiChuHD;
            }

            set
            {
                this.strGhiChuHD = value;
            }
        }
    }
}
