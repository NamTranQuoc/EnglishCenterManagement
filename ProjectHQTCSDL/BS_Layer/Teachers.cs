﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectHQTCSDL.DB_Layer;

namespace ProjectHQTCSDL.BS_Layer
{
    public class Teachers
    {
        public DataTable GetListTeachers()
        {
            return dbMain.Instance.ExcuteQuery("SELECT * FROM dbo.GiaoVien");
        }

        public DataTable GetListLikeTeacher(string likeName)
        {
            return dbMain.Instance.ExcuteQuery("SELECT * FROM dbo.GiaoVien WHERE HoTen LIKE '%" + likeName + "%'");
        }

        public int CreateID()
        {
            return (int)dbMain.Instance.ExcuteScalar("SELECT dbo.TaoMaTuDong('User')");
        }

        public bool InsertTeacher(string userName, string pass, string name, string phoneNumber, string address, int salary, ref string error)
        {
            if (userName != null && userName != "")
            {
                int iD = (int)dbMain.Instance.ExcuteScalar("SELECT dbo.TaoMaTuDong('User')");
                int test1 = dbMain.Instance.ExcuteNonQuery("INSERT dbo.Account VALUES  ( " + iD + ", '" + userName + "', '" + pass + "', 4)", ref error);
                int test2 = dbMain.Instance.ExcuteNonQuery("INSERT dbo.GiaoVien VALUES  ( " + iD + ", N'" + name + "', '" + phoneNumber + "', N'" + address + "', " + salary + ")", ref error);
                if (test1 > 0 && test2 > 0)
                    return true;
            }
            return false;
        }

        public bool CheckUserName(string userName)
        {
            int t = (int)dbMain.Instance.ExcuteScalar("SELECT COUNT(*) FROM dbo.Account WHERE TaiKhoan = '" + userName + "'");
            if (t > 0)
                return false;
            return true;
        }

        public bool UpdateTeacher(int id, string name, string phoneNumber, string address, int salary, ref string error)
        {
            int test = dbMain.Instance.ExcuteNonQuery("UPDATE dbo.GiaoVien SET HoTen=N'" + name + "', SDT=" + phoneNumber + ",DiaChi=N'" + address + ",LuongcoBan=" + salary + " WHERE MaHocVien= " + id + "", ref error);
            if (test > 0)
                return true;
            return false;
        }
    }
}
