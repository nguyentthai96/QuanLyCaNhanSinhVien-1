using QuanLyCaNhanSinhVien_DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyCaNhanSinhVien_DAL
{
    public class CHoatDong_DAL
    {
        public CHoatDong_DAL()
        {
        }

        public List<CHoatDong_DTO> loadHoatDongTrongNgay()
        {
            string strSelectHoatDong = @"select * from HoatDong";

            DataTable dtb = new DataTable();
            dtb = new CDataProvider_DAL().getDataTableExcuteQuery("tbHoatDong", strSelectHoatDong);

            List<CHoatDong_DTO> lists = new List<CHoatDong_DTO>();
            foreach (DataRow dr in dtb.Rows)
            {
                CHoatDong_DTO hd = new CHoatDong_DTO(dr["MaHD"].ToString(), dr["MaMon"].ToString(), bool.Parse(dr["ChinhKhoa"].ToString()), 
                        int.Parse(dr["Tiet"].ToString()), DateTime.Parse( dr["GioBD"].ToString()), DateTime.Parse(dr["GioKT"].ToString()), dr["GhiChuHD"].ToString());
                lists.Add(hd);
            }

            return lists;
        }

        public bool themHoatDongLichHoc(CHoatDong_DTO hoatDong)
        {
            string strAddHoatDong = string.Format("insert into HoatDong values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', N'{6}', '{7}')", hoatDong.StrMaHD, hoatDong.StrMaMon,
                   hoatDong.BChinhKhoa, hoatDong.ITiet, hoatDong.DtmGioBD, hoatDong.DtmGioKT, hoatDong.StrGhiChuHD, hoatDong.ClorMauMucDo.ToArgb());
            string error = "";
            new CDataProvider_DAL().excuteNonQuery(strAddHoatDong, ref error);
            if (error != "")
            {
                return false;
            }
            return true;
        }

        public bool themHoatDong(CHoatDong_DTO hoatDong)
        {
            string strAddHoatDong = string.Format("insert into HoatDong values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', N'{6}', 0)",hoatDong.StrMaHD, hoatDong.StrMaMon,
                    hoatDong.BChinhKhoa, hoatDong.ITiet, hoatDong.DtmGioBD, hoatDong.DtmGioKT, hoatDong.StrGhiChuHD);
            string error="";
            new CDataProvider_DAL().excuteNonQuery(strAddHoatDong,ref error);
            if (error != "")
            {
                return false;
            }
            return true;
        }

        public int countHoatDong()
        {
            string strCountHoatDong = "select count(*) from HoatDong";
            string error="";
            int iCount = new CDataProvider_DAL().executeScalar(CommandType.Text, strCountHoatDong, ref error);
            return iCount;
        }

        public List<CHoatDong_DTO> loadLichHocTrongNgay()
        {
            string strSelectHoatDong = @"select * from HoatDong where ChinhKhoa='1'";

            DataTable dtb = new DataTable();
            dtb = new CDataProvider_DAL().getDataTableExcuteQuery("tbHoatDong", strSelectHoatDong);

            List<CHoatDong_DTO> lists = new List<CHoatDong_DTO>();
            foreach (DataRow dr in dtb.Rows)
            {
                CHoatDong_DTO hd = new CHoatDong_DTO(dr["MaHD"].ToString(), dr["MaMon"].ToString(), bool.Parse(dr["ChinhKhoa"].ToString()),
                        int.Parse(dr["Tiet"].ToString()), DateTime.Parse(dr["GioBD"].ToString()), DateTime.Parse(dr["GioKT"].ToString()), dr["GhiChuHD"].ToString(), int.Parse(dr["MauMucDo"].ToString()==""?"0":dr["MauMucDo"].ToString()));
                lists.Add(hd);
            }

            return lists;
        }

        public List<CHoatDong_DTO> loadSuKienTrongNgay()
        {
            string strSelectHoatDong = @"select * from HoatDong where ChinhKhoa='0'";

            DataTable dtb = new DataTable();
            dtb = new CDataProvider_DAL().getDataTableExcuteQuery("tbHoatDong", strSelectHoatDong);

            List<CHoatDong_DTO> lists = new List<CHoatDong_DTO>();
            foreach (DataRow dr in dtb.Rows)
            {
                CHoatDong_DTO hd = new CHoatDong_DTO(dr["MaHD"].ToString(), dr["MaMon"].ToString(), bool.Parse(dr["ChinhKhoa"].ToString()),
                        int.Parse(dr["Tiet"].ToString()), DateTime.Parse(dr["GioBD"].ToString()), DateTime.Parse(dr["GioKT"].ToString()), dr["GhiChuHD"].ToString());
                lists.Add(hd);
            }

            return lists;
        }
    }
}