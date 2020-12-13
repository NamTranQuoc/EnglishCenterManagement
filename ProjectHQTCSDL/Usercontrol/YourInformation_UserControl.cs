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
using System.Data.SqlClient;
using ProjectHQTCSDL.DB_Layer;

namespace ProjectHQTCSDL.Usercontrol
{
    public partial class YourInformation_UserControl : UserControl
    {
        public int IdAccount;
        public bool state = true; // true -- hiện Hoc Vien , false -- Giao vien
        public dbMain connectData;
        public string passOld;
        public string userName;
        public bool f = false;

        private bool update = false;
        private YourInformation infor;
        public YourInformation_UserControl()
        {
            InitializeComponent();
            infor = new YourInformation();
        }

        private void YourInformation_UserControl_Load(object sender, EventArgs e)
        {
            if( state == true)
            {
                this.pnlStudent.Show();
                this.pnlTeacher.Hide();

                this.pnlStudent.Location = new Point(390, 211);

                GetInfoStudent();

                txtName.Enabled = false;
                txtPhoneNumber.Enabled = false;
                txtAddress.Enabled = false;
                txtEmail.Enabled = false;
                dtpDOB.Enabled = false;
                txtPass.Enabled = false;
            }
            else
            {
                this.pnlTeacher.Show();
                this.pnlStudent.Hide();
                this.pnlTeacher.Location = new Point(390, 211);

                GetInfoTeacher();

                txtNameTea.Enabled = false;
                txtPhoneNumberTea.Enabled = false;
                txtAddressTea.Enabled = false;
                txtSalaryTea.Enabled = false;
                txtPassTea.Enabled = false;
            }

            btnUpdate.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
        }

        private DataTable table;
        private void GetInfoStudent()
        {
            try
            {
                string error = "";
                table = infor.GetStudent(IdAccount, ref error, connectData);
                if (table != null)
                {
                    txtPass.Text = "000000";
                    txtName.Text = table.Rows[0]["FullName"].ToString();
                    txtPhoneNumber.Text = table.Rows[0]["PhoneNumber"].ToString();
                    txtAddress.Text = table.Rows[0]["Address"].ToString();
                    txtEmail.Text = table.Rows[0]["Email"].ToString();
                    dtpDOB.Value = (DateTime)table.Rows[0]["DOB"];
                }
                else
                {
                    MessageBox.Show(error, "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Error", "Warning Load Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void GetInfoTeacher()
        {
            try
            {
                string error = "";
                table = infor.GetTeacher(IdAccount, ref error, connectData);
                if (table != null)
                {
                    txtPassTea.Text = "000000";
                    txtNameTea.Text = table.Rows[0]["NameTeacher"].ToString();
                    txtPhoneNumberTea.Text = table.Rows[0]["PhoneNumber"].ToString();
                    txtAddressTea.Text = table.Rows[0]["Address"].ToString();
                    txtSalaryTea.Text = table.Rows[0]["Salary"].ToString();
                }
                else
                {
                    MessageBox.Show(error, "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Error", "Warning Load Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (state == true)
            {
                txtName.Enabled = true;
                txtPhoneNumber.Enabled = true;
                txtAddress.Enabled = true;
                txtEmail.Enabled = true;
                dtpDOB.Enabled = true;
                txtPass.Enabled = true;
            }
            else
            {
                txtNameTea.Enabled = true;
                txtPhoneNumberTea.Enabled = true;
                txtAddressTea.Enabled = true;
                txtPassTea.Enabled = true;
            }

            btnUpdate.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            update = true;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(state == true)
            {
                txtName.Enabled = false;
                txtPhoneNumber.Enabled = false;
                txtAddress.Enabled = false;
                txtEmail.Enabled = false;
                dtpDOB.Enabled = false;
                txtPass.Enabled = false;
                txtPass.UseSystemPasswordChar = true;
                GetInfoStudent();
            }
            else
            {
                txtNameTea.Enabled = false;
                txtPhoneNumberTea.Enabled = false;
                txtAddressTea.Enabled = false;
                txtSalaryTea.Enabled = false;
                txtPassTea.Enabled = false;
                txtPassTea.UseSystemPasswordChar = true;

                GetInfoTeacher();
            }

            btnUpdate.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;

            update = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(update == true)
            {
                string text = "Would you like to update your information ?";
                DialogResult result = MessageBox.Show(text, "Update infor", MessageBoxButtons.YesNo , MessageBoxIcon.Question);

                if( result == DialogResult.Yes)
                {
                    Excute();
                    MessageBox.Show("Sign in again to continue", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.f = true;

                    btnUpdate.Enabled = true;
                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;

                    update = false;
                }
            }      
        }


        private void Excute()
        {
            int id = IdAccount;

            string error = "Not excute";
            bool result;
            if (state == true)
            {
                connectData = new dbMain(userName, txtPass.Text);
                Students stu = new Students();
                
                string name = txtName.Text.Trim();
                string phone = txtPhoneNumber.Text.Trim();
                string address = txtAddress.Text.Trim();
                string email = txtEmail.Text.Trim();
                DateTime birthdate = dtpDOB.Value;

                result = stu.UpdateStudent(id, name, phone, address, email, birthdate, txtPass.Text.Trim(), passOld, ref error);

                if (result)
                {
                    MessageBox.Show("Update successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Update unsuccessfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


                txtName.Enabled = false;
                txtPhoneNumber.Enabled = false;
                txtAddress.Enabled = false;
                txtEmail.Enabled = false;
                dtpDOB.Enabled = false;
                txtPass.Enabled = false;
                txtPass.UseSystemPasswordChar = true;

                GetInfoStudent();
            }
            else
            {
                connectData = new dbMain(userName, txtPassTea.Text);
                Teachers teacher = new Teachers();

                string name = txtNameTea.Text.Trim();
                string phone = txtPhoneNumberTea.Text.Trim();
                string address = txtAddressTea.Text.Trim();

                int luong = Convert.ToInt32(txtSalaryTea.Text.Trim());

                result = teacher.UpdateTeacher(id, name, phone, address, luong, txtPassTea.Text.Trim(), passOld, ref error);

                if (result)
                {
                    MessageBox.Show("Update successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Update unsuccessfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                txtNameTea.Enabled = false;
                txtPhoneNumberTea.Enabled = false;
                txtAddressTea.Enabled = false;
                txtSalaryTea.Enabled = false;
                txtPassTea.Enabled = false;
                txtPassTea.UseSystemPasswordChar = true;

                GetInfoTeacher();
            }
            
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            if (txtPass.UseSystemPasswordChar)
            {
                txtPass.ResetText();
                txtPass.UseSystemPasswordChar = false;
            }    
        }

        private void txtPassGV_TextChanged(object sender, EventArgs e)
        {
            if (txtPassTea.UseSystemPasswordChar)
            {
                txtPassTea.ResetText();
                txtPassTea.UseSystemPasswordChar = false;
            }
        }
    }
}
