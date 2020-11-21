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
        public DataTable GetListCources(int type)//0 = lấy All, 1 = 2-4-6, 2 = 3-5-7
        {
            if (type == 0)
                return dbMain.Instance.ExcuteQuery("SELECT * FROM dbo.LopHoc");
            if (type == 1)
                return dbMain.Instance.ExcuteQuery("SELECT * FROM dbo.LopHoc WHERE NgayHocTrongTuan = '2-4-6'");
            return dbMain.Instance.ExcuteQuery("SELECT * FROM dbo.LopHoc WHERE NgayHocTrongTuan = '3-5-7'");
        }
    }
}
