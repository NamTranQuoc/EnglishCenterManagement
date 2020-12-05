using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectHQTCSDL.DB_Layer;

namespace ProjectHQTCSDL.BS_Layer
{
    public class Login_Signup
    {
        public int CheckLogin(string user, string pass)//kiểm tra đăng nhập
        {
            return (int)dbMain.Instance.ExcuteScalar("SELECT dbo.KienTraDangNhap('" + user + "', '" + pass + "')");
        }
        public int GetID(string user)
        {
            return (int)dbMain.Instance.ExcuteScalar("EXEC LayID '" + user + "'");
        }
    }
}
