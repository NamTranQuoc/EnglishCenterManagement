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
        public fStudentDashboard()
        {
            InitializeComponent();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            Schedule_UserControl sche = new Schedule_UserControl();
            sche.IDUser = IDUser;
            this.pUserControl.Controls.Add(sche);

        }
        private void btnInformation_Click(object sender, EventArgs e)
        {
            YourInformation_UserControl info = new YourInformation_UserControl();
            info.IDUser = IDUser;
            this.pUserControl.Controls.Add(info);
        }
    }
}
