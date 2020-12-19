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
        public List<string> GetListDateOfWeek(int IDUser, dbMain connectData) // 0 là nhân viên, admin --- các số còn cái là giáo viên và học viên
        {
            List<string> weeks = new List<string>();
            DateTime date;
            date = (DateTime)connectData.ExcuteScalar("SELECT [dbo].[GetDayMaxOfSchedule](" + IDUser + ")");           
            while (date > DateTime.Today)
            {
                string d = date.AddDays(-5).ToString("dd/MM/yyyy") + " - " + date.AddDays(1).ToString("dd/MM/yyyy");
                weeks.Insert(0, d);
                date = date.AddDays(-7);
            }    
            return weeks;
        }

        //hàm trả về lịch học theo tuần
        public DataTable GetScheduleOfWeek(int IDUser, string week, ref string error, dbMain connectData)
        {
            week = week.Replace(" - ", " ");
            DateTime dateStart, dateEnd;
            string[] dates = week.Split(' ');
            dateStart = DateTime.ParseExact(dates[0], "dd/MM/yyyy", null);
            dateEnd = DateTime.ParseExact(dates[1], "dd/MM/yyyy", null);
            DataTable sche = new DataTable();

            string query = "EXEC [dbo].[GetScheduleOfWeek] " + IDUser.ToString() + ", '" + dateStart.ToString("yyyy-MM-dd") + "', '" + dateEnd.ToString("yyyy-MM-dd") + "'";
            sche = connectData.ExcuteQuery(query, ref error);

            DataTable scheView = new DataTable();
            scheView.Columns.Add("colShift");
            scheView.Columns.Add("colMonday");
            scheView.Columns.Add("colTuesday");
            scheView.Columns.Add("colWednesday");
            scheView.Columns.Add("colThursday");
            scheView.Columns.Add("colFriday");
            scheView.Columns.Add("colSaturday");
            scheView.Columns.Add("colSunday");
            if (sche != null)
            {
                for (int i = 1; i < 7; i++)//từ ca 1 đén ca 6
                {
                    string[] subItem = { i.ToString(), "", "", "", "", "", "", "" };
                    if (IDUser != 0)
                    {
                        for (int j = 0; j < sche.Rows.Count; j++)
                        {
                            if (int.Parse(sche.Rows[j]["Shift"].ToString()) == i)
                            {
                                DateTime d = (DateTime)sche.Rows[j]["Day"];
                                switch (d.DayOfWeek)
                                {
                                    case DayOfWeek.Monday:
                                        subItem[1] += "Lớp: " + sche.Rows[j]["IdClass"] + "\nBuổi thứ: " + sche.Rows[j]["Session"] + "\nPhòng: " + sche.Rows[j]["NameClassRoom"] + "\n\n";
                                        break;
                                    case DayOfWeek.Tuesday:
                                        subItem[2] += "Lớp: " + sche.Rows[j]["IdClass"] + "\nBuổi thứ: " + sche.Rows[j]["Session"] + "\nPhòng: " + sche.Rows[j]["NameClassRoom"] + "\n\n";
                                        break;
                                    case DayOfWeek.Wednesday:
                                        subItem[3] += "Lớp: " + sche.Rows[j]["IdClass"] + "\nBuổi thứ: " + sche.Rows[j]["Session"] + "\nPhòng: " + sche.Rows[j]["NameClassRoom"] + "\n\n";
                                        break;
                                    case DayOfWeek.Thursday:
                                        subItem[4] += "Lớp: " + sche.Rows[j]["IdClass"] + "\nBuổi thứ: " + sche.Rows[j]["Session"] + "\nPhòng: " + sche.Rows[j]["NameClassRoom"] + "\n\n";
                                        break;
                                    case DayOfWeek.Friday:
                                        subItem[5] += "Lớp: " + sche.Rows[j]["IdClass"] + "\nBuổi thứ: " + sche.Rows[j]["Session"] + "\nPhòng: " + sche.Rows[j]["NameClassRoom"] + "\n\n";
                                        break;
                                    case DayOfWeek.Saturday:
                                        subItem[6] += "Lớp: " + sche.Rows[j]["IdClass"] + "\nBuổi thứ: " + sche.Rows[j]["Session"] + "\nPhòng: " + sche.Rows[j]["NameClassRoom"] + "\n\n";
                                        break;
                                    case DayOfWeek.Sunday:
                                        subItem[7] += "Lớp: " + sche.Rows[j]["IdClass"] + "\nBuổi thứ: " + sche.Rows[j]["Session"] + "\nPhòng: " + sche.Rows[j]["NameClassRoom"] + "\n\n";
                                        break;
                                }
                            }
                        }
                    }
                    else
                    {
                        for (int j = 0; j < sche.Rows.Count; j++)
                        {
                            if (int.Parse(sche.Rows[j]["Shift"].ToString()) == i)
                            {
                                DateTime d = (DateTime)sche.Rows[j]["Day"];
                                switch (d.DayOfWeek)
                                {
                                    case DayOfWeek.Monday:
                                        subItem[1] += "Lớp: " + sche.Rows[j]["IdClass"] + "\nBuổi thứ: " + sche.Rows[j]["Session"] + "\nPhòng: " + sche.Rows[j]["NameClassRoom"] + "\nGiáo viên: " + sche.Rows[j]["NameTeacher"] + "\n\n";
                                        break;
                                    case DayOfWeek.Tuesday:
                                        subItem[2] += "Lớp: " + sche.Rows[j]["IdClass"] + "\nBuổi thứ: " + sche.Rows[j]["Session"] + "\nPhòng: " + sche.Rows[j]["NameClassRoom"] + "\nGiáo viên: " + sche.Rows[j]["NameTeacher"] + "\n\n";
                                        break;
                                    case DayOfWeek.Wednesday:
                                        subItem[3] += "Lớp: " + sche.Rows[j]["IdClass"] + "\nBuổi thứ: " + sche.Rows[j]["Session"] + "\nPhòng: " + sche.Rows[j]["NameClassRoom"] + "\nGiáo viên: " + sche.Rows[j]["NameTeacher"] + "\n\n";
                                        break;
                                    case DayOfWeek.Thursday:
                                        subItem[4] += "Lớp: " + sche.Rows[j]["IdClass"] + "\nBuổi thứ: " + sche.Rows[j]["Session"] + "\nPhòng: " + sche.Rows[j]["NameClassRoom"] + "\nGiáo viên: " + sche.Rows[j]["NameTeacher"] + "\n\n";
                                        break;
                                    case DayOfWeek.Friday:
                                        subItem[5] += "Lớp: " + sche.Rows[j]["IdClass"] + "\nBuổi thứ: " + sche.Rows[j]["Session"] + "\nPhòng: " + sche.Rows[j]["NameClassRoom"] + "\nGiáo viên: " + sche.Rows[j]["NameTeacher"] + "\n\n";
                                        break;
                                    case DayOfWeek.Saturday:
                                        subItem[6] += "Lớp: " + sche.Rows[j]["IdClass"] + "\nBuổi thứ: " + sche.Rows[j]["Session"] + "\nPhòng: " + sche.Rows[j]["NameClassRoom"] + "\nGiáo viên: " + sche.Rows[j]["NameTeacher"] + "\n\n";
                                        break;
                                    case DayOfWeek.Sunday:
                                        subItem[7] += "Lớp: " + sche.Rows[j]["IdClass"] + "\nBuổi thứ: " + sche.Rows[j]["Session"] + "\nPhòng: " + sche.Rows[j]["NameClassRoom"] + "\nGiáo viên: " + sche.Rows[j]["NameTeacher"] + "\n\n";
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
            else 
            {
                return null;
            }
        }

        public DataTable GetSchedule(string iDClass, DateTime day, string session, dbMain connectData, bool allDay = false)
        {
            DataTable sche = new DataTable();
            string error = "";
            string all = Convert.ToString(allDay);
            string query = "EXEC [dbo].[GetSchedule] '" + iDClass + "', '" + day.ToString("yyyy-MM-dd") + "', '" + session + "', " + all;
            sche = connectData.ExcuteQuery(query, ref error);

            if (sche != null)
            {
                sche.Columns.Add("Select", typeof(bool));
                for (int i = 0; i < sche.Rows.Count; i++)
                {
                    sche.Rows[i]["Select"] = false;
                }    
            }
            else
            {
                sche.Columns.Add("IdClass");
                sche.Columns.Add("Session");
                sche.Columns.Add("NameClassRoom");
                sche.Columns.Add("Day");
                sche.Columns.Add("NameTeacher");
                sche.Columns.Add("Shift");
                sche.Columns.Add("Select");
            }    
            return sche;
        }

        public DataTable GetListClass(ref string error, dbMain connectData)
        {
            DataTable listClass = new DataTable();
            listClass = connectData.ExcuteQuery("EXEC [dbo].[GetListClassSche]", ref error);     
            listClass.Rows.Add("All");
            return listClass;
        }

        public DataTable GetListSession(string iDClass, ref string error, dbMain connectData)
        {
            try
            {
                DataTable listClass = new DataTable();
                if (iDClass == "All")
                {
                    listClass = new DataTable();
                    listClass.Columns.Add("Session");
                    int s = (int)connectData.ExcuteScalar("EXEC [dbo].[GetListSession] '" + iDClass + "'");
                    for (int i = 1; i <= s; i++)
                    {
                        listClass.Rows.Add(i.ToString());
                    }
                    listClass.Rows.Add("All");
                }
                else
                {
                    listClass = new DataTable();
                    try
                    {
                        listClass = connectData.ExcuteQuery("EXEC [dbo].[GetListSession] '" + iDClass + "'", ref error);
                        listClass.Rows.Add("All");
                    }
                    catch
                    {
                        return null;
                    }
                }
                return listClass;
            }
            catch
            {
                return null;
            }
        }

        public string DeleteSchedule(int iDClass, int session, dbMain connectData)
        {
            string err = null;
            connectData.ExcuteNonQuery("EXEC [dbo].[DeleteSchedule] " + iDClass + ", "+ session, ref err);
            return err;
        }
    }
}
