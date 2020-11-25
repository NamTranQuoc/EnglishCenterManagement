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

namespace ProjectHQTCSDL.Usercontrol
{
    public partial class Students_UserControl : UserControl
    {
        Students student;
        public Students_UserControl()
        {
            InitializeComponent();
            student = new Students();
        }

        private void Students_UserControl_Load(object sender, EventArgs e)
        {
            this.dgvListStudents.DataSource = student.GetListStudents();
            this.txtIDNew.Text = student.CreateID().ToString();
        }

        private void dgvListStudents_RowEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvListStudents.Rows[e.RowIndex];
            txtID.Text = row.Cells[0].Value.ToString();
            txtName.Text = row.Cells[1].Value.ToString();
            txtPhone.Text = row.Cells[2].Value.ToString();
            txtAddress.Text = row.Cells[3].Value.ToString();
            txtEmail.Text = row.Cells[4].Value.ToString();
            dtpDOB.Value = (DateTime)row.Cells[5].Value;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text != null && txtName.Text != "" && txtPhone.Text != null && txtPhone.Text != "" && txtAddress.Text != null && txtAddress.Text != "" && txtEmail.Text != null && txtEmail.Text != "")
            {
                int phone;
                bool tphone = int.TryParse(txtPhone.Text, out phone);
                DateTime birthday = (DateTime)dtpDOB.Value;
                if (tphone != false)
                {
                    string error = "";
                    bool t = student.UpdateStudent(int.Parse(txtID.Text), txtName.Text, txtPhone.Text, txtAddress.Text, txtEmail.Text, birthday, ref error);
                    if (t == true)
                    {
                        this.dgvListStudents.DataSource = student.GetListStudents();
                        MessageBox.Show("Update successful", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show(error, "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Please enter a number for Phone Number", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Please fill out all information", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text != null && txtName.Text != "" && txtPhone.Text != null && txtPhone.Text != "" && txtAddress.Text != null && txtAddress.Text != "" && txtEmail.Text != null && txtEmail.Text != "")
            {
                DateTime birthday = (DateTime)dtpDOB.Value;
                string pass = "000000";
                int phone;
                bool tphone = int.TryParse(txtPhoneNew.Text, out phone);
                if (tphone != false)
                {
                    string error = "";
                    bool t = student.InsertStudent(txtUsername.Text, pass, txtNameNew.Text, txtPhoneNew.Text, txtAddressNew.Text, txtEmailNew.Text, birthday, ref error);
                    if (t == true)
                    {
                        this.dgvListStudents.DataSource = student.GetListStudents();
                        txtIDNew.Text = student.CreateID().ToString();
                        txtNameNew.ResetText();
                        txtUsername.ResetText();
                        txtPhoneNew.ResetText();
                        txtAddressNew.ResetText();
                        txtEmailNew.ResetText();
                        txtDOBNew.ResetText();
                        MessageBox.Show("Insert successful", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Usename Existed", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Please enter a number for Phone Number", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Please fill out all information", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            this.dgvListStudents.DataSource = student.GetListLikeStudent(txtSearch.Text);
        }
    }
}
