using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectHQTCSDL.DB_Layer;

namespace ProjectHQTCSDL.BS_Layer
{
    public class Reports
    {
        public DataTable ReportSumOfCourse(ref string error, dbMain connectData)
        {
            return connectData.ExcuteQuery("EXECUTE [dbo].[ReportFlollowCourse]", ref error);
        }

        public DataTable ReportTeacherOfCource(ref string error, dbMain connectData)
        {
            return connectData.ExcuteQuery("EXECUTE [dbo].[ReportTeacherOfCourse]", ref error);
        }

        public DataTable ReportClassOfCourse(ref string error, dbMain connectData)
        {
            return connectData.ExcuteQuery("EXECUTE [dbo].[ReportClassOfCourse]", ref error);
        }

        public DataTable ReportStudentOfClass(ref string error, dbMain connectData)
        {
            return connectData.ExcuteQuery("EXECUTE [dbo].[ReportStudentOfClass]", ref error);
        }
    }
}
