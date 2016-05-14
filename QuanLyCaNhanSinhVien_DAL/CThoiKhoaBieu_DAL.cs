using System;
using System.Collections.Generic;
using QuanLyCaNhanSinhVien_DTO;
using System.Data;

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

        public List<string> loadThoiKhoaBieuThu(string strMaSV, int iThu)
        {
            string strLoadThoiKhoaBieuHoc = string.Format("select MaHD from ThoiKhoaBieu where MaSV='{0}' and Thu='{1}'", strMaSV, iThu);

            DataTable tb = new DataTable();
            tb=new CDataProvider_DAL().getDataTableExcuteQuery("tbDSHoatDong_TKB",strLoadThoiKhoaBieuHoc);
            if (tb.Rows.Count==0)
            {
                return null;
            }
            List<string> lists=new List<string>();
            foreach(DataRow r in tb.Rows)
            {
                lists.Add(r["MaHD"].ToString());
            }
            return lists;
        }

        public List<CThoiKhoaBieu_DTO> loadThoiKhoaBieu(string strMaSV)
        {
            string strLoadThoiKhoaBieuHoc = string.Format("select * from ThoiKhoaBieu where MaSV='{0}'", strMaSV);

            DataTable tb = new DataTable();
            tb = new CDataProvider_DAL().getDataTableExcuteQuery("tbDSHoatDong_TKB", strLoadThoiKhoaBieuHoc);
            if (tb.Rows.Count == 0)
            {
                return null;
            }
            List<CThoiKhoaBieu_DTO> lists = new List<CThoiKhoaBieu_DTO>();
            foreach (DataRow r in tb.Rows)
            {
                lists.Add(new CThoiKhoaBieu_DTO(strMaSV,int.Parse(r["Thu"].ToString()),r["MaHD"].ToString()));
            }
            return lists;
        }

        public bool xoaLichHocThu(string strMaSV, int iThuSelect, string strMaHD)
        {
            string strAddHoatDongLichHoc = string.Format("delete from ThoiKhoaBieu where MaSV='{0}' and Thu='{1}' and MaHD='{2}'", strMaSV, iThuSelect, strMaHD);
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