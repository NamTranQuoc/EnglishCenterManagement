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
        public DataTable GetExpense()
        {
            string query = "Exec HocVienExpense ";
            return dbMain.Instance.ExcuteQuery(query);
        }

        public DataTable GetExpenseByCourse(string nameCourse)
        {
            string query = "Exec HocVienExpenseByCourse @tenkhoahoc = '" + nameCourse + "'";
            return dbMain.Instance.ExcuteQuery(query);
        }

        public bool UpdateExpense(int MaLop, int MaHocVien, string bit, ref string error)
        {
            string query = "Exec UpdateExpense @mahocvien = " + MaHocVien + ", @malop = " + MaLop + ", @trangthai = '" + bit + "'";

            int result = dbMain.Instance.ExcuteNonQuery(query, ref error);

            if (result > 0)
                return true;
            return false;
        }
    }
}
