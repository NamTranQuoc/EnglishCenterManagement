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
        public string GetSession(string iDClass, dbMain connectData)
        {
            return ((int)connectData.ExcuteScalar("EXEC [GetSession] " + iDClass)).ToString();
        }
        public DataTable GetClassList(string idClass, string session, ref string error, dbMain connectData)
        {
            DataTable dt = connectData.ExcuteQuery("SELECT * FROM [GetListOfClass] (" + idClass + ", " + session + ")", ref error);
            if (dt != null)
            {
                dt.Columns.Add("Absent", typeof(bool));
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (CheckAbsent(idClass, session, int.Parse(dt.Rows[i]["IdStudent"].ToString()), connectData))
                        dt.Rows[i]["Absent"] = true;
                    else
                        dt.Rows[i]["Absent"] = false;
                }
                return dt;
            }
            else
            {
                return null;
            }    
        }

        public string GetNameCource (string iDClass, dbMain connectData)
        {
            return (string)connectData.ExcuteScalar("EXEC [GetNameCource] " + iDClass);
        }

        public string GetIDClass (int iDTeacher, string shift, dbMain connectData)
        {
            object id = connectData.ExcuteScalar("EXEC [GetIDClass] " + iDTeacher + ", " + shift);
            if (id != null)
                return ((int)id).ToString();
            else
                return null;
        }

        public bool CheckAbsent(string iDClass, string session, int iDStudent, dbMain connectData)
        {
            int i = (int)connectData.ExcuteScalar("EXEC [CheckAbsent] " + iDClass + ", " + session + ", " + iDStudent);
            if (i == 0)
                return false; //không tồn tại lịch vắng
            return true;
        }

        public string InsertAbsent (List<int> iDStudent, string iDClass, string session, dbMain connectData)
        {
            string err = null;
            connectData.ExcuteNonQuery("EXEC [InsertAbsent] " + iDClass + ", " + session, ref err);
            for (int i = 0; i < iDStudent.Count; i++)
            {
                connectData.ExcuteNonQuery("EXECUTE [AddAbsent] " + iDStudent[i] + ", " + iDClass + ", " + session, ref err);
            }
            return err;
        }
    }
}
