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
using ProjectHQTCSDL.View.Login;
using ProjectHQTCSDL.Usercontrol;

namespace ProjectHQTCSDL.View.Dashboard
{
    public partial class fGuestDashboard : Form
    {
        Guest_UserControl GUC;
        public fGuestDashboard()
        {
            InitializeComponent();
            GUC = new Guest_UserControl();

            this.pUserControl.Controls.Add(GUC);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            fLogin log = new fLogin();
            log.ShowDialog();
        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            GUC.loai = "TOEIC";
            GUC.Load_Data();
        }

        private void btnIelts_Click(object sender, EventArgs e)
        {
            GUC.loai = "IELTS";
            GUC.Load_Data();
        }

        private void btnCommunication_Click(object sender, EventArgs e)
        {
            GUC.loai = "COMMUNICATION";
            GUC.Load_Data();
        }

        private void btnBasic_Click(object sender, EventArgs e)
        {
            GUC.loai = "BASIC";
            GUC.Load_Data();
        }

        private void fGuestDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
