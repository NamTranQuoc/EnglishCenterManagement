using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectHQTCSDL.DB_Layer;

namespace ProjectHQTCSDL.BS_Layer
{
    public class Guest
    {
        public DataTable LayLopToeic()
        { 
            return dbMain.Instance.ExcuteQuery("Select MaLop, SoHocVienDuKien, CaHoc, NgayHocTrongTuan From LopHoc Where ThuocKhoaHoc=1");
        }

        public DataTable LayLopIelts()
        {
            return dbMain.Instance.ExcuteQuery("Select MaLop, SoHocVienDuKien, CaHoc, NgayHocTrongTuan From LopHoc Where ThuocKhoaHoc=2");
        }

        public DataTable LayLopCommunication()
        {
            return dbMain.Instance.ExcuteQuery("Select MaLop, SoHocVienDuKien, CaHoc, NgayHocTrongTuan From LopHoc Where ThuocKhoaHoc=3");
        }

        public DataTable LayLopBasic()
        {
            return dbMain.Instance.ExcuteQuery("Select MaLop, SoHocVienDuKien, CaHoc, NgayHocTrongTuan From LopHoc Where ThuocKhoaHoc=4");
        }
    }
}
