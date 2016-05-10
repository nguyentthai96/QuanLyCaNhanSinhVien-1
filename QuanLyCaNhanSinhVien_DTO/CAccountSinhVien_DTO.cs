using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCaNhanSinhVien_DTO
{
    public class CAccountSinhVien_DTO
    {
        private string strMaSV;
        private string strPasswordSV;

        public CAccountSinhVien_DTO(string strMaSV, string strMatKhau)
        {
            this.strMaSV = strMaSV;
            this.strPasswordSV = strMatKhau;
        }

        public string StrPasswordSV
        {
            get
            {
                return strPasswordSV;
            }

            set
            {
                this.strPasswordSV = value;
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
    }
}
