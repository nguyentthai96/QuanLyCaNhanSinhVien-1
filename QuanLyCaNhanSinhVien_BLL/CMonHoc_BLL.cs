using QuanLyCaNhanSinhVien_DAL;
using System;
using System.Collections.Generic;
using System.Data;

namespace QuanLyCaNhanSinhVien_BLL
{
    public class CMonHoc_BLL
    {
        private static CDataProvider_DAL dataProvider;
        public static string loadTenMon(string strMaMon)
        {
            dataProvider = new CDataProvider_DAL();
            string selectTenMon = "select TenMon from MonHoc where MaMon='" + strMaMon + "'";
            return dataProvider.getDataTableExcuteQuery("tbTenMon", selectTenMon).Rows[0]["TenMon"].ToString();
        }

        public static DataTable loadDSMon()
        {
            dataProvider = new CDataProvider_DAL();
            string selectTenMon = "select * from MonHoc";
            return dataProvider.getDataTableExcuteQuery("tbTenMon", selectTenMon);
        }

        public static List<Tuple<string, string, string, string>> loadDSMonHKDiem(string strMaSV)
        {
            dataProvider = new CDataProvider_DAL();

            string strSelectMon =
                    @"select MonHoc.MaMon, MonHoc.TenMon, HocKy.TenHK, HocKy.MaHK from DanhSachMon inner join MonHoc on DanhSachMon.MaMon=MonHoc.MaMon inner join HocKy on DanhSachMon.MaHK=HocKy.MaHK where DanhSachMon.MaSV='" + strMaSV + "'";
            DataTable tbl = new DataTable();
            tbl = new CDataProvider_DAL().getDataTableExcuteQuery("tbMonHoc", strSelectMon);

            List<Tuple<string, string, string, string>> lists;
            lists = new List<Tuple<string, string, string, string>>();
            foreach (DataRow dr in tbl.Rows)
            {
                Tuple<string, string, string, string> item = new Tuple<string, string, string, string>(dr["MaMon"].ToString(), dr["TenMon"].ToString() + "-" + dr["TenHK"].ToString(), dr["TenHK"].ToString(), dr["MaHK"].ToString());
                lists.Add(item);
            }
            return lists;
        }

        public DataTable loadDSMonSV(string strMaSV)
        {
            string strSelectMon = @"select MonHoc.MaMon, MonHoc.TenMon from DanhSachMon inner join MonHoc on DanhSachMon.MaMon=MonHoc.MaMon where DanhSachMon.MaSV='" + strMaSV + "'";
            DataTable tbl = new DataTable();
            tbl = new CDataProvider_DAL().getDataTableExcuteQuery("tbMonHoc", strSelectMon);

            return tbl;
        }
    }
}