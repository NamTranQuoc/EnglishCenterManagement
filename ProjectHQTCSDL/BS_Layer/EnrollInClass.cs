using ProjectHQTCSDL.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHQTCSDL.BS_Layer
{
    public class EnrollInClass
    {
        public DataTable GetListClass(int iDStudent, string shift, string DOW, int iDCource)
        {
            DataTable dt = new DataTable();
            if (shift == "All" && DOW == "All" && iDCource == 0)
                dt = dbMain.Instance.ExcuteQuery("SELECT * FROM dbo.DanhSachLopDangKy");
            else if (shift == "All" && DOW == "All")
                dt = dbMain.Instance.ExcuteQuery("SELECT * FROM dbo.DanhSachLopDangKy WHERE ThuocKhoaHoc = " + iDCource);
            else if (shift == "All" && iDCource == 0)
                dt = dbMain.Instance.ExcuteQuery("SELECT * FROM dbo.DanhSachLopDangKy WHERE NgayHocTrongTuan = '" + DOW + "'");
            else if (DOW == "All" && iDCource == 0)
                dt = dbMain.Instance.ExcuteQuery("SELECT * FROM dbo.DanhSachLopDangKy WHERE CaHoc = " + shift);
            else if (shift == "All")
                dt = dbMain.Instance.ExcuteQuery("SELECT * FROM dbo.DanhSachLopDangKy WHERE NgayHocTrongTuan = '" + DOW + "' AND ThuocKhoaHoc = " + iDCource);
            else if (DOW == "All")
                dt = dbMain.Instance.ExcuteQuery("SELECT * FROM dbo.DanhSachLopDangKy WHERE CaHoc = " + shift + " AND ThuocKhoaHoc = " + iDCource);
            else if (iDCource == 0)
                dt = dbMain.Instance.ExcuteQuery("SELECT * FROM dbo.DanhSachLopDangKy WHERE CaHoc = " + shift + " AND NgayHocTrongTuan = '" + DOW + "'");
            else
                dt = dbMain.Instance.ExcuteQuery("SELECT * FROM dbo.DanhSachLopDangKy WHERE CaHoc = " + shift + " AND NgayHocTrongTuan = '" + DOW + "' AND ThuocKhoaHoc = " + iDCource);
            if (dt.Columns.Count == 0)
            {
                dt.Columns.Add("MaLop");
                dt.Columns.Add("SoHocVienDukien");
                dt.Columns.Add("SL");
                dt.Columns.Add("CaHoc");
                dt.Columns.Add("NgayHocTrongTuan");
                dt.Columns.Add("ThuocKhoaHoc");
                dt.Columns.Add("TenKhoaHoc");
            }    
            dt.Columns.Add("Select", typeof(bool));
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if ((int)dbMain.Instance.ExcuteScalar("SELECT COUNT(*) FROM dbo.DangKy WHERE MaHocVien = " + iDStudent + " AND MaLop = " + dt.Rows[i]["MaLop"]) > 0)
                    dt.Rows[i]["Select"] = true;
                else
                    dt.Rows[i]["Select"] = false;
            }    
            return dt;
        }

        public bool GetEnrolled(string iDStudent, string iDClass)
        {
            if ((int)dbMain.Instance.ExcuteScalar("SELECT COUNT(*) FROM dbo.DangKy WHERE MaHocVien = " + iDStudent + " AND MaLop = " + iDClass) > 0)
                return true;
            else
                return false;
        }

        public DataTable GetListCourceName()
        {
            DataTable dt = dbMain.Instance.ExcuteQuery("SELECT MaKhoaHoc, TenKhoaHoc FROM dbo.KhoaHoc ");
            dt.Rows.Add(0, "All");
            return dt;
        }

        public bool CheckClassEnable(int expected, int registered, int iDClass)
        {
            if (expected <= registered)
                return false;
            if ((int)dbMain.Instance.ExcuteScalar("SELECT COUNT(*) FROM (SELECT MaLop FROM dbo.LichHoc WHERE MaLop = 11 GROUP BY MaLop HAVING MIN(NgayHoc) >= GETDATE()) AS Q") > 0)
                return false;
            return true;
        }

        public bool DeleteEnroll(int iDClass, int iDStudent, ref string error)
        {
            int test = dbMain.Instance.ExcuteNonQuery("DELETE dbo.DangKy WHERE MaHocVien = " + iDStudent + " AND MaLop = " + iDClass, ref error);
            if (test > 0)
                return true;
            return false;
        }

        public bool InsertEnroll(int iDClass, int iDStudent, ref string error)
        {
            int test = dbMain.Instance.ExcuteNonQuery("INSERT dbo.DangKy VALUES  ( " + iDStudent + ", " + iDClass + ", 0)", ref error);
            if (test > 0)
                return true;
            return false;
        }
    }
}
