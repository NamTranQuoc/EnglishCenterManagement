using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectHQTCSDL.Report.Student;

namespace ProjectHQTCSDL.Usercontrol
{
    public partial class Reports_Student_UserControl : UserControl
    {
        public Reports_Student_UserControl()
        {
            InitializeComponent();
        }

        private void btnStudentInClass_Click(object sender, EventArgs e)
        {
            StudentInClass SIC = new StudentInClass();
            SIC.Show();
        }
    }
}
