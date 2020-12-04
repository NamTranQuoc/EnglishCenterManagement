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
        public DataTable GetListCources (int type)//0 = lấy All, 1 = Lấy có sẳn, 2 = lấy đã ẩn
        {
            return dbMain.Instance.ExcuteQuery("EXEC GetListCources " + type);
        }

        public DataTable GetListLikeCource (int type, string likeName)
        {
            return dbMain.Instance.ExcuteQuery("EXEC GetListLikeCource " + type + ", '" + likeName + "'");
        }

        public bool UpdateCource (int iD, string name, int tuition, int no, ref string error)
        {
            int test = dbMain.Instance.ExcuteNonQuery("EXEC UpdateCource " + iD + ", N'" + name + "', " + tuition + ", " + no, ref error);
            if (test > 0)
                return true;
            return false;
        }

        public bool UpdateStatus (int iD, int status, ref string error)
        {
            int test = dbMain.Instance.ExcuteNonQuery("EXEC UpdateStatusCource " + iD + ", " + status, ref error);
            if (test > 0)
                return true;
            return false;
        }

        public bool InsertCource (int iD, string name, int no, int tuition, ref string error)
        {
            int test = dbMain.Instance.ExcuteNonQuery("EXEC InsertCource " + iD + ", N'" + name + "', " + no + ", " + tuition, ref error);
            if (test > 0)
                return true;
            return false;
        }

        public int CreateID()
        {
            return (int)dbMain.Instance.ExcuteScalar("SELECT dbo.TaoMaTuDong('KhoaHoc')");
        }
    }
}
