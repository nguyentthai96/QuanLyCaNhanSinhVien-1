using QuanLyCaNhanSinhVien_DAL;
using System;
using System.Collections.Generic;
using System.Data;

namespace QuanLyCaNhanSinhVien_BLL
{
    public class CDiemSo_BLL
    {
        private static CDataProvider_DAL dataProvider;
        public static DataTable loadDSDiemMon(string strMaSV, string strMaMon, string strMaHK)
        {
            string strSelectDiem = string.Format("SELECT TenMon ,SoDiem, HeSo FROM DiemSo, DanhSachMon, MonHoc WHERE DiemSo.MaSV = '{0}' and DiemSo.MaMon = '{1}' and DanhSachMon.MaHK = '{2}' and DiemSo.MaMon = DanhSachMon.MaMon and DiemSo.MaHK = DanhSachMon.MaHK and DiemSo.MaSV = DanhSachMon.MaSV and MonHoc.MaMon = DanhSachMon.MaMon",
                strMaSV, strMaMon,strMaHK);

            DataTable dtb = new DataTable();
            dtb = new CDataProvider_DAL().getDataTableExcuteQuery("tbDiemSo", strSelectDiem);

            return dtb;
        }
        public static DataTable loadDSDiemMon(string strMaSV, string strMaMon)
        {
            string strSelectDiem = "select * from DiemSo where MaMon='" + strMaMon + "' and MaSV='" + strMaSV + "'";

            DataTable dtb = new DataTable();
            dtb = new CDataProvider_DAL().getDataTableExcuteQuery("tbDiemSo", strSelectDiem);

            return dtb;
        }
        public static bool removeDiem(string strMaMon, string strMaSV, string strMaHK, string strMaDiem)
        {
            dataProvider = new CDataProvider_DAL();
            string strUpdateDiem = string.Format("delete DiemSo where  MaMon='{0}' and  MaSV='{1}' and MaDiem='{2}' and MaHK='{3}'",
                 strMaMon, strMaSV, strMaDiem, strMaHK);
            string error = "";
            return dataProvider.excuteNonQuery(strUpdateDiem, ref error);
        }

        public static bool suaDiem(string strMaMon, string strMaSV, string strMaHK, string strMaDiem, float fSoDiem, float fHeSo, DateTime dtmNgayDiem)
        {
            dataProvider = new CDataProvider_DAL();
            string strUpdateDiem = string.Format("update DiemSo set SoDiem='{3}', HeSo='{4}', NgayDiem='{5}' where MaMon='{0}' and  MaSV='{1}' and MaDiem='{2}'",
                 strMaMon, strMaSV, strMaDiem, fSoDiem, fHeSo, dtmNgayDiem);
            string error = "";
            return dataProvider.excuteNonQuery(strUpdateDiem, ref error);
        }

        public static int countDiem(string strMaSV)
        {
            dataProvider = new CDataProvider_DAL();
            string strCountDiem = "select count(*) from DiemSo";
            string error = "";
            int iCount = dataProvider.executeScalar(System.Data.CommandType.Text, strCountDiem, ref error);
            return iCount;
        }

        public static bool themDiem(string strMaMon, string strMaSV, string strMaHK, string strMaDiem, float fSoDiem, float fHeSo, DateTime dtmNgayDiem)
        {
            string strThemDiem = string.Format("insert into DiemSo values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')",
                 strMaSV, strMaMon, strMaHK, strMaDiem, fSoDiem, fHeSo, dtmNgayDiem);

            string error = "";
            new CDataProvider_DAL().excuteNonQuery(strThemDiem, ref error);

            if (error != "")
            {
                return false;
            }

            return true;
        }
    }
}