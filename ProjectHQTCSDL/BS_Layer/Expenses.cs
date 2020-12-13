using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectHQTCSDL.DB_Layer;

namespace ProjectHQTCSDL.BS_Layer
{
    public class Expenses
    {
        public DataTable GetExpense(ref string error, dbMain connectData)
        {
            string query = "Exec [StudentExpense] ";
            return connectData.ExcuteQuery(query, ref error);
        }

        public DataTable GetExpenseByCourse(string nameCourse, ref string error, dbMain connectData)
        {
            string query = "Exec [StudentExpenseByCourse] '" + nameCourse + "'";
            return connectData.ExcuteQuery(query, ref error);
        }

        public bool UpdateExpense(int idClass, int idStudent, string bit, ref string error, dbMain connectData)
        {
            string query = "Exec [UpdateExpense] " + idStudent + ", " + idClass + ", '" + bit + "'";

            int result = connectData.ExcuteNonQuery(query, ref error);

            if (result > 0)
                return true;
            return false;
        }
    }
}
