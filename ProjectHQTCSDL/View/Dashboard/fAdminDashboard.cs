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
    public partial class fAdminDashboard : Form
    {
        Schedule_UserControl sche;
        Cources_UserControl cou;
        Students_UserControl stu;
        Teachers_UserControl tea;
        Classes_UserControl cla;
        DeleteSchedule_UserControl del;
        Expenses_UserControl exp;
        Reports_UserControl rep;

        public dbMain connectData;
        public fAdminDashboard()
        {
            InitializeComponent();
        }

        private void fAdminDashboard_Load(object sender, EventArgs e)
        {
            sche = new Schedule_UserControl();
            sche.IDUser = 0;
            sche.connectData = this.connectData;
            this.pUserControl.Controls.Add(sche);

            cou = new Cources_UserControl();
            cou.connectData = this.connectData;
            this.pUserControl.Controls.Add(cou);
            this.Hide();

            stu = new Students_UserControl();
            stu.connectData = this.connectData;
            this.pUserControl.Controls.Add(stu);
            this.Hide();

            tea = new Teachers_UserControl();
            tea.connectData = this.connectData;
            this.pUserControl.Controls.Add(tea);
            this.Hide();

            cla = new Classes_UserControl();
            cla.connectData = this.connectData;
            this.pUserControl.Controls.Add(cla);
            this.Hide();

            del = new DeleteSchedule_UserControl();
            del.connectData = this.connectData;
            this.pUserControl.Controls.Add(del);
            this.Hide();

            exp = new Expenses_UserControl();
            exp.connectData = this.connectData;
            this.pUserControl.Controls.Add(exp);
            this.Hide();

            rep = new Reports_UserControl();
            rep.connectData = this.connectData;
            this.pUserControl.Controls.Add(rep);
            this.Hide();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            exp.Hide();
            cou.Hide();
            stu.Hide();
            if (cou.f == true || del.f == true)
                sche.LoadccbView();
            sche.Show();
            tea.Hide();
            cla.Hide();
            del.Hide();
            rep.Hide();
        }

        private void btnCource_Click(object sender, EventArgs e)
        {
            exp.Hide();
            sche.Hide();
            cou.f = false;//biến cờ để kiểm việc thay đổi của khóa học, nếu có thay đổi thì load lại lịch
            cou.Show();
            stu.Hide();
            tea.Hide();
            cla.Hide();
            del.Hide();
            rep.Hide();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            stu.txtIDNew.Text = Students.Instance.CreateID(connectData).ToString();
            exp.Hide();
            sche.Hide();
            stu.Show();
            cou.Hide();
            tea.Hide();
            cla.Hide();
            del.Hide();
            rep.Hide();
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            tea.txtIDNew.Text = Teachers.Instance.CreateID(connectData).ToString();
            exp.Hide();
            sche.Hide();
            stu.Hide();
            cou.Hide();
            tea.Show();
            cla.Hide();
            del.Hide();
            rep.Hide();
        }

        private void btnClass_Click(object sender, EventArgs e)
        {
            exp.Hide();
            sche.Hide();
            stu.Hide();
            cou.Hide();
            tea.Hide();
            cla.Show();
            del.Hide();
            rep.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelSchedule_Click(object sender, EventArgs e)
        {
            exp.Hide();
            sche.Hide();            
            cou.Hide();
            stu.Hide();
            tea.Hide();
            cla.Hide();
            del.f = false;
            del.Show();
            rep.Hide();
        }

        private void btnExpenses_Click(object sender, EventArgs e)
        {
            sche.Hide();
            cou.Hide();
            stu.Hide();
            tea.Hide();
            cla.Hide();
            del.Hide();
            exp.Show();
            rep.Hide();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            sche.Hide();
            cou.Hide();
            stu.Hide();
            tea.Hide();
            cla.Hide();
            del.Hide();
            exp.Hide();
            rep.Show();
        }
    }
}
