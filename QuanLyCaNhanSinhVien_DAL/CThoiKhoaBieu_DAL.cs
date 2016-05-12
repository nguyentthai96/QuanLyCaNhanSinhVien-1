using System;
using QuanLyCaNhanSinhVien_DTO;

namespace QuanLyCaNhanSinhVien_DAL
{
    public class CThoiKhoaBieu_DAL
    {
        public CThoiKhoaBieu_DAL()
        {
        }

        public bool themHoatDongLichHoc(string strMaSV, int iThu, string strMaHD)
        {
            string strAddHoatDongLichHoc = string.Format("insert into ThoiKhoaBieu values('{0}', '{1}', '{2}')", strMaSV, iThu, strMaHD);
            string error = "";
            new CDataProvider_DAL().excuteNonQuery(strAddHoatDongLichHoc, ref error);
            if (error != "")
            {
                return false;
            }
            return true;
        }
    }
}