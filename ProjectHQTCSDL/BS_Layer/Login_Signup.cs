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
        public int CheckLogin(string user, string pass, dbMain connectData)//kiểm tra đăng nhập
        {
            return (int)connectData.ExcuteScalar("SELECT dbo.KienTraDangNhap('" + user + "', '" + pass + "')");
        }
        public int GetID(string user, dbMain connectData)
        {
            return (int)connectData.ExcuteScalar("EXEC LayID '" + user + "'");
        }
    }
}
