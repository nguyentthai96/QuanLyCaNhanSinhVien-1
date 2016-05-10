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
    }
}