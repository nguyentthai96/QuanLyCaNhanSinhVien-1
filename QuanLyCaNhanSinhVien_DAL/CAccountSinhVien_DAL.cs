using QuanLyCaNhanSinhVien_DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCaNhanSinhVien_DAL
{
    public class CAccountSinhVien_DAL
    {
        public int loadAccountSV(CAccountSinhVien_DTO ac)
        {
            string cmdSqlText = string.Format(@"select count(*) from AccountSinhVien where AccountSV='{0}' and PasswordSV=N'{1}'", ac.StrMaSV, ac.StrPasswordSV);

            string error = "";
            int iCount= new CDataProvider_DAL().executeScalar(CommandType.Text,cmdSqlText, ref error);

            return iCount;
        }
    }
}
