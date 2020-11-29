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

namespace ProjectHQTCSDL.Usercontrol
{
    public partial class Reports_UserControl : UserControl
    {
        Reports_Student_UserControl reportStudent;
        Reports_Teacher_UserControl reportTeacher;
        Reports_Employees_UserControl reportEmployee;
        public Reports_UserControl()
        {
            InitializeComponent();
            reportStudent = new Reports_Student_UserControl();
            reportTeacher = new Reports_Teacher_UserControl();
            reportEmployee = new Reports_Employees_UserControl();

            this.Title_UserControl.Controls.Add(reportStudent);
            this.Title_UserControl.Controls.Add(reportTeacher);
            this.Title_UserControl.Controls.Add(reportEmployee);

            reportTeacher.Visible = false;
            reportEmployee.Visible = false;
            reportStudent.Visible = true;
            reportStudent.BringToFront();
        }

        private void btnStudentReport_Click(object sender, EventArgs e)
        {
            reportStudent.Visible = true;
            reportStudent.BringToFront();

            reportTeacher.Visible = false;
            reportEmployee.Visible = false;
        }

        private void btnEmployeeReport_Click(object sender, EventArgs e)
        {
            reportEmployee.Visible = true;
            reportEmployee.BringToFront();

            reportStudent.Visible = false;
            reportTeacher.Visible = false;
        }

        private void btnTeacherReport_Click(object sender, EventArgs e)
        {
            reportTeacher.Visible = true;
            reportTeacher.BringToFront();

            reportStudent.Visible = false;
            reportEmployee.Visible = false;
        }
    }
}
