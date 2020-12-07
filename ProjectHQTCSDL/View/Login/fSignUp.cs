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

namespace ProjectHQTCSDL.View.Login
{
    public partial class fSignUp : Form
    {
        Students stu;
        public string UserName;
        public string Password;

        public dbMain connectData;

        public fSignUp()
        {
            InitializeComponent();
            UserName = "";
            Password = "";
            stu = new Students();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == txtPasswordAgain.Text)
            {
                if (stu.CheckUserName(txtUserName.Text, connectData))
                {
                    string error = "";
                    if (stu.InsertStudent(txtUserName.Text, txtPassword.Text, txtName.Text, txtPhoneNumber.Text, txtAddress.Text, txtEmail.Text, dtpBirthday.Value, ref error, connectData))
                    {
                        MessageBox.Show("Account successfully created", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        UserName = txtUserName.Text;
                        Password = txtPassword.Text;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Account creation failed.\n" + error , "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    MessageBox.Show("Same User name", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Wrong password authentication", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
