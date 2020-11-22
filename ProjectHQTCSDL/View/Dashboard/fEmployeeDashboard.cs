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

        Students_UserControl stu;
        Teachers_UserControl tea;
        Classes_UserControl cla;
        public fEmployeeDashboard()
        {
            InitializeComponent();
            sche = new Schedule_UserControl();
            sche.IDUser = 0;
            this.pUserControl.Controls.Add(sche);
        }
        private void fEmployeeDashboard_Load(object sender, EventArgs e)
        {
            sche.Show();
            sche = new Schedule_UserControl();
            sche.IDUser = 0;
            this.pUserControl.Controls.Add(sche);
            this.Hide();

            stu = new Students_UserControl();
            this.pUserControl.Controls.Add(stu);
            this.Hide();

            tea = new Teachers_UserControl();
            this.pUserControl.Controls.Add(stu);
            this.Hide();

            cla = new Classes_UserControl();
            this.pUserControl.Controls.Add(cla);
            this.Hide();
        }
        private void btnSchedule_Click(object sender, EventArgs e)
        {
            sche.Show();
            stu.Hide();
            tea.Hide();
            cla.Hide();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            sche.Hide();
            stu.Show();
            tea.Hide();
            cla.Hide();
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            sche.Hide();
            stu.Hide();
            tea.Show();
            cla.Hide();
        }

        private void btnClass_Click(object sender, EventArgs e)
        {
            sche.Hide();
            stu.Hide();
            tea.Hide();
            cla.Show();
        }
    }
}
