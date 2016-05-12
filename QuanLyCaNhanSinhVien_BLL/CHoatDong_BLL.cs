using System;
using System.Collections.Generic;
using System.Linq;
using QuanLyCaNhanSinhVien_DTO;
using QuanLyCaNhanSinhVien_DAL;

namespace QuanLyCaNhanSinhVien_BLL
{
    public class CHoatDong_BLL
    {
        public CHoatDong_BLL()
        {
        }

        public List<CHoatDong_DTO> loadSuKienTrongNgay()
        {
            return new CHoatDong_DAL().loadSuKienTrongNgay();
        }
        public List<CHoatDong_DTO> loadLichHocTrongNgay()
        {
            return new CHoatDong_DAL().loadLichHocTrongNgay();
        }

        public int countHoatDong()
        {
            return new CHoatDong_DAL().countHoatDong();
        }

        public bool themHoatDong(CHoatDong_DTO hoatDong)
        {
            return new CHoatDong_DAL().themHoatDong(hoatDong);
        }

        public bool themLichHoc(CHoatDong_DTO hd, int iThu, string strMaSV)
        {
            bool b1 = new CHoatDong_DAL().themHoatDongLichHoc(hd);
            if (b1 == false)
            {
                return false;
            }

                bool b2= new CThoiKhoaBieu_DAL().themHoatDongLichHoc(strMaSV,iThu, hd);
            if (b2 == false)
            {
                return false;
            }
            return true;
        }
    }
}