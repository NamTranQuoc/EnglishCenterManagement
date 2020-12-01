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
            string query = "Exec GetListClass @id = " + iDStudent + " , @shift = '" + shift + ", @DOW = '" + DOW + "' , @idCou = " + iDCource ;
            dt = dbMain.Instance.ExcuteQuery(query.ToString());
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
            string query = "EXEC dbo.GetEnrolled @id = " + iDStudent + ", @idCou = " + iDClass;
            if ((int)dbMain.Instance.ExcuteScalar(query) > 0)
                return true;
            else
                return false;
        }

        public DataTable GetListCourceName()
        {
            DataTable dt = dbMain.Instance.ExcuteQuery("EXEC GetListCourceName");
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
