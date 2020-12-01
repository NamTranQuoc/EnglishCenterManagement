using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectHQTCSDL.DB_Layer;

namespace ProjectHQTCSDL.BS_Layer
{
    public class Attendance
    {
        public string GetSession(string iDClass)
        {
            string query = "Exec GetSession @date = '" + DateTime.Today.ToString("yyyy-MM-dd") + "' , @idclass = '" + iDClass + "'";
            return ((int)dbMain.Instance.ExcuteScalar(query)).ToString();
        }
        public DataTable GetClassList (string idClass, string session)
        {
            DataTable dt = dbMain.Instance.ExcuteQuery("SELECT * FROM DanhSachLopTheoBuoi (" + idClass + ", " + session + ")");
            dt.Columns.Add("Absent", typeof(bool));
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (CheckAbsent(idClass, session, int.Parse(dt.Rows[i]["MaHocVien"].ToString())))
                    dt.Rows[i]["Absent"] = true; 
                else
                    dt.Rows[i]["Absent"] = false;
            }    
            return dt;
        }

        public string GetNameCource (string iDClass)
        {
            int iDCource = (int) dbMain.Instance.ExcuteScalar("SELECT dbo.LayMaKhoahoc(" + iDClass + ")");
            return (string)dbMain.Instance.ExcuteScalar("SELECT TenKhoaHoc FROM KhoaHoc WHERE MaKhoaHoc = " + iDCource);
        }

        public string GetIDClass (int iDTeacher, string shift)
        {
            object id = dbMain.Instance.ExcuteScalar("SELECT LichHoc.MaLop FROM dbo.LichHoc, dbo.LopHoc WHERE NgayHoc = '" + DateTime.Today.ToString("yyyy-MM-dd") + "' AND MaGiaoVien = " + iDTeacher + " AND LichHoc.MaLop = LopHoc.MaLop AND CaHoc = " + shift);
            if (id != null)
                return ((int)id).ToString();
            else
                return null;
        }

        public bool CheckAbsent(string iDClass, string session, int iDStudent)
        {
            int i = (int)dbMain.Instance.ExcuteScalar("SELECT COUNT(*) FROM dbo.Vang WHERE MaLop = " + iDClass + " AND Buoi = " + session + " AND MaHocVien = " + iDStudent);
            if (i == 0)
                return false; //không tồn tại lịch vắng
            return true;
        }

        public string InsertAbsent (List<int> iDStudent, string iDClass, string session)
        {
            string err = null;
            dbMain.Instance.ExcuteNonQuery("DELETE dbo.Vang WHERE MaLop = " + iDClass + " AND Buoi = " + session, ref err);
            for (int i = 0; i < iDStudent.Count; i++)
            {
                dbMain.Instance.ExcuteNonQuery("EXECUTE ThemBuoiVang " + iDStudent[i] + ", " + iDClass + ", " + session, ref err);
            }
            return err;
        }
    }
}
