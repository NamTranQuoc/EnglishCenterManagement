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
        MakeUpClass_UserControl MUC_UC;

        public fStudentDashboard()
        {
            InitializeComponent();
            sche = new Schedule_UserControl();
            MUC_UC = new MakeUpClass_UserControl();

            sche.IDUser = IDUser;
       //     MUC_UC.maHocVien = IDUser;

            this.pUserControl.Controls.Add(sche);
            this.pUserControl.Controls.Add(MUC_UC);

            this.sche.Visible = false;
            this.MUC_UC.Visible = false;
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.pUserControl.Controls)
            {
                ctrl.Visible = false;
            }

            this.sche.Visible = true;
            this.sche.BringToFront();
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.pUserControl.Controls)
            {
                ctrl.Visible = false;
            }
            this.MUC_UC.maHocVien = IDUser;

            this.MUC_UC.Visible = true;
            this.MUC_UC.BringToFront();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
