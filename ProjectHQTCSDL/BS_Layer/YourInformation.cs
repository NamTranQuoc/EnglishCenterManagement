using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectHQTCSDL.DB_Layer;

namespace ProjectHQTCSDL.BS_Layer
{
    public class YourInformation
    {

        public DataTable GetHocVien(int MaHocVien, ref string error, dbMain connectData)
        {
            return connectData.ExcuteQuery("EXEC dbo.GetHocVien " + MaHocVien, ref error);
        }


        public DataTable GetGiaoVien(int MaGiaoVien, ref string error, dbMain connectData)
        {
            return connectData.ExcuteQuery("EXEC dbo.GetGiaoVien " + MaGiaoVien, ref error);
        }
    }
}
