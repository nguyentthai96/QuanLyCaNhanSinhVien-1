using System;
using QuanLyCaNhanSinhVien_DTO;
using System.Collections.Generic;
using System.Data;

namespace QuanLyCaNhanSinhVien_DAL
{
    public class CDiemSo_DAL
    {
        public CDiemSo_DAL()
        {
        }

        public int countDiem(string strMaSV)
        {
            string strCountDiem = "select count(*) from DiemSo";
            string error = "";
            int iCount =new CDataProvider_DAL().executeScalar(System.Data.CommandType.Text, strCountDiem, ref error);
            return iCount;
        }

        public bool themDiem(CDiemSo_DTO diem)
        {
            string strThemDiem = string.Format("insert into DiemSo values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", 
                diem.StrMaMon, diem.StrMaSV,diem.StrMaHK, diem.StrMaDiem, diem.FSoDiem, diem.FHeSo, diem.DtmNgayDiem);

            string error = "";
            new CDataProvider_DAL().excuteNonQuery(strThemDiem, ref error);

            if (error!="")
            {
                return false;
            }

            return true;
        }

        public List<CDiemSo_DTO> loadDSDiemMon(string strMaSV, string strMaMon, string strMaHK)
        {

            string strSelectDiem = "select * from DiemSo where MaMon='" + strMaMon + "' and MaSV='" + strMaSV + "' and MaHK='" + strMaHK + "'";

            DataTable dtb = new DataTable();
            dtb = new CDataProvider_DAL().getDataTableExcuteQuery("tbDiemSoMonHocKy", strSelectDiem);

            List<CDiemSo_DTO> list = new List<CDiemSo_DTO>();
            foreach (DataRow dr in dtb.Rows)
            {
                CDiemSo_DTO diem = new CDiemSo_DTO(dr["MaMon"].ToString(), dr["MaSV"].ToString(), dr["MaHK"].ToString(), dr["MaDiem"].ToString(), float.Parse(dr["SoDiem"].ToString()), float.Parse(dr["HeSo"].ToString()), DateTime.Parse(dr["NgayDiem"].ToString()));
                list.Add(diem);
            }
            return list;
        }

        public bool removeDiem(CDiemSo_DTO diem)
        {
            string strUpdateDiem = string.Format("delete DiemSo where  MaMon='{0}' and  MaSV='{1}' and MaDiem='{2}'",
                 diem.StrMaMon, diem.StrMaSV, diem.StrMaDiem);
            string error = "";
            return new CDataProvider_DAL().excuteNonQuery(strUpdateDiem, ref error);
        }

        public bool suaDiem(CDiemSo_DTO diem)
        {
            string strUpdateDiem = string.Format("update DiemSo set SoDiem='{3}', HeSo='{4}', NgayDiem='{5}' where MaMon='{0}' and  MaSV='{1}' and MaDiem='{2}'",
                 diem.StrMaMon, diem.StrMaSV, diem.StrMaDiem, diem.FSoDiem, diem.FHeSo, diem.DtmNgayDiem);
            string error="";
            return new CDataProvider_DAL().excuteNonQuery(strUpdateDiem, ref error);
        }

        public List<CDiemSo_DTO> loadDSDiemMon(string strMaMon, string strMaSV)
        {
            string strSelectDiem = "select * from DiemSo where MaMon='" + strMaMon + "' and MaSV='" + strMaSV + "'";

            DataTable dtb = new DataTable();
            dtb = new CDataProvider_DAL().getDataTableExcuteQuery("tbDiemSo", strSelectDiem);

            List<CDiemSo_DTO> list = new List<CDiemSo_DTO>();
            foreach (DataRow dr in dtb.Rows)
            {
                CDiemSo_DTO diem = new CDiemSo_DTO(dr["MaMon"].ToString(), dr["MaSV"].ToString(), dr["MaHK"].ToString(), dr["MaDiem"].ToString(), float.Parse(dr["SoDiem"].ToString()), float.Parse(dr["HeSo"].ToString()), DateTime.Parse(dr["NgayDiem"].ToString()));
                list.Add(diem);
            }
            return list;
        }
    }
}