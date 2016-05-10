using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCaNhanSinhVien_DTO
{
    public class CHocPhi_DTO
    {
        private string strMaSV;
        private string strMaHK;
        private float fSoTien;

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

        public float FSoTien
        {
            get
            {
                return fSoTien;
            }

            set
            {
                this.fSoTien = value;
            }
        }
    }
}
