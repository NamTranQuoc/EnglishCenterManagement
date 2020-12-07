using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectHQTCSDL.DB_Layer;

namespace ProjectHQTCSDL.BS_Layer
{
    public class MakeUpClass
    {
        public DataTable LayHocBu(int theoKhoaHoc, int maLop, int buoiHoc, ref string error, dbMain connectData)
        {
            return connectData.ExcuteQuery("Select * From LayHocBu(" + theoKhoaHoc + ", " + maLop + ", " + buoiHoc + ")", ref error);
        }

        public List<int> LayLopHocHV(int maHocVien, dbMain connectData)
        {
            List<int> dsLopHoc = new List<int>();
            string sqlString = "EXEC LayLopHocHV " + maHocVien;
            SqlDataReader reader = connectData.ExcuteReader(sqlString, CommandType.Text);
            while (reader.Read())
                dsLopHoc.Add(reader.GetInt32(0));
            reader.Dispose();
            return dsLopHoc;
        }

        public int KtraHocBuCoTonTai(int maHocVien, int maLop, int buoi, dbMain connectData)
        {
            int check = 0;
            string sqlString = "Select dbo.KtraHocBuCoTonTai(" + maHocVien + ", " + maLop + ", " + buoi + ")";
            SqlDataReader reader = connectData.ExcuteReader(sqlString, CommandType.Text);
            while (reader.Read())
                check  = reader.GetInt32(0);
            reader.Dispose();
            return check;
        }        

        public void ThemVaCapNhatBuoiHocVang(int maHocVien, int maLop, int buoi, int hocBu, dbMain connectData)
        {
            string error = "";
            string sqlString = "Execute ThemVaCapNhatHocBu " + maHocVien + ", " + maLop + ", " + buoi + ", " + hocBu;
            connectData.ExcuteNonQuery(sqlString, ref error);
        }

        public int LayKhoaLH(int maLopHoc, dbMain connectData)
        {
            int maKhoaHoc = 0;
            string sqlString = "Select dbo.LayKhoaLH(" + maLopHoc + ")";
            SqlDataReader reader = connectData.ExcuteReader(sqlString, CommandType.Text);
            while (reader.Read())
                maKhoaHoc = reader.GetInt32(0);
            reader.Dispose();
            return maKhoaHoc;
        }

        public int SoBuoiHoc(int maLop, dbMain connectData)
        {
            int soBuoi = 0;
            string sqlString = "Execute SoBuoiHoc "+ maLop;
            SqlDataReader reader = connectData.ExcuteReader(sqlString, CommandType.Text);
            while (reader.Read())
                soBuoi = reader.GetInt32(0);
            reader.Dispose();
            return soBuoi;
        }

        public void HuyBoHocBu(int maHocVien, int maLop, int buoiHoc, dbMain connectData)
        {
            string error = "";
            string sqlString = "Execute HuyBoHocBu " + maHocVien + ", " + maLop + ", " + buoiHoc;
            connectData.ExcuteNonQuery(sqlString, ref error);
        }
    }
}
