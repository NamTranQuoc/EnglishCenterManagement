﻿using System;
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
using ProjectHQTCSDL.View.Dashboard;

namespace ProjectHQTCSDL.View.Login
{
    public partial class fLogin : Form
    {
        Login_Signup log;

        public dbMain connectData;
        public fLogin()
        {
            InitializeComponent();
            log = new Login_Signup();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int TypeUser = log.CheckLogin(txtUserName.Text, txtPassword.Text, connectData);
            switch (TypeUser)
            {
                case 1:
                    fAdminDashboard f1 = new fAdminDashboard();
                    f1.connectData = new dbMain(txtUserName.Text, txtPassword.Text);
                    f1.ShowDialog();
                    this.Close();
                    break;
                case 3:
                    fTeacherDashboard f3 = new fTeacherDashboard();
                    f3.passOld = txtPassword.Text;
                    f3.TaiKhoan = txtUserName.Text;
                    f3.IDUser = log.GetID(txtUserName.Text, connectData);
                    f3.connectData = new dbMain(txtUserName.Text, txtPassword.Text);
                    f3.ShowDialog();
                    this.Close();
                    break;
                case 4:
                    fStudentDashboard f4 = new fStudentDashboard();
                    f4.passOld = txtPassword.Text;
                    f4.TaiKhoan = txtUserName.Text;
                    f4.IDUser = log.GetID(txtUserName.Text.Trim(), connectData);
                    f4.connectData = new dbMain(txtUserName.Text, txtPassword.Text);
                    f4.ShowDialog();
                    this.Close();
                    break;
                default:
                    this.lbIncorrect.Show();
                    break;
            }
        }

        private void fLogin_Load(object sender, EventArgs e)
        {
            this.lbIncorrect.Hide();
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.lbIncorrect.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llbForgetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Contact staff to be able to retrieve your password instead", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void llbRegisterForStudent_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fSignUp sign = new fSignUp();
            sign.connectData = this.connectData;
            sign.ShowDialog();
            txtUserName.Text = sign.UserName;
            txtPassword.Text = sign.Password;
        }
    }
}
