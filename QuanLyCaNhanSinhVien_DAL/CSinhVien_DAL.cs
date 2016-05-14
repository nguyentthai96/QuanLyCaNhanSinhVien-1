using QuanLyCaNhanSinhVien_DTO;
using System;
using System.Data;

namespace QuanLyCaNhanSinhVien_DAL
{
    public class CSinhVien_DAL
    {
        public CSinhVien_DAL()
        {
        }

        public CSinhVien_DTO loadThongTinSV(string strMaSV)
        {
            string strSelect = @"select * from SinhVien where MaSV='" + strMaSV + "'";

            DataTable dtb = new DataTable();
            dtb = new CDataProvider_DAL().getDataTableExcuteQuery("tbSinhVien", strSelect);

            if (dtb.Rows.Count == 0)
            {
                return null;
            }

            CSinhVien_DTO sv = new CSinhVien_DTO();
            sv.StrMaSV = strMaSV;
            sv.StrHoTen = dtb.Rows[0]["HoTen"].ToString();
            sv.BGioiTinh = dtb.Rows[0]["GioiTinh"].ToString() =="True" ? true : false;
            sv.DtmNgaySinh = DateTime.Parse(dtb.Rows[0]["NgaySinh"].ToString());
            sv.StrDiaChi = dtb.Rows[0]["DiaChi"].ToString();
            sv.StrCacThongTin = dtb.Rows[0]["CacThongTin"].ToString();

            return sv;
        }

        public bool suaSinhVien(CSinhVien_DTO sv)
        {
            string strSuaSV = string.Format("update SinhVien set HoTen=N'{0}', GioiTinh='{1}', NgaySinh='{2}', DiaChi=N'{3}', CacThongTin=N'{4}' where MaSV='{5}'",
                   sv.StrHoTen, sv.BGioiTinh==true ? 1 : 0, sv.DtmNgaySinh.ToShortDateString(), sv.StrDiaChi, sv.StrCacThongTin, sv.StrMaSV);

            string error = "";
            new CDataProvider_DAL().excuteNonQuery(strSuaSV, ref error);
            if (error != "")
            {
                return false;
            }
            return true;
        }

        public bool themSinhVien(CSinhVien_DTO sv)
        {
            string strThemSV = string.Format("insert into SinhVien values('{0}', N'{1}', '{2}', '{3}', N'{4}', N'{5}','')",
                    sv.StrMaSV, sv.StrHoTen, sv.BGioiTinh?1:0, sv.DtmNgaySinh.ToShortDateString(),sv.StrDiaChi,sv.StrCacThongTin);

            string error="";
            new CDataProvider_DAL().excuteNonQuery(strThemSV, ref error);
            if (error!="")
            {
                return false;
            }
            return true;
        }
    }
}