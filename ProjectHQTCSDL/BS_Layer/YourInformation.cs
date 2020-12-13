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

        public DataTable GetStudent(int idStudent, ref string error, dbMain connectData)
        {
            return connectData.ExcuteQuery("EXEC [dbo].[GetStudent] " + idStudent, ref error);
        }


        public DataTable GetTeacher(int idTeacher, ref string error, dbMain connectData)
        {
            return connectData.ExcuteQuery("EXEC [dbo].[GetTeacher] " + idTeacher, ref error);
        }
    }
}
