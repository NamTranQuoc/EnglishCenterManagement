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
    public partial class fEmployeeDashboard : Form
    {
        Schedule_UserControl sche;
        public fEmployeeDashboard()
        {
            InitializeComponent();
            sche = new Schedule_UserControl();
            sche.IDUser = 0;
            this.pUserControl.Controls.Add(sche);
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            sche.Show();
        }
    }
}
