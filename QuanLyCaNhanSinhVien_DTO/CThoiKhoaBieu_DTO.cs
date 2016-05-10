using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCaNhanSinhVien_DTO
{
    public class CThoiKhoaBieu_DTO
    {
        private string strMaSV;
        private int iThu;
        private string strMaHD;

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

        public int IThu
        {
            get
            {
                return iThu;
            }

            set
            {
                this.iThu = value;
            }
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
    }
}
