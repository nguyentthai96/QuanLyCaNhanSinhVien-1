using System;
using QuanLyCaNhanSinhVien_DTO;
using QuanLyCaNhanSinhVien_DAL;

namespace QuanLyCaNhanSinhVien_BLL
{
    public class CSinhVien_BLL
    {
        public CSinhVien_BLL()
        {
        }

        public bool themSinhVien(CSinhVien_DTO sv)
        {
            return new  CSinhVien_DAL().themSinhVien(sv);
        }

        public bool suaSinhVien(CSinhVien_DTO sv)
        {
            return new CSinhVien_DAL().suaSinhVien(sv);
        }

        public CSinhVien_DTO loadTTSV(string strMaSV)
        {
            return new CSinhVien_DAL().loadThongTinSV(strMaSV);
        }
    }
}