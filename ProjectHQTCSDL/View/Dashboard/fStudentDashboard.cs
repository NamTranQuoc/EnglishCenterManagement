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
using ProjectHQTCSDL.Usercontrol;

namespace ProjectHQTCSDL.View.Dashboard
{
    public partial class fStudentDashboard : Form
    {
        public int IDUser;
        Schedule_UserControl sche;
        YourInformation_UserControl infor;
        public fStudentDashboard()
        {
            InitializeComponent();
            sche = new Schedule_UserControl();
            sche.IDUser = IDUser;
            this.pUserControl.Controls.Add(sche);
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            sche.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            sche.Hide();

            infor = new YourInformation_UserControl();
            infor.IDTaiKhoan = IDUser;
            infor.state = true;

            this.pUserControl.Controls.Add(infor);
        }
    }
}
