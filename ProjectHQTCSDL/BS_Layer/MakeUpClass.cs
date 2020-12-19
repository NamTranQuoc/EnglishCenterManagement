using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectHQTCSDL.DB_Layer;

namespace ProjectHQTCSDL.BS_Layer
{
    public class MakeUpClass
    {
        public DataTable GetListClassAbsent (int IdStudent, dbMain connectData, ref string error)
        {
            return connectData.ExcuteQuery("EXEC [GetListClassAbsent] " + IdStudent, ref error);
        }

        public DataTable GetListSessionAbsent (int IdStudent, int iDClass, dbMain connectData, ref string error)
        {
            return connectData.ExcuteQuery("EXEC [GetListSessionAbsent] " + IdStudent + ", " + iDClass, ref error);
        }

        public DataTable GetClassAbsent(int iDStudent, int iDClass, int session, dbMain connectData, ref string error)
        {
            DataTable dt = connectData.ExcuteQuery("EXEC [GetClassAbsent] " + iDClass + ", " + session, ref error);
            if (dt != null)
            {
                dt.Columns.Add("Select", typeof(bool));
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if ((int)connectData.ExcuteScalar("EXEC [CheckAbsent] " + iDStudent + ", " + iDClass + ", " + session) == 0)
                        dt.Rows[i]["Select"] = false;
                    else
                        dt.Rows[i]["Select"] = true;
                }
                return dt;
            }
            return null;
        }

        public bool EnrollAbsent (int iDStudent, int iDClass, int session, int absent, dbMain connectData, ref string error)
        {
            int test = connectData.ExcuteNonQuery("EXEC [EnrollAbsent] " + iDStudent + ", " + iDClass + ", " + session + ", " + absent, ref error);
            if (test > 0)
                return true;
            return false;
        }
        public bool UnenrollAbsent(int iDStudent, int iDClass, int session, dbMain connectData, ref string error)
        {
            int test = connectData.ExcuteNonQuery("EXEC [UnenrollAbsent] " + iDStudent + ", " + iDClass + ", " + session, ref error);
            if (test > 0)
                return true;
            return false;
        }
    }
}
