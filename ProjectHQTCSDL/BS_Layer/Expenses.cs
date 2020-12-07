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
            string query = "Exec HocVienExpense ";
            return connectData.ExcuteQuery(query, ref error);
        }

        public DataTable GetExpenseByCourse(string nameCourse, ref string error, dbMain connectData)
        {
            string query = "Exec HocVienExpenseByCourse @tenkhoahoc = '" + nameCourse + "'";
            return connectData.ExcuteQuery(query, ref error);
        }

        public bool UpdateExpense(int MaLop, int MaHocVien, string bit, ref string error, dbMain connectData)
        {
            string query = "Exec UpdateExpense @mahocvien = " + MaHocVien + ", @malop = " + MaLop + ", @trangthai = '" + bit + "'";

            int result = connectData.ExcuteNonQuery(query, ref error);

            if (result > 0)
                return true;
            return false;
        }
    }
}
