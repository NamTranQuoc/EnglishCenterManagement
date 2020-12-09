using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectHQTCSDL.DB_Layer;

namespace ProjectHQTCSDL.BS_Layer
{
    public class Students
    {
        private static Students instance = null;
        public static Students Instance
        {
            get { if (instance == null) instance = new Students(); return Students.instance; }
            private set => instance = value;
        }

        public DataTable GetListStudents(ref string error, dbMain connectData)
        {
            return connectData.ExcuteQuery("EXEC dbo.GetListStudents", ref error);
        }

        public DataTable GetListLikeStudent(string likeName, ref string error, dbMain connectData)
        {
            if (likeName == null || likeName == "")
                return GetListStudents(ref error, connectData);
            return connectData.ExcuteQuery("EXEC dbo.GetListLikeStudent " + likeName, ref error);
        }

        public int CreateID(dbMain connectData)
        {
            return (int)connectData.ExcuteScalar("SELECT dbo.TaoMaTuDong('User')");
        }

        public bool InsertStudent (string userName, string pass, string name, string phoneNumber, string address, string email, DateTime birthday, ref string error, dbMain connectData)
        {
            if (userName != null && userName != "")
            {
                int iD = (int)connectData.ExcuteScalar("SELECT dbo.TaoMaTuDong('User')");

                string query = "EXEC dbo.InsertStudent " + iD + ", '" + userName + "', '" + pass + "', N'" + name + "', '" +  phoneNumber + "', N'" + address + "', '" + email + "', '" + birthday.ToString("yyyy-MM-dd") + "'";
                
                int test = dbMain.Instance.ExcuteNonQuery(query, ref error);
                if (test > 0)
                    return true;
                return false;
            }
            return false;
        }
    
        public bool CheckUserName (string userName, dbMain connectData)
        {
            int t = (int)connectData.ExcuteScalar("EXEC dbo.CheckUserName "+ userName);
            if (t > 0)
                return false;
            return true;
        }

        public bool UpdateStudent(int id, string name, string phoneNumber, string address, string email, DateTime birthday, string pass, string passOld, ref string error)
        {
            string query = "EXEC dbo.UpdateStudent " + id + ", N'" + name + "', '" + phoneNumber + "', N'" + address + "', '" + email + "', '" + birthday.ToString("yyyy-MM-dd") + "', '" + pass + "', '" + passOld + "'";
            int test = dbMain.Instance.ExcuteNonQuery(query, ref error);
            if (test > 0)
                return true;
            return false;
        }
    }
}