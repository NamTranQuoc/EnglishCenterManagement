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
using Microsoft.Reporting.WinForms;

namespace ProjectHQTCSDL.Usercontrol
{
    public partial class Reports_UserControl : UserControl
    {
        public Reports_UserControl()
        {
            InitializeComponent();
        }
        private void btnStudentsInClass_Click(object sender, EventArgs e)
        {
            rpv.ProcessingMode = ProcessingMode.Local;
            rpv.LocalReport.ReportPath = "../../Usercontrol/RDLC/StudentOfClass.rdlc";
            Reports rp = new Reports();
            DataTable dt = rp.ReportStudentOfClass();
            ReportDataSource rps = new ReportDataSource();
            rps.Name = "StudentOfClass";
            rps.Value = dt;
            this.rpv.LocalReport.DataSources.Clear();
            this.rpv.LocalReport.DataSources.Add(rps);
            this.rpv.RefreshReport();
        }

        private void btnTeacherOfTheCourse_Click(object sender, EventArgs e)
        {
            rpv.ProcessingMode = ProcessingMode.Local;
            rpv.LocalReport.ReportPath = "../../Usercontrol/RDLC/TeacherOfCource.rdlc";
            Reports rp = new Reports();
            DataTable dt = rp.ReportTeacherOfCource();
            ReportDataSource rps = new ReportDataSource();
            rps.Name = "TeacherOfCource";
            rps.Value = dt;
            this.rpv.LocalReport.DataSources.Clear();
            this.rpv.LocalReport.DataSources.Add(rps);
            this.rpv.RefreshReport();
        }

        private void btnClassOfCourse_Click(object sender, EventArgs e)
        {
            rpv.ProcessingMode = ProcessingMode.Local;
            rpv.LocalReport.ReportPath = "../../Usercontrol/RDLC/ClassOfCource.rdlc";
            Reports rp = new Reports();
            DataTable dt = rp.ReportClassOfCourse();
            ReportDataSource rps = new ReportDataSource();
            rps.Name = "ClassOfCource";
            rps.Value = dt;
            this.rpv.LocalReport.DataSources.Clear();
            this.rpv.LocalReport.DataSources.Add(rps);
            this.rpv.RefreshReport();
        }

        private void btnRevenueCenter_Click(object sender, EventArgs e)
        {
            rpv.ProcessingMode = ProcessingMode.Local;
            rpv.LocalReport.ReportPath = "../../Usercontrol/RDLC/SumOfCource.rdlc";
            Reports rp = new Reports();
            DataTable dt = rp.ReportSumOfCourse();
            ReportDataSource rps = new ReportDataSource();
            rps.Name = "SumOfCource";
            rps.Value = dt;
            this.rpv.LocalReport.DataSources.Clear();
            this.rpv.LocalReport.DataSources.Add(rps);
            this.rpv.RefreshReport();
        }
    }
}
