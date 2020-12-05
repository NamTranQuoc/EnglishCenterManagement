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
        public DataTable GetListNameCource()
        {
            return dbMain.Instance.ExcuteQuery("EXEC GetListNameCource"); 
        }

        public DataTable GetListClassOfCource(int id)
        {
            return dbMain.Instance.ExcuteQuery("EXEC dbo.LopTheoKhoaHoc " + id);
        }
    }
}
