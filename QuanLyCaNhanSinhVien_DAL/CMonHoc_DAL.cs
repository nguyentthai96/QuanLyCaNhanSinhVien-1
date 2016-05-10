using System;
using System.Collections.Generic;
using System.Data;
using QuanLyCaNhanSinhVien_DTO;

namespace QuanLyCaNhanSinhVien_DAL
{
    public class CMonHoc_DAL
    {
        public CMonHoc_DAL()
        {
        }

        public string loadTenMon(string strMaMon)
        {
            string strSelectTenMon = "select TenMon from MonHoc where MaMon='" + strMaMon + "'";
            DataTable dtb = new DataTable();
            dtb = new CDataProvider_DAL().getDataTableExcuteQuery("tbTenMon", strSelectTenMon);

            return dtb.Rows[0][0].ToString();
        }

        public object loadDSMon()
        {
            string strSelectMon = @"select MaMon, TenMon from MonHoc";
            DataTable tbl = new DataTable();
            tbl = new CDataProvider_DAL().getDataTableExcuteQuery("tbMonHoc", strSelectMon);
            return tbl;
        }

        public List<CMonHoc_DTO> loadDSMonDangKyHK(string strMaSV, string strMaHK)
        {
            string strSelectMon =
                    @"select MonHoc.* from DanhSachMon inner join MonHoc on DanhSachMon.MaMon=MonHoc.MaMon where DanhSachMon.MaSV='" + strMaSV + "' and DanhSachMon.MaHK='"+strMaHK+"'";
            DataTable tbl = new DataTable();
            tbl = new CDataProvider_DAL().getDataTableExcuteQuery("tbMonHocHK", strSelectMon);

            List<CMonHoc_DTO> lists;
            lists = new List<CMonHoc_DTO>();
            foreach (DataRow dr in tbl.Rows)
            {
                CMonHoc_DTO item = new CMonHoc_DTO(dr["MaMon"].ToString(), dr["TenMon"].ToString(), int.Parse(dr["SoTinhChi"].ToString()), int.Parse(dr["SoTiet"].ToString()));
                lists.Add(item);
            }
            return lists;
        }

        public bool deleteMonDK(string strMaSV, string  strMaMon, string strMaHK, out string error)
        {
            string strDeleteMonDK = string.Format("delete from DanhSachMon where MaSV='{0}' and MaMon='{1}' and MaHK='{2}'", strMaSV, strMaMon, strMaHK);

            error="";
            return new CDataProvider_DAL().excuteNonQuery(strDeleteMonDK,ref error);
        }

        //TODO Tai sao khong ep tra ve duoc
        //public List<object> loadDSMonHKDiem(string strMaSV)
        //{
        //    string strSelectMon = @"select MonHoc.MaMon, MonHoc.TenMon, HocKy.TenHK from DanhSachMon inner join MonHoc on DanhSachMon.MaMon=MonHoc.MaMon inner join HocKy on MonHoc.MaHK=HocKy.MaHK where DanhSachMon.MaSV='" + strMaSV + "'";
        //    DataTable tbl = new DataTable();
        //    tbl = new CDataProvider_DAL().getDataTableExcuteQuery("tbMonHoc", strSelectMon);

        //    List<object> lists;
        //    lists = new List<object>();
        //    foreach (DataRow dr in tbl.Rows)
        //    {
        //        object item =new {
        //            strMaMon=dr["MaMon"].ToString(),
        //            strTenMon=dr["TenMon"].ToString()+ "-"+dr["TenHK"].ToString()
        //        };

        //        lists.Add(item);
        //    }
        //    return lists;
        //}

        public List<Tuple<string, string, string>> loadDSMonHKDiem(string strMaSV)
        {
            string strSelectMon = 
                    @"select MonHoc.MaMon, MonHoc.TenMon, HocKy.TenHK from DanhSachMon inner join MonHoc on DanhSachMon.MaMon=MonHoc.MaMon inner join HocKy on DanhSachMon.MaHK=HocKy.MaHK where DanhSachMon.MaSV='" + strMaSV + "'";
            DataTable tbl = new DataTable();
            tbl = new CDataProvider_DAL().getDataTableExcuteQuery("tbMonHoc", strSelectMon);

            List<Tuple<string, string, string >> lists;
            lists = new List<Tuple<string, string, string >>();
            foreach (DataRow dr in tbl.Rows)
            {
                Tuple<string, string, string> item= new Tuple<string, string, string>(dr["MaMon"].ToString(),dr["TenMon"].ToString() + "-" + dr["TenHK"].ToString(), dr["TenHK"].ToString());             
                lists.Add(item);
            }
            return lists;
        }

        public List<CMonHoc_DTO> loadDSMonSV(string strMaSV)
        {
            string strSelectMon = @"select MonHoc.MaMon, MonHoc.TenMon from DanhSachMon inner join MonHoc on DanhSachMon.MaMon=MonHoc.MaMon where DanhSachMon.MaSV='" + strMaSV+"'";
            DataTable tbl = new DataTable();
            tbl = new CDataProvider_DAL().getDataTableExcuteQuery("tbMonHoc", strSelectMon);

            List<CMonHoc_DTO> lists;
            lists = new List<CMonHoc_DTO>();

            foreach (DataRow dr in tbl.Rows)
            {
                CMonHoc_DTO item;
                item = new CMonHoc_DTO();
                item.StrMaMon = dr["MaMon"].ToString();
                item.StrTenMon = dr["TenMon"].ToString();
                lists.Add(item);
            }
            return lists;
        }
    }
}