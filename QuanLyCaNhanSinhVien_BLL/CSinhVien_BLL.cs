using System;
using System.Data;
using QuanLyCaNhanSinhVien_DAL;

namespace QuanLyCaNhanSinhVien_BLL
{
    public class CSinhVien_BLL
    {
        private static CDataProvider_DAL dataProvider;
        public static string loadTenSinhVien(string strMaSV)
        {
            dataProvider = new CDataProvider_DAL();
            string strSelectHoTen = string.Format("select HoTen from SinhVien where MaSV='{0}'", strMaSV);
            string strHoTenSV = "";
            DataTable tb= dataProvider.getDataTableExcuteQuery("tbTenSinhVien", strSelectHoTen);
            strHoTenSV=tb.Rows[0]["HoTen"].ToString();
            return strHoTenSV;
        }

        public static DataTable loadSinhVienInfor(string strMaSV)
        {
            DataTable tb;
            string strSelectHoTen = string.Format("select * from SinhVien where MaSV='{0}'", strMaSV);
            tb = dataProvider.getDataTableExcuteQuery("tbTenSinhVien", strSelectHoTen);
            return tb;
        }

        public static bool themSinhVien(string text1, string text2, bool @checked, DateTime date, string text3, string text4)
        {
            throw new NotImplementedException();
        }

        public static bool suaSinhVien(string strMaSV, string text1, bool @checked, DateTime date, string text2, string text3)
        {
            throw new NotImplementedException();
        }
    }
}