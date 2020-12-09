using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectHQTCSDL.BS_Layer;
using ProjectHQTCSDL.DB_Layer;
using ProjectHQTCSDL.Usercontrol;

namespace ProjectHQTCSDL.View.Dashboard
{
    public partial class fTeacherDashboard : Form
    {
        public int IDUser;
        Schedule_UserControl sche;
        Attendance_UserControl att;
        YourInformation_UserControl infor;
        public string passOld;
        public string TaiKhoan;

        public dbMain connectData;

        public fTeacherDashboard()
        {
            InitializeComponent();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            if (infor.f == true)
                this.Close();
            sche.Show();
            att.Hide();
            infor.Hide();
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            if (infor.f == true)
                this.Close();
            sche.Hide();
            att.Show();
            infor.Hide();
        }

        private void fTeacherDashboard_Load(object sender, EventArgs e)
        {
            infor = new YourInformation_UserControl();
            infor.passOld = this.passOld;
            infor.TaiKhoan = this.TaiKhoan;
            infor.connectData = this.connectData;
            infor.IDTaiKhoan = IDUser;
            infor.state = false;
            pUserControl.Controls.Add(infor);
            infor.Hide();

            sche = new Schedule_UserControl();
            sche.connectData = this.connectData;
            sche.IDUser = IDUser;
            pUserControl.Controls.Add(sche);

            att = new Attendance_UserControl();
            att.connectData = this.connectData;
            att.IDTeacher = IDUser;
            pUserControl.Controls.Add(att);
            att.Hide();  
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            if (infor.f == true)
                this.Close();
            sche.Hide();
            att.Hide();
            infor.Show();
        }
    }
}
