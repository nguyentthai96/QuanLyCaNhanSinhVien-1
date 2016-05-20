using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using QuanLyCaNhanSinhVien_DAL;
using System.Data.SqlClient;

namespace QuanLyCaNhanSinhVien_BLL
{
    public class CHoatDong_BLL
    {
        private static CDataProvider_DAL dataProvider;
        public static DataTable loadSuKienTrongNgay(string strMaSV)
        {
            dataProvider = new CDataProvider_DAL();
            DateTime date = DateTime.Now;
            DataTable dtb = new DataTable();
            string strSelectCmd = string.Format("exec [dbo].[spHoatDongTuongLai] @MaSV={0}, @ThoiGianHienTai='{1}'", strMaSV, date.ToShortDateString());
            dtb = dataProvider.getDataTableExcuteQuery("LichHocNgay", strSelectCmd);
            return dtb;
        }

        public static DataTable loadLichHocTrongNgay(string strMaSV)
        {
            dataProvider = new CDataProvider_DAL();
            int iThu = DateTime.Now.DayOfWeek.GetHashCode()+1;
            DataTable dtb = new DataTable();
            string strSelectCmd = string.Format("exec [dbo].[spLichHocTrongNgay] @MaSV={0}, @Thu={1}",strMaSV,iThu);
            dtb= dataProvider.getDataTableExcuteQuery("LichHocNgay",strSelectCmd);
            return dtb;
        }

        public static int countHoatDong()
        {
            dataProvider = new CDataProvider_DAL();
            string strCountHoatDong = "select count(*) from HoatDong";
            string strErr = "";
            int iCount=(int)dataProvider.executeScalar(CommandType.Text,strCountHoatDong,ref strErr);
            return iCount;
        }

        public static bool themLichHoc(string strMaSV, int iThu, string strMaHD, string strMaMon, bool bChinhKhoa, DateTime dtmGioBD, DateTime dtmGioKT, string strGhiChu, int MauSac)
        {
            dataProvider = new CDataProvider_DAL();
            string strAddCmd = string.Format("spAddLichHoc");
            string strErr = "";
            dataProvider.excuteNonQuery(strAddCmd, CommandType.StoredProcedure,ref strErr,
                new SqlParameter("@MaSV", strMaSV), 
                new SqlParameter("@Thu", iThu), 
                new SqlParameter("@MaHD", strMaHD),
                new SqlParameter("@MaMon", strMaMon),
                new SqlParameter("@ChinhKhoa", bChinhKhoa), 
                new SqlParameter("@GioBD", dtmGioBD), 
                new SqlParameter("@GioKT", dtmGioKT),
                new SqlParameter("@GhiChuHD", strGhiChu), 
                new SqlParameter("@MauMucDo", MauSac)
                );
            if (strErr!="")
            {
                return false;
            }
            return true;
        }
    }
}