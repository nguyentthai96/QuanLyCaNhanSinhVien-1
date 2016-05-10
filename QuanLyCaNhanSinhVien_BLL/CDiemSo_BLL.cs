using QuanLyCaNhanSinhVien_DAL;
using System;
using QuanLyCaNhanSinhVien_DTO;
using System.Collections.Generic;

namespace QuanLyCaNhanSinhVien_BLL
{
    public class CDiemSo_BLL
    {
        public CDiemSo_BLL()
        {
        }

        public int countDiem(string strMaSV)
        {
            return new CDiemSo_DAL().countDiem(strMaSV);
        }

        public bool themDiem(CDiemSo_DTO diem)
        {
            return new CDiemSo_DAL().themDiem(diem);
        }

        public object loadDSDiemMon(string strMaMon, string strMaSV)
        {
            return new CDiemSo_DAL().loadDSDiemMon(strMaMon, strMaSV);
        }

        public bool suaDiem(CDiemSo_DTO diem)
        {
            return new CDiemSo_DAL().suaDiem(diem);
        }

        public bool removeDiem(CDiemSo_DTO diem)
        {
            return new CDiemSo_DAL().removeDiem(diem);
        }

        public List<CDiemSo_DTO> loadDSDiemMon(string strMaSV, string strMaMon, string strMaHK)
        {
            return new CDiemSo_DAL().loadDSDiemMon(strMaSV,strMaMon, strMaHK);
        }
    }
}