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
        public DataTable LayHocBu(int theoKhoaHoc, int maLop, int buoiHoc)
        {
            return dbMain.Instance.ExcuteQuery("Select * From LayHocBu(" + theoKhoaHoc + ", " + maLop + ", " + buoiHoc + ")");
        }

        public List<int> LayLopHocHV(int maHocVien)
        {
            List<int> dsLopHoc = new List<int>();
            string sqlString = "EXEC LayLopHocHV " + maHocVien;
            SqlDataReader reader = dbMain.Instance.ExcuteReader(sqlString, CommandType.Text);
            while (reader.Read())
                dsLopHoc.Add(reader.GetInt32(0));
            reader.Dispose();
            return dsLopHoc;
        }

        public int KtraHocBuCoTonTai(int maHocVien, int maLop, int buoi)
        {
            int check = 0;
            string sqlString = "Select dbo.KtraHocBuCoTonTai(" + maHocVien + ", " + maLop + ", " + buoi + ")";
            SqlDataReader reader = dbMain.Instance.ExcuteReader(sqlString, CommandType.Text);
            while (reader.Read())
                check  = reader.GetInt32(0);
            reader.Dispose();
            return check;
        }        

        public void ThemVaCapNhatBuoiHocVang(int maHocVien, int maLop, int buoi, int hocBu)
        {
            string error = "";
            string sqlString = "Execute ThemVaCapNhatHocBu " + maHocVien + ", " + maLop + ", " + buoi + ", " + hocBu;
            dbMain.Instance.ExcuteNonQuery(sqlString, ref error);
        }

        public int LayKhoaLH(int maLopHoc)
        {
            int maKhoaHoc = 0;
            string sqlString = "Select dbo.LayKhoaLH(" + maLopHoc + ")";
            SqlDataReader reader = dbMain.Instance.ExcuteReader(sqlString, CommandType.Text);
            while (reader.Read())
                maKhoaHoc = reader.GetInt32(0);
            reader.Dispose();
            return maKhoaHoc;
        }

        public int SoBuoiHoc(int maLop)
        {
            int soBuoi = 0;
            string sqlString = "Execute SoBuoiHoc "+ maLop;
            SqlDataReader reader = dbMain.Instance.ExcuteReader(sqlString, CommandType.Text);
            while (reader.Read())
                soBuoi = reader.GetInt32(0);
            reader.Dispose();
            return soBuoi;
        }

        public void HuyBoHocBu(int maHocVien, int maLop, int buoiHoc)
        {
            string error = "";
            string sqlString = "Execute HuyBoHocBu " + maHocVien + ", " + maLop + ", " + buoiHoc;
            dbMain.Instance.ExcuteNonQuery(sqlString, ref error);
        }
    }
}
