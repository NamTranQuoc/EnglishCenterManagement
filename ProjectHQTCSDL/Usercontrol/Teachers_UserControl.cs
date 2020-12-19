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

namespace ProjectHQTCSDL.Usercontrol
{
    public partial class Teachers_UserControl : UserControl
    {
        Teachers teacher;
        public dbMain connectData;
        public Teachers_UserControl()
        {
            InitializeComponent();
            teacher = new Teachers();
        }

        private void Teachers_UserControl_Load(object sender, EventArgs e)
        {
            string error = "";
            DataTable dt = teacher.GetListTeachers(ref error, connectData);
            if (dt != null)
            {
                this.dgvListTeachers.DataSource = dt;
                this.txtIDNew.Text = teacher.CreateID(connectData).ToString();
            }
            else
                MessageBox.Show(error, "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dgvListTeachers_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvListTeachers.Rows[e.RowIndex];
            txtID.Text = row.Cells[0].Value.ToString();
            txtName.Text = row.Cells[1].Value.ToString();
            txtPhone.Text = row.Cells[2].Value.ToString();
            txtAddress.Text = row.Cells[3].Value.ToString();
            txtSalary.Text = row.Cells[4].Value.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text != null && txtName.Text != "" && txtPhone.Text != null && txtPhone.Text != "" && txtAddress.Text != null && txtAddress.Text != "" && txtSalary.Text != null && txtSalary.Text != "")
            {
                int salary;
                bool tsalary = int.TryParse(txtSalary.Text, out salary);
                int phone;
                bool tphone = int.TryParse(txtPhoneNew.Text, out phone);
                if (tsalary != false && tsalary != false)
                {
                    string error = "";
                    bool t = teacher.UpdateTeacher(int.Parse(txtID.Text), txtName.Text, txtPhone.Text, txtAddress.Text, salary, "0", "0", ref error);
                    if (t == true)
                    {
                        DataTable dtt = teacher.GetListTeachers(ref error, connectData);
                        if (dtt != null)
                        {
                            this.dgvListTeachers.DataSource = dtt;
                            MessageBox.Show("Update successful", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show(error, "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MessageBox.Show(error, "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Please enter a number for Salary and Phone Number", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Please fill out all information", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtNameNew.Text != null && txtNameNew.Text != "" && txtPhoneNew.Text != null && txtPhoneNew.Text != "" && txtAddressNew.Text != null && txtAddressNew.Text != "" && txtSalaryNew.Text != null && txtSalaryNew.Text != "")
            {
                int salary;
                bool tsalary = int.TryParse(txtSalaryNew.Text, out salary);
                int phone;
                bool tphone = int.TryParse(txtPhoneNew.Text, out phone);
                string pass = "000000";
                if (tphone != false && tsalary != false)
                {
                    string error = "";
                    bool t = teacher.InsertTeacher(txtUsername.Text, pass, txtNameNew.Text, txtPhoneNew.Text, txtAddressNew.Text, salary, ref error, dbMain.Instance);
                    if (t == true)
                    {
                        DataTable dt = teacher.GetListTeachers(ref error, connectData);
                        if (dt != null)
                        {
                            this.dgvListTeachers.DataSource = dt;
                            txtIDNew.Text = teacher.CreateID(connectData).ToString();
                            txtNameNew.ResetText();
                            txtUsername.ResetText();
                            txtPhoneNew.ResetText();
                            txtNameNew.ResetText();
                            txtAddressNew.ResetText();
                            txtSalaryNew.ResetText();
                            MessageBox.Show("Insert successful", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show(error, "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MessageBox.Show(error, "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Please enter a number for Phone Number and Salary", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Please fill out all information", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string error = "";
            DataTable dt = teacher.GetListLikeTeacher(txtSearch.Text, ref error, connectData);
            if (dt != null)
            {
                this.dgvListTeachers.DataSource = dt;
            }
            else
                MessageBox.Show(error, "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnResetPass_Click(object sender, EventArgs e)
        {
            int salary;
            bool tsalary = int.TryParse(txtSalary.Text, out salary);
            string error = "";
            bool t = teacher.UpdateTeacher(int.Parse(txtID.Text), txtName.Text, txtPhone.Text, txtAddress.Text, salary, "000000", "0", ref error);
            if (t == true)
            {
                DataTable dt = teacher.GetListTeachers(ref error, connectData);
                if (dt != null)
                {
                    this.dgvListTeachers.DataSource = dt;
                    MessageBox.Show("Reset password success\nPassword: 000000", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show(error, "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show(error, "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
