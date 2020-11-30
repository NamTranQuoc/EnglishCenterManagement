using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectHQTCSDL.DB_Layer;

namespace ProjectHQTCSDL.BS_Layer
{
    public class Reports
    {
        public DataTable ReportSumOfCourse()
        {
            return dbMain.Instance.ExcuteQuery("EXECUTE dbo.BaoCaoDoanhThuTheoKhoa");
        }

        public DataTable ReportTeacherOfCource()
        {
            return dbMain.Instance.ExcuteQuery("EXECUTE dbo.BaoCaoGiaoVienThuocKhoaHoc");
        }

        public DataTable ReportClassOfCourse()
        {
            return dbMain.Instance.ExcuteQuery("EXECUTE dbo.BaoCaoLopThuocKhoa");
        }

        public DataTable ReportStudentOfClass()
        {
            return dbMain.Instance.ExcuteQuery("EXECUTE dbo.BaoCaoHocVienThuocLop");
        }
    }
}
