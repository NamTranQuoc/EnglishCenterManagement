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
        Students_UserControl stu;
        Teachers_UserControl tea;
        Classes_UserControl cla;
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

            stu = new Students_UserControl();
            this.pUserControl.Controls.Add(stu);
            this.Hide();

            tea = new Teachers_UserControl();
            this.pUserControl.Controls.Add(tea);
            this.Hide();

            cla = new Classes_UserControl();
            this.pUserControl.Controls.Add(cla);
            this.Hide();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            cou.Hide();
            stu.Hide();
            sche.Show();
            tea.Hide();
            cla.Hide();
        }

        private void btnCource_Click(object sender, EventArgs e)
        {
            sche.Hide();
            cou.Show();
            stu.Hide();
            tea.Hide();
            cla.Hide();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            sche.Hide();
            stu.Show();
            cou.Hide();
            tea.Hide();
            cla.Hide();
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            sche.Hide();
            stu.Hide();
            cou.Hide();
            tea.Show();
            cla.Hide();
        }

        private void btnClass_Click(object sender, EventArgs e)
        {
            sche.Hide();
            stu.Hide();
            cou.Hide();
            tea.Hide();
            cla.Show();
        }
    }
}
