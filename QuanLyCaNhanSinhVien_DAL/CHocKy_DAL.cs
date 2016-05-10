using System;
using System.Data;

namespace QuanLyCaNhanSinhVien_DAL
{
    public class CHocKy_DAL
    {
        public CHocKy_DAL()
        {
        }

        public object loaDSHocKy()
        {
            string strSelectHocKy = "select * from HocKy";

            DataTable dtb = new DataTable();
            dtb = new CDataProvider_DAL().getDataTableExcuteQuery("tbHocKy",strSelectHocKy);

            return dtb;
        }
    }
}