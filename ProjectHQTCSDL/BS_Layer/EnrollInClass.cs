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
        public DataTable GetListClass(int iDStudent, string shift, string DOW, int iDCource, ref string error, dbMain connectData)
        {
            DataTable dt = new DataTable();
            string query = "Exec [GetListClass] " + iDStudent + " , '" + shift + "', '" + DOW + "' , " + iDCource ;
            dt = connectData.ExcuteQuery(query.ToString(), ref error);
            if (dt.Columns.Count == 0)
            {
                dt.Columns.Add("IdClass");
                dt.Columns.Add("NOSE");
                dt.Columns.Add("NOS");
                dt.Columns.Add("Shift");
                dt.Columns.Add("DOW");
                dt.Columns.Add("IdCourse");
                dt.Columns.Add("NameCourse");
            }    
            dt.Columns.Add("Select", typeof(bool));
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if ((int)connectData.ExcuteScalar("EXEC [CheckEnroll] " +  iDStudent+ ", " + dt.Rows[i]["IdClass"]) > 0)
                    dt.Rows[i]["Select"] = true;
                else
                    dt.Rows[i]["Select"] = false;
            }    
            return dt;
        }

        public bool GetEnrolled(string iDStudent, string iDClass, dbMain connectData)
        {
            string query = "EXEC [CheckEnroll] " + iDStudent + ", " + iDClass;
            if ((int)connectData.ExcuteScalar(query) > 0)
                return true;
            else
                return false;
        }

        public DataTable GetListCourceName(ref string error, dbMain connectData)
        {
            DataTable dt = connectData.ExcuteQuery("EXEC [GetListCourceName]", ref error);
            dt.Rows.Add(0, "All");
            return dt;
        }

        public bool CheckClassEnable(int expected, int registered, int iDClass, dbMain connectData)
        {
            //kiểm tra học sinh dự kiến
            if (expected <= registered)
                return false;
            //kiển tra thời gian nếu khóa học đã bắt đâu trước khi đăng kí thì CheckClassEnable trả về 0
            if ((int)connectData.ExcuteScalar("EXEC [CheckClassEnable] " + iDClass) == 0)
                return false;
            return true;
        }

        public bool DeleteEnroll(int iDClass, int iDStudent, ref string error, dbMain connectData)
        {
            int test = connectData.ExcuteNonQuery("EXEC [DeleteEnroll] " + iDStudent + ", " + iDClass, ref error);
            if (test > 0)
                return true;
            return false;
        }

        public bool InsertEnroll(int iDClass, int iDStudent, ref string error, dbMain connectData)
        {
            int test = connectData.ExcuteNonQuery("EXEC [InsertEnroll] " + iDStudent + ", " + iDClass, ref error);
            if (test > 0)
                return true;
            return false;
        }
    }
}
