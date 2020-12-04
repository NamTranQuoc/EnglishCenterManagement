using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectHQTCSDL.DB_Layer;

namespace ProjectHQTCSDL.BS_Layer
{
    public class Classes
    {
        public DataTable GetListClasses(int type)//0 = lấy All, 1 = 2-4-6, 2 = 3-5-7
        {
            return dbMain.Instance.ExcuteQuery("EXEC GetListClasses " + type);
        }

        public DataTable GetListLikeClasses(int type, string likeName)
        {
            return dbMain.Instance.ExcuteQuery("EXEC GetListLikeClasses " + type + ", '" + likeName + "'");
        }

        public bool UpdateClasses(int iD, int number, ref string error)
        {
            int test = dbMain.Instance.ExcuteNonQuery("EXEC UpdateClasses " + iD + ", " + number, ref error);
            if (test > 0)
                return true;
            return false;
        }

        public bool InsertClass(int iD, int number, int shift, string DOW, int course, ref string error)
        {
            int test = dbMain.Instance.ExcuteNonQuery("EXEC InsertClass " + iD + ", " + number + ", " + shift + ", '" + DOW + "', " + course, ref error);
            if (test > 0)
                return true;
            return false;
        }

        public int CreateID()
        {
            return (int)dbMain.Instance.ExcuteScalar("SELECT dbo.TaoMaTuDong('LopHoc')");
        }

        public string GetNameCource(string ID)
        {
            return (string)dbMain.Instance.ExcuteScalar("EXEC GetNameCource_ " + ID);
        }

        public DataTable GetListCource()
        {
            return dbMain.Instance.ExcuteQuery("EXEC GetListCource");
        }
    }
}
