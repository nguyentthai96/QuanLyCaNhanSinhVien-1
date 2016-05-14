using QuanLyCaNhanSinhVien_DTO;
using QuanLyCaNhanSinhVien_DAL;
using System;
using System.Collections.Generic;

namespace QuanLyCaNhanSinhVien_BLL
{
    public class CMonHoc_BLL
    {
        public CMonHoc_BLL()
        {
        }

        public string loadTenMon(string strMaMon)
        {
            return new CMonHoc_DAL().loadTenMon(strMaMon);
        }

        public object loadDSMon()
        {
            return new CMonHoc_DAL().loadDSMon();
        }

        public List<CMonHoc_DTO> loadDSMonSV(string strMaSV)
        {
            return new CMonHoc_DAL().loadDSMonSV(strMaSV);
        }

        public List<Tuple<string, string, string, string>> loadDSMonHKDiem(string strMaSV)
        {
            return new CMonHoc_DAL().loadDSMonHKDiem(strMaSV);
        }

        public List<CMonHoc_DTO> loadDSMonDangKyHK(string strMaSV, string strMaHK)
        {
           return new CMonHoc_DAL().loadDSMonDangKyHK(strMaSV, strMaHK);
        }

        public bool deleteMon(string strMaSV, string strMaMon, string strMaHK, out string error)
        {
            new CMonHoc_DAL().deleteMonDK(strMaSV, strMaMon, strMaHK, out error);
bool f = error == "The DELETE statement conflicted with the REFERENCE constraint \"FK__DiemSo__1CF15040\". The conflict occurred in database \"QuanLyCaNhanSinhVien\", table \"dbo.DiemSo\".\r\nThe statement has been terminated.";
            if (f)
            {
                error = "Có danh sách điểm đã nhập không thể xóa.\nBạn có muốn xóa luôn danh sách điểm không?";
                    return false;
            }
            return true;
        }
    }
}