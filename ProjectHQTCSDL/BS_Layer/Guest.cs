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
        public DataTable GetListNameCource(ref string error, dbMain connectData)
        {
            return connectData.ExcuteQuery("EXEC GetListNameCource", ref error); 
        }

        public DataTable GetListClassOfCource(int id, ref string error, dbMain connectData)
        {
            return connectData.ExcuteQuery("EXEC dbo.LopTheoKhoaHoc " + id, ref error);
        }
    }
}
