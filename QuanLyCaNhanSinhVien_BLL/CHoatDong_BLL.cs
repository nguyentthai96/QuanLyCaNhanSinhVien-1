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

        public List<CHoatDong_DTO> loadSuKienTrongNgay(string strMaSV)
        {
            return new CHoatDong_DAL().loadSuKienTrongNgay(strMaSV);
        }
        public List<CHoatDong_DTO> loadLichHocTrongNgay(string strMaSV)
        {
            return new CHoatDong_DAL().loadLichHocTrongNgay(strMaSV);
        }

        public int countHoatDong()
        {
            return new CHoatDong_DAL().countHoatDong();
        }

        public bool themHoatDong(string strMaSV ,CHoatDong_DTO hoatDong)
        {
            if( new CHoatDong_DAL().themHoatDong( hoatDong)==false)
            {
                return false;
            }
            if (new CThoiKhoaBieu_DAL().themHoatDongLichHoc(strMaSV, hoatDong.DtmGioBD.DayOfWeek.GetHashCode(), hoatDong.StrMaHD)==false)
                {
                return false;
            }
            return true;
        }

        public List<CHoatDong_DTO> loadLichHocThu(string strMaSV, int iThu)
        {
            return new CHoatDong_DAL().loadLichHocThu( strMaSV, iThu);
        }

        public bool themLichHoc(CHoatDong_DTO hd, int iThu, string strMaSV)
        {
            bool b1 = new CHoatDong_DAL().themHoatDongLichHoc(hd);
            if (b1 == false)
            {
                return false;
            }

                bool b2= new CThoiKhoaBieu_DAL().themHoatDongLichHoc(strMaSV,iThu, hd.StrMaHD);
            if (b2 == false)
            {
                return false;
            }
            return true;
        }

        public bool xoaLichHocThu(string strMaSV, int iThuSelect, CHoatDong_DTO lichSelect)
        {
            ///Chỉ set active off không xóa dữ liệu
            ///
            if(new CThoiKhoaBieu_DAL().xoaLichHocThu(strMaSV, iThuSelect, lichSelect.StrMaHD)==false)
            {
                return false;
            }
            return true;
        }
    }
}