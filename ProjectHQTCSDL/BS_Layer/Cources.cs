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
    }
}
