using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectHQTCSDL.DB_Layer;

namespace ProjectHQTCSDL.BS_Layer
{
    public class Students
    {
        public bool InsertStudent (string userName, string pass, string name, string phoneNumber, string address, string email, DateTime birthday, ref string error)
        {
            if (userName != null && userName != "")
            {
                int iD = (int)dbMain.Instance.ExcuteScalar("SELECT dbo.TaoMaTuDong('User')");
                int test1 = dbMain.Instance.ExcuteNonQuery("INSERT dbo.Account VALUES  ( " + iD + ", '" + userName + "', '" + pass + "', 4)", ref error);
                int test2 = dbMain.Instance.ExcuteNonQuery("INSERT dbo.HocVien VALUES  ( " + iD + ", N'" + name + "', '" + phoneNumber + "', N'" + address + "', '" + email + "', '" + birthday.ToString("yyyy-MM-dd") + "')", ref error);
                if (test1 > 0 && test2 > 0)
                    return true;
            }
            return false;
        }
    
        public bool CheckUserName (string userName)
        {
            int t = (int)dbMain.Instance.ExcuteScalar("SELECT COUNT(*) FROM dbo.Account WHERE TaiKhoan = '" + userName + "'");
            if (t > 0)
                return false;
            return true;
        }
    }
}
