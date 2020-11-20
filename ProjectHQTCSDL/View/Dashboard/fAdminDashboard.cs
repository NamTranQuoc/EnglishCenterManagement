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
    public partial class fAdminDashboard : Form
    {
        Schedule_UserControl sche;
        Cources_UserControl cou;
        public fAdminDashboard()
        {
            InitializeComponent();
        }

        private void fAdminDashboard_Load(object sender, EventArgs e)
        {
            sche = new Schedule_UserControl();
            sche.IDUser = 0;
            this.pUserControl.Controls.Add(sche);

            cou = new Cources_UserControl();
            this.pUserControl.Controls.Add(cou);
            this.Hide();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            cou.Hide();
            sche.Show();
        }

        private void btnCource_Click(object sender, EventArgs e)
        {
            sche.Hide();
            cou.Show();
        }
    }
}
