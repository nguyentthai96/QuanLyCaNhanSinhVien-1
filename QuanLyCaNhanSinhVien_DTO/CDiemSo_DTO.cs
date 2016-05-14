using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCaNhanSinhVien_DTO
{
  public class CDiemSo_DTO
    {
        private string strMaMon;
        private string strMaSV;
        private string strMaHK;
        private string strMaDiem;
        private float fSoDiem;
        private float fHeSo;
        private DateTime dtmNgayDiem;

        public CDiemSo_DTO(string strMaMon, string strMaSV,string strMaHK, string strMaDiem, float fSoDiem, float fHeSo, DateTime dtmNgayDiem)
        {
            this.strMaMon = strMaMon;
            this.strMaSV = strMaSV;
            this.StrMaHK = strMaHK;
            this.strMaDiem = strMaDiem;
            this.fSoDiem = fSoDiem;
            this.fHeSo = fHeSo;
            this.dtmNgayDiem = dtmNgayDiem;
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

        public string StrMaDiem
        {
            get
            {
                return strMaDiem;
            }

            set
            {
                this.strMaDiem = value;
            }
        }

        public float FSoDiem
        {
            get
            {
                return fSoDiem;
            }

            set
            {
                this.fSoDiem = value > 10 && value < 0 ? float.NaN : value;
            }
        }

        public float FHeSo
        {
            get
            {
                return fHeSo;
            }

            set
            {
                this.fHeSo = value>10 && value<0 ? float.NaN : value;
            }
        }

        public DateTime DtmNgayDiem
        {
            get
            {
                return dtmNgayDiem;
            }

            set
            {
                this.dtmNgayDiem = value;
            }
        }

        public string StrMaHK
        {
            get
            {
                return strMaHK;
            }

            set
            {
                this.strMaHK = value;
            }
        }
    }
}
