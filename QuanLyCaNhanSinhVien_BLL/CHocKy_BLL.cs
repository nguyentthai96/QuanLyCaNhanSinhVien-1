using QuanLyCaNhanSinhVien_DAL;
using System;

namespace QuanLyCaNhanSinhVien_BLL
{
    public class CHocKy_BLL
    {
        public CHocKy_BLL()
        {
        }

        public object loadDSHocKy()
        {
            return new CHocKy_DAL().loaDSHocKy();
        }
    }
}