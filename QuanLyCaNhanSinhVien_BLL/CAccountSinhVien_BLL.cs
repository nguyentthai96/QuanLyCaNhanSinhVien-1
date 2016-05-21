using QuanLyCaNhanSinhVien_DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCaNhanSinhVien_BLL
{
    public class CAccountSinhVien_BLL
    {
        private static CDataProvider_DAL dataProvider;

        public static bool checkAccount(string strTaiKhoan, string strMatKhau)
        {
            dataProvider = new CDataProvider_DAL();
            string strCountCmd = string.Format("select count(*) from AccountSinhVien where MaSV='{0}' and PasswordSV=N'{1}'", strTaiKhoan, strMatKhau);
            string strError = "";
            int iCountAccount = (int)dataProvider.executeScalar(CommandType.Text, strCountCmd, ref strError);
            if (iCountAccount == 0)
            {
                return false;
            }
            return true;
        }

        public static bool addAccountSinhVien(string strTaiKhoan, string strMatKhau)
        {
            dataProvider = new CDataProvider_DAL();
            string strAddSinhVien = string.Format("insert into AccountSinhVien values ('{0}',N'{1}')", strTaiKhoan, strMatKhau);
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
