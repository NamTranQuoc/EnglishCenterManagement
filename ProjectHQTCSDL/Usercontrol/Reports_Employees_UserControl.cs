using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectHQTCSDL.Report.Admin;

namespace ProjectHQTCSDL.Usercontrol
{
    public partial class Reports_Employees_UserControl : UserControl
    {
        public Reports_Employees_UserControl()
        {
            InitializeComponent();
        }

        private void btnClassOfCourse_Click(object sender, EventArgs e)
        {
            ClassOfCourse COC = new ClassOfCourse();
            COC.Show();
        }

        private void Reports_Employees_UserControl_Load(object sender, EventArgs e)
        {
  
        }

        private void btnRevenueCenter_Click(object sender, EventArgs e)
        {
            Revenue RVN = new Revenue();
            RVN.Show();
        }
    }
}
