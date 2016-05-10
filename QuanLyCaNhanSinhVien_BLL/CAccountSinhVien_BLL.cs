using QuanLyCaNhanSinhVien_DAL;
using QuanLyCaNhanSinhVien_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCaNhanSinhVien_BLL
{
    public class CAccountSinhVien_BLL
    {
        public CSinhVien_DTO loadAccountSV(string strMaSV, string strMatKhau)
        {
            CAccountSinhVien_DTO ac = new CAccountSinhVien_DTO(strMaSV, strMatKhau);
            int iCountAcc;
            iCountAcc = new CAccountSinhVien_DAL().loadAccountSV(ac);
            CSinhVien_DTO sv = new CSinhVien_DTO();
            sv = new CSinhVien_DAL().loadThongTinSV(strMaSV);
            return sv;
        }
    }
}
