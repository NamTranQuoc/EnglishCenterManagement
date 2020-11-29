using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectHQTCSDL.Report.Teacher;

namespace ProjectHQTCSDL.Usercontrol
{
    public partial class Reports_Teacher_UserControl : UserControl
    {
        public Reports_Teacher_UserControl()
        {
            InitializeComponent();
        }

        private void btnTeacherOfTheCourse_Click(object sender, EventArgs e)
        {
            TeacherOfTheCourse TOTC = new TeacherOfTheCourse();
            TOTC.Show();
        }
    }
}
