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
            dataProvider = new CDataProvider_DAL();
            DataTable tb;
            string strSelectHoTen = string.Format("select * from SinhVien where MaSV='{0}'", strMaSV);
            tb = dataProvider.getDataTableExcuteQuery("tbTenSinhVien", strSelectHoTen);
            return tb;
        }

        public static bool themSinhVien(string strMaSV, string strHoTen, bool bGioiTinh, DateTime dtmNgaySinh, string strDiaChi, string strCacThongTinKhac, string ImageSV)
        {
            dataProvider = new CDataProvider_DAL();
            string strAddSinhVien = string.Format("insert into SinhVien values ('{0}',N'{1}','{2}','{3}','{4}','{5}','{6}')",
                                        strMaSV,strHoTen,bGioiTinh,dtmNgaySinh,strDiaChi,strCacThongTinKhac,ImageSV);
            string strErr="";
            dataProvider.excuteNonQuery(strAddSinhVien, ref strErr);
            if (strErr!="")
            {
                return false;
            }
            return true;
        }

        public static bool suaSinhVien(string strMaSV, string strHoTen, bool bGioiTinh, DateTime dtmNgaySinh, string strDiaChi, string strCacThongTinKhac, string ImageSV)
        {
            dataProvider = new CDataProvider_DAL();
            string strAddSinhVien = string.Format("update SinhVien set HoTen=N'{1}',GioiTinh='{2}',NgaySinh='{3}',DiaChi=N'{4}',CacThongTin=N'{5}',HinhAnh='{6}' where MaSV='{0}'",
                                        strMaSV, strHoTen, bGioiTinh, dtmNgaySinh, strDiaChi, strCacThongTinKhac, ImageSV);
            string strErr = "";
            dataProvider.excuteNonQuery(strAddSinhVien, ref strErr);
            if (strErr != "")
            {
                return false;
            }
            return true;
        }
    }
}