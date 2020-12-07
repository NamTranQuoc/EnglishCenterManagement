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
using ProjectHQTCSDL.DB_Layer;

namespace ProjectHQTCSDL.Usercontrol
{
    public partial class Reports_UserControl : UserControl
    {
        public dbMain connectData;
        public Reports_UserControl()
        {
            InitializeComponent();
        }
        private void btnStudentsInClass_Click(object sender, EventArgs e)
        {
            rpv.ProcessingMode = ProcessingMode.Local;
            rpv.LocalReport.ReportPath = "../../Usercontrol/RDLC/StudentOfClass.rdlc";
            Reports rp = new Reports();
            string error = "";
            DataTable dt = rp.ReportStudentOfClass(ref error, connectData);
            if (dt != null)
            {
                ReportDataSource rps = new ReportDataSource();
                rps.Name = "StudentOfClass";
                rps.Value = dt;
                this.rpv.LocalReport.DataSources.Clear();
                this.rpv.LocalReport.DataSources.Add(rps);
                this.rpv.RefreshReport();
            }
            else
                MessageBox.Show(error, "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnTeacherOfTheCourse_Click(object sender, EventArgs e)
        {
            rpv.ProcessingMode = ProcessingMode.Local;
            rpv.LocalReport.ReportPath = "../../Usercontrol/RDLC/TeacherOfCource.rdlc";
            Reports rp = new Reports();
            string error = "";
            DataTable dt = rp.ReportTeacherOfCource(ref error, connectData);
            if (dt != null)
            {
                ReportDataSource rps = new ReportDataSource();
                rps.Name = "TeacherOfCource";
                rps.Value = dt;
                this.rpv.LocalReport.DataSources.Clear();
                this.rpv.LocalReport.DataSources.Add(rps);
                this.rpv.RefreshReport();
            }
            else
                MessageBox.Show(error, "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnClassOfCourse_Click(object sender, EventArgs e)
        {
            rpv.ProcessingMode = ProcessingMode.Local;
            rpv.LocalReport.ReportPath = "../../Usercontrol/RDLC/ClassOfCource.rdlc";
            Reports rp = new Reports();
            string error = "";
            DataTable dt = rp.ReportClassOfCourse(ref error, connectData);
            if (dt != null)
            {
                ReportDataSource rps = new ReportDataSource();
                rps.Name = "ClassOfCource";
                rps.Value = dt;
                this.rpv.LocalReport.DataSources.Clear();
                this.rpv.LocalReport.DataSources.Add(rps);
                this.rpv.RefreshReport();
            }
            else
                MessageBox.Show(error, "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnRevenueCenter_Click(object sender, EventArgs e)
        {
            rpv.ProcessingMode = ProcessingMode.Local;
            rpv.LocalReport.ReportPath = "../../Usercontrol/RDLC/SumOfCource.rdlc";
            Reports rp = new Reports();
            string error = "";
            DataTable dt = rp.ReportSumOfCourse(ref error, connectData);
            if (dt != null)
            {
                ReportDataSource rps = new ReportDataSource();
                rps.Name = "SumOfCource";
                rps.Value = dt;
                this.rpv.LocalReport.DataSources.Clear();
                this.rpv.LocalReport.DataSources.Add(rps);
                this.rpv.RefreshReport();
            }
            else
                MessageBox.Show(error, "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
