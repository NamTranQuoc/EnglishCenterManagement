using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectHQTCSDL.DB_Layer;

namespace ProjectHQTCSDL.BS_Layer
{
    public class Teachers
    {
        private static Teachers instance = null;
        public static Teachers Instance
        {
            get { if (instance == null) instance = new Teachers(); return Teachers.instance; }
            private set => instance = value;
        }
        public DataTable GetListTeachers(ref string error, dbMain connectData)
        {
            return connectData.ExcuteQuery("EXEC dbo.GetListTeachers", ref error);
        }

        public DataTable GetListLikeTeacher(string likeName, ref string error, dbMain connectData)
        {
            if (likeName == null || likeName == "")
                return GetListTeachers(ref error, connectData);
            return connectData.ExcuteQuery("EXEC dbo.GetListLikeTeacher " + likeName, ref error);
        }

        public int CreateID(dbMain connectData)
        {
            return (int)connectData.ExcuteScalar("SELECT dbo.TaoMaTuDong('User')");
        }

        public bool InsertTeacher(string userName, string pass, string name, string phoneNumber, string address, int salary, ref string error, dbMain connectData)
        {
            if (userName != null && userName != "")
            {
                int iD = (int)connectData.ExcuteScalar("SELECT dbo.TaoMaTuDong('User')");

                string query = "EXEC dbo.InsertTeacher " + iD + ", '" + userName + "', '" + pass + "', N'" + name + "', '" + phoneNumber + "', N'" + address + "', "+ salary;

                int test = connectData.ExcuteNonQuery(query, ref error);
                if (test > 0)
                    return true;
                return false;
            }
            return false;
        }

        public bool CheckUserName(string userName, dbMain connectData)
        {
            int t = (int)connectData.ExcuteScalar("EXEC dbo.CheckUserName " + userName);
            if (t > 0)
                return false;
            return true;
        }

        public bool UpdateTeacher(int id, string name, string phoneNumber, string address, int salary, string pass, ref string error, dbMain connectData)
        {
            string query = "EXEC dbo.UpdateTeacher " + id + ", N'" + name + "', '" + phoneNumber + "', N'" + address + "', " + salary + ", '" + pass + "'";
            int test = connectData.ExcuteNonQuery(query, ref error);
            if (test > 0)
                return true;
            return false;
        }
    }
}
