using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCaNhanSinhVien_DTO
{
    public class CMonHoc_DTO
    {
        private string strMaMon;
        private string strTenMon;
        private int iSoTinhChi;
        private int iSoTiet;

        public CMonHoc_DTO(string strMaMon, string strTenMon, int iSoTinhChi, int iSoTiet)
        {
            this.strMaMon = strMaMon;
            this.strTenMon = strTenMon;
            this.iSoTinhChi = iSoTinhChi;
            this.iSoTiet = iSoTiet;
        }

        public CMonHoc_DTO()
        {
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

        public int ISoTinhChi
        {
            get
            {
                return iSoTinhChi;
            }

            set
            {
                this.iSoTinhChi = value;
            }
        }

        public int ISoTiet
        {
            get
            {
                return iSoTiet;
            }

            set
            {
                this.iSoTiet = value;
            }
        }

        public string StrTenMon
        {
            get
            {
                return strTenMon;
            }

            set
            {
                this.strTenMon = value;
            }
        }
    }
}
