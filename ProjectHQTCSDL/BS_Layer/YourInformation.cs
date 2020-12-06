﻿using System;
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

        public DataTable GetHocVien(int MaHocVien)
        {
            return dbMain.Instance.ExcuteQuery("EXEC dbo.GetHocVien " + MaHocVien);
        }


        public DataTable GetGiaoVien(int MaGiaoVien)
        {
            return dbMain.Instance.ExcuteQuery("EXEC dbo.GetGiaoVien " + MaGiaoVien);
        }
    }
}
