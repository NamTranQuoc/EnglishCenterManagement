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
            if (type == 0)
                return dbMain.Instance.ExcuteQuery("SELECT * FROM dbo.KhoaHoc");
            if (type == 1)
                return dbMain.Instance.ExcuteQuery("SELECT * FROM dbo.KhoaHoc WHERE TrangThai = 1");
            return dbMain.Instance.ExcuteQuery("SELECT * FROM dbo.KhoaHoc WHERE TrangThai = 0");
        }

        public DataTable GetListLikeCource (int type, string likeName)
        {
            if (type == 0)
                return dbMain.Instance.ExcuteQuery("SELECT * FROM dbo.KhoaHoc WHERE TenKhoaHoc LIKE '%" + likeName + "%'");
            if (type == 1)
                return dbMain.Instance.ExcuteQuery("SELECT * FROM dbo.KhoaHoc WHERE TrangThai = 1 AND  TenKhoaHoc LIKE '%" + likeName + "%'");
            return dbMain.Instance.ExcuteQuery("SELECT * FROM dbo.KhoaHoc WHERE TrangThai = 0 AND  TenKhoaHoc LIKE '%" + likeName + "%'");
        }

        public bool UpdateCource (int iD, string name, int tuition, ref string error)
        {
            int test = dbMain.Instance.ExcuteNonQuery("UPDATE dbo.KhoaHoc SET TenKhoaHoc=N'" + name + "', HocPhi=" + tuition + " WHERE MaKhoaHoc= " + iD + "", ref error);
            if (test > 0)
                return true;
            return false;
        }

        public bool UpdateStatus (int iD, int status, ref string error)
        {
            int test = dbMain.Instance.ExcuteNonQuery("UPDATE dbo.KhoaHoc SET TrangThai = " + status + " WHERE MaKhoaHoc= " + iD + "", ref error);
            if (test > 0)
                return true;
            return false;
        }

        public bool InsertCource (int iD, string name, int no, int tuition, ref string error)
        {
            int test = dbMain.Instance.ExcuteNonQuery("INSERT dbo.KhoaHoc (MaKhoaHoc, TenKhoaHoc, SoBuoi, HocPhi) VALUES  (" + iD + ", N'" + name + "', " + no + ", " + tuition + ")", ref error);
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
