using QuanLyCaNhanSinhVien_DAL;
using System;
using System.Data;

namespace QuanLyCaNhanSinhVien_BLL
{
    public class CHocKy_BLL
    {
        private static CDataProvider_DAL dataProvider;
        public static DataTable loaDSHocKy()
        {
            dataProvider=new CDataProvider_DAL();
            string strSelectHocKy = "select * from HocKy";

            DataTable dtb = new DataTable();
            dtb = dataProvider.getDataTableExcuteQuery("tbHocKy", strSelectHocKy);

            return dtb;
        }
    }
}