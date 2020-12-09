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
    public partial class fStudentDashboard : Form
    {
        public int IDUser;
        Schedule_UserControl sche;
        MakeUpClass_UserControl MUC_UC;
        YourInformation_UserControl infor;
        EnrollInClass_UserControl enr;
        public dbMain connectData;
        public string passOld;
        public string TaiKhoan;
        public fStudentDashboard()
        {  
            InitializeComponent();           
        }

        private void fStudentDashboard_Load(object sender, EventArgs e)
        {
            sche = new Schedule_UserControl();
            MUC_UC = new MakeUpClass_UserControl();
            enr = new EnrollInClass_UserControl();
            infor = new YourInformation_UserControl();

            sche.connectData = this.connectData;
            MUC_UC.connectData = this.connectData;
            enr.connectData = this.connectData;
            infor.connectData = this.connectData;
            infor.passOld = this.passOld;
            infor.TaiKhoan = this.TaiKhoan;

            this.sche.IDUser = IDUser;
            this.infor.IDTaiKhoan = IDUser;
            this.infor.state = true;
            this.enr.iDStudent = this.IDUser;
            this.MUC_UC.maHocVien = this.IDUser;

            this.pUserControl.Controls.Add(sche);
            this.pUserControl.Controls.Add(MUC_UC);
            this.pUserControl.Controls.Add(infor);
            this.pUserControl.Controls.Add(enr);

            enr.Hide();
            MUC_UC.Hide();
            infor.Hide();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            if (infor.f == true)
                this.Close();
            enr.Hide();
            if (enr.f == true)
                sche.LoadccbView();
            sche.Show();
            infor.Hide();
            MUC_UC.Hide();
        }

        private void btnMakeUpClass_Click(object sender, EventArgs e)
        {
            if (infor.f == true)
                this.Close();
            enr.Hide();
            sche.Hide();
            infor.Hide();
            MUC_UC.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            if (infor.f == true)
                this.Close();
            enr.Hide();
            sche.Hide();
            infor.Show();
            MUC_UC.Hide();
        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            if (infor.f == true)
                this.Close();
            enr.f = false;
            enr.Show();
            sche.Hide();
            infor.Hide();
            MUC_UC.Hide();
        }
    }
}
