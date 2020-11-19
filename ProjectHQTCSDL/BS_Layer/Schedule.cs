using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectHQTCSDL.DB_Layer;

namespace ProjectHQTCSDL.BS_Layer
{
    public class Schedule
    {
        //hàm trả về danh sách tuần mà có trong lịch
        public List<string> GetListDateOfWeek(int IDUser) // 0 là nhân viên, admin --- các số còn cái là giáo viên và học viên
        {
            List<string> weeks = new List<string>();

            DateTime date = (DateTime)dbMain.Instance.ExcuteScalar("SELECT dbo.NgayLonNhatCuaLichHoc(" + IDUser + ")");
            while (date > DateTime.Today)
            {
                string d = date.AddDays(-5).ToString("dd/MM/yyyy") + " - " + date.AddDays(1).ToString("dd/MM/yyyy");
                weeks.Insert(0, d);
                date = date.AddDays(-7);
            }    
            return weeks;
        }

        //hàm trả về lịch học theo tuần
        public DataTable GetScheduleOfWeek(int IDUser, string week)
        {
            week = week.Replace(" - ", " ");
            DateTime dateStart, dateEnd;
            string[] dates = week.Split(' ');
            dateStart = DateTime.ParseExact(dates[0], "dd/MM/yyyy", null);
            dateEnd = DateTime.ParseExact(dates[1], "dd/MM/yyyy", null);
            DataTable sche = new DataTable();
            if (IDUser != 0)
                sche = dbMain.Instance.ExcuteQuery("SELECT * FROM dbo.Lich_" + IDUser.ToString() + " WHERE NgayHoc >= '" + dateStart.ToString("yyyy-MM-dd") + "' AND NgayHoc <= '" + dateEnd.ToString("yyyy-MM-dd") + "'");
            else
                sche = dbMain.Instance.ExcuteQuery("SELECT * FROM dbo.Lich_ WHERE NgayHoc >= '" + dateStart.ToString("yyyy-MM-dd") + "' AND NgayHoc <= '" + dateEnd.ToString("yyyy-MM-dd") + "'");

            DataTable scheView = new DataTable();
            scheView.Columns.Add("colShift");
            scheView.Columns.Add("colMonday");
            scheView.Columns.Add("colTuesday");
            scheView.Columns.Add("colWednesday");
            scheView.Columns.Add("colThursday");
            scheView.Columns.Add("colFriday");
            scheView.Columns.Add("colSaturday");
            scheView.Columns.Add("colSunday");

            for (int i = 1; i < 7; i++)//từ ca 1 đén ca 6
            {
                string[] subItem = { i.ToString(), "", "", "", "", "", "", "" };
                if (IDUser != 0)
                {
                    for (int j = 0; j < sche.Rows.Count; j++)
                    {
                        if (int.Parse(sche.Rows[j]["CaHoc"].ToString()) == i)
                        {
                            DateTime d = (DateTime)sche.Rows[j]["NgayHoc"];
                            switch (d.DayOfWeek)
                            {
                                case DayOfWeek.Monday:
                                    subItem[1] += "Lớp: " + sche.Rows[j]["MaLop"] + "\nBuổi thứ: " + sche.Rows[j]["Buoi"] + "\nPhòng: " + sche.Rows[j]["TenPhong"] + "\n\n";
                                    break;
                                case DayOfWeek.Tuesday:
                                    subItem[2] += "Lớp: " + sche.Rows[j]["MaLop"] + "\nBuổi thứ: " + sche.Rows[j]["Buoi"] + "\nPhòng: " + sche.Rows[j]["TenPhong"] + "\n\n";
                                    break;
                                case DayOfWeek.Wednesday:
                                    subItem[3] += "Lớp: " + sche.Rows[j]["MaLop"] + "\nBuổi thứ: " + sche.Rows[j]["Buoi"] + "\nPhòng: " + sche.Rows[j]["TenPhong"] + "\n\n";
                                    break;
                                case DayOfWeek.Thursday:
                                    subItem[4] += "Lớp: " + sche.Rows[j]["MaLop"] + "\nBuổi thứ: " + sche.Rows[j]["Buoi"] + "\nPhòng: " + sche.Rows[j]["TenPhong"] + "\n\n";
                                    break;
                                case DayOfWeek.Friday:
                                    subItem[5] += "Lớp: " + sche.Rows[j]["MaLop"] + "\nBuổi thứ: " + sche.Rows[j]["Buoi"] + "\nPhòng: " + sche.Rows[j]["TenPhong"] + "\n\n";
                                    break;
                                case DayOfWeek.Saturday:
                                    subItem[6] += "Lớp: " + sche.Rows[j]["MaLop"] + "\nBuổi thứ: " + sche.Rows[j]["Buoi"] + "\nPhòng: " + sche.Rows[j]["TenPhong"] + "\n\n";
                                    break;
                                case DayOfWeek.Sunday:
                                    subItem[7] += "Lớp: " + sche.Rows[j]["MaLop"] + "\nBuổi thứ: " + sche.Rows[j]["Buoi"] + "\nPhòng: " + sche.Rows[j]["TenPhong"] + "\n\n";
                                    break;
                            }
                        }
                    }    
                } 
                else
                {
                    for (int j = 0; j < sche.Rows.Count; j++)
                    {
                        if (int.Parse(sche.Rows[j]["CaHoc"].ToString()) == i)
                        {
                            DateTime d = (DateTime)sche.Rows[j]["NgayHoc"];
                            switch (d.DayOfWeek)
                            {
                                case DayOfWeek.Monday:
                                    subItem[1] += "Lớp: " + sche.Rows[j]["MaLop"] + "\nBuổi thứ: " + sche.Rows[j]["Buoi"] + "\nPhòng: " + sche.Rows[j]["TenPhong"] + "\nGiáo viên: " + sche.Rows[j]["HoTen"] + "\n\n";
                                    break;
                                case DayOfWeek.Tuesday:
                                    subItem[2] += "Lớp: " + sche.Rows[j]["MaLop"] + "\nBuổi thứ: " + sche.Rows[j]["Buoi"] + "\nPhòng: " + sche.Rows[j]["TenPhong"] + "\nGiáo viên: " + sche.Rows[j]["HoTen"] + "\n\n";
                                    break;
                                case DayOfWeek.Wednesday:
                                    subItem[3] += "Lớp: " + sche.Rows[j]["MaLop"] + "\nBuổi thứ: " + sche.Rows[j]["Buoi"] + "\nPhòng: " + sche.Rows[j]["TenPhong"] + "\nGiáo viên: " + sche.Rows[j]["HoTen"] + "\n\n";
                                    break;
                                case DayOfWeek.Thursday:
                                    subItem[4] += "Lớp: " + sche.Rows[j]["MaLop"] + "\nBuổi thứ: " + sche.Rows[j]["Buoi"] + "\nPhòng: " + sche.Rows[j]["TenPhong"] + "\nGiáo viên: " + sche.Rows[j]["HoTen"] + "\n\n";
                                    break;
                                case DayOfWeek.Friday:
                                    subItem[5] += "Lớp: " + sche.Rows[j]["MaLop"] + "\nBuổi thứ: " + sche.Rows[j]["Buoi"] + "\nPhòng: " + sche.Rows[j]["TenPhong"] + "\nGiáo viên: " + sche.Rows[j]["HoTen"] + "\n\n";
                                    break;
                                case DayOfWeek.Saturday:
                                    subItem[6] += "Lớp: " + sche.Rows[j]["MaLop"] + "\nBuổi thứ: " + sche.Rows[j]["Buoi"] + "\nPhòng: " + sche.Rows[j]["TenPhong"] + "\nGiáo viên: " + sche.Rows[j]["HoTen"] + "\n\n";
                                    break;
                                case DayOfWeek.Sunday:
                                    subItem[7] += "Lớp: " + sche.Rows[j]["MaLop"] + "\nBuổi thứ: " + sche.Rows[j]["Buoi"] + "\nPhòng: " + sche.Rows[j]["TenPhong"] + "\nGiáo viên: " + sche.Rows[j]["HoTen"] + "\n\n";
                                    break;
                            }
                        }
                    }
                }   
                
                for (int j = 1; j < 8; j++)//từ subItem thứ 1 đến subItem 7 (thứ 2 đến chủ nhật)
                {
                    if (subItem[j].Length > 2)
                        subItem[j] = subItem[j].Substring(0, subItem[j].Length - 2);
                }
                scheView.Rows.Add(subItem);
            }    

            return scheView;
        }
    }
}
