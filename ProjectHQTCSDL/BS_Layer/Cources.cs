using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectHQTCSDL.DB_Layer;

namespace ProjectHQTCSDL.BS_Layer
{
    public class Cources
    {
        public DataTable GetListCources (int type, ref string error, dbMain connectData)//0 = lấy All, 1 = Lấy có sẳn, 2 = lấy đã ẩn
        {
            return connectData.ExcuteQuery("EXEC GetListCources " + type, ref error);
        }

        public DataTable GetListLikeCource (int type, string likeName, ref string error, dbMain connectData)
        {
            return connectData.ExcuteQuery("EXEC GetListLikeCource " + type + ", '" + likeName + "'", ref error);
        }

        public bool UpdateCource (int iD, string name, int tuition, int no, ref string error, dbMain connectData)
        {
            int test = connectData.ExcuteNonQuery("EXEC UpdateCource " + iD + ", N'" + name + "', " + tuition + ", " + no, ref error);
            if (test > 0)
                return true;
            return false;
        }

        public bool UpdateStatus (int iD, int status, ref string error, dbMain connectData)
        {
            int test = connectData.ExcuteNonQuery("EXEC UpdateStatusCource " + iD + ", " + status, ref error);
            if (test > 0)
                return true;
            return false;
        }

        public bool InsertCource (int iD, string name, int no, int tuition, ref string error, dbMain connectData)
        {
            int test = connectData.ExcuteNonQuery("EXEC InsertCource " + iD + ", N'" + name + "', " + no + ", " + tuition, ref error);
            if (test > 0)
                return true;
            return false;
        }

        public int CreateID(dbMain connectData)
        {
            return (int)connectData.ExcuteScalar("SELECT dbo.TaoMaTuDong('KhoaHoc')");
        }
    }
}
