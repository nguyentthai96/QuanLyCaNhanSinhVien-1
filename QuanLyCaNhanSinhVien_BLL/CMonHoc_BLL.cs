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
    }
}