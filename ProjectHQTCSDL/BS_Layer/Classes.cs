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
            if (type == 0)
                return dbMain.Instance.ExcuteQuery("SELECT * FROM dbo.LopHoc");
            if (type == 1)
                return dbMain.Instance.ExcuteQuery("SELECT * FROM dbo.LopHoc WHERE NgayHocTrongTuan = '2-4-6'");
            return dbMain.Instance.ExcuteQuery("SELECT * FROM dbo.LopHoc WHERE NgayHocTrongTuan = '3-5-7'");
        }

        public DataTable GetListLikeClasses(int type, string likeName)
        {
            if (type == 0)
                return dbMain.Instance.ExcuteQuery("SELECT * FROM dbo.LopHoc WHERE ThuocKhoaHoc LIKE '%" + likeName + "%'");
            if (type == 1)
                return dbMain.Instance.ExcuteQuery("SELECT * FROM dbo.LopHoc WHERE NgayHocTrongTuan = '2-4-6' AND  ThuocKhoaHoc LIKE '%" + likeName + "%'");
            return dbMain.Instance.ExcuteQuery("SELECT * FROM dbo.LopHoc WHERE NgayHocTrongTuan = '3-5-7' AND  ThuocKhoaHoc LIKE '%" + likeName + "%'");
        }

        public bool UpdateClasses(int iD, int number, int shift,string DOW, int course, ref string error)
        {
            int test = dbMain.Instance.ExcuteNonQuery("UPDATE dbo.LopHoc SET SoHocVienDuKien=" + number + ", CaHoc=" + shift + ", NgayHocTrongTuan=" + DOW + ", ThuocKhoaHoc=" + course + " WHERE MaLop= " + iD + "", ref error);
            if (test > 0)
                return true;
            return false;
        }

        public bool InsertClass(int iD, int number, int shift, string DOW, int course, ref string error)
        {
            int test = dbMain.Instance.ExcuteNonQuery("INSERT dbo.LopHoc (MaLop ,SoHocVienDuKien,CaHoc,NgayHocTrongTuan,ThuocKhoaHoc) VALUES  (" + iD + ", " + number + ", " + shift + ", '" + DOW + "')", ref error);
            if (test > 0)
                return true;
            return false;
        }

        public int CreateID()
        {
            return (int)dbMain.Instance.ExcuteScalar("SELECT dbo.TaoMaTuDong('LopHoc')");
        }
    }
}
