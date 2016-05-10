using System;
using System.Collections.Generic;
using System.Drawing;
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
    public class SuKien
    {
        private Color colorSuKien;
        private DateTime dtmBegin;
        private DateTime dtmEnd;
        private string strNoiDung;

        public Color ColorSuKien
        {
            get
            {
                return colorSuKien;
            }

            set
            {
                this.colorSuKien = value;
            }
        }

        public DateTime DtmBegin
        {
            get
            {
                return dtmBegin;
            }

            set
            {
                this.dtmBegin = value;
            }
        }

        public DateTime DtmEnd
        {
            get
            {
                return dtmEnd;
            }

            set
            {
                this.dtmEnd = value;
            }
        }

        public string StrNoiDung
        {
            get
            {
                return strNoiDung;
            }

            set
            {
                this.strNoiDung = value;
            }
        }
    }
}
