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
        public DataTable GetListClasses(int type, ref string error, dbMain connectData)//0 = lấy All, 1 = 2-4-6, 2 = 3-5-7
        {
            return connectData.ExcuteQuery("EXEC GetListClasses " + type, ref error);
        }

        public DataTable GetListLikeClasses(int type, string likeName, ref string error, dbMain connectData)
        {
            return connectData.ExcuteQuery("EXEC GetListLikeClasses " + type + ", '" + likeName + "'", ref error);
        }

        public bool UpdateClasses(int iD, int number, ref string error, dbMain connectData)
        {
            int test = connectData.ExcuteNonQuery("EXEC UpdateClasses " + iD + ", " + number, ref error);
            if (test > 0)
                return true;
            return false;
        }

        public bool InsertClass(int iD, int number, int shift, string DOW, int course, ref string error, dbMain connectData)
        {
            int test = connectData.ExcuteNonQuery("EXEC InsertClass " + iD + ", " + number + ", " + shift + ", '" + DOW + "', " + course, ref error);
            if (test > 0)
                return true;
            return false;
        }

        public int CreateID(dbMain connectData)
        {
            return (int)connectData.ExcuteScalar("SELECT dbo.TaoMaTuDong('LopHoc')");
        }

        public string GetNameCource(string ID, dbMain connectData)
        {
            return (string)connectData.ExcuteScalar("EXEC GetNameCource_ " + ID);
        }

        public DataTable GetListCource(ref string error, dbMain connectData)
        {
            return connectData.ExcuteQuery("EXEC GetListCource", ref error);
        }
    }
}
