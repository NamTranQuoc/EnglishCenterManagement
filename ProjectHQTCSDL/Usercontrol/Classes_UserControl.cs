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
    public partial class Classes_UserControl : UserControl
    {
        Classes cla;
        public Classes_UserControl()
        {
            InitializeComponent();
            cla = new Classes();
        }
        private void Classes_UserControl_Load(object sender, EventArgs e)
        {
            this.dgvListClasses.DataSource = cla.GetListClasses(0);
            this.txtIDNew.Text = cla.CreateID().ToString();
            this.cmbCourseIDNew.DataSource = cla.GetListCource();
            this.cmbCourseIDNew.DisplayMember = "MaKhoaHoc";
        }

        private void rbtAll_CheckedChanged(object sender, EventArgs e)
        {
            this.dgvListClasses.DataSource = cla.GetListClasses(0);
        }

        private void rbtEven_CheckedChanged(object sender, EventArgs e)
        {
            this.dgvListClasses.DataSource = cla.GetListClasses(1);
        }

        private void rbtOdd_CheckedChanged(object sender, EventArgs e)
        {
            this.dgvListClasses.DataSource = cla.GetListClasses(2);
        }

        private void dgvListClasses_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvListClasses.Rows[e.RowIndex];
            txtID.Text = row.Cells[0].Value.ToString();
            nmrStudents.Value = Convert.ToDecimal(row.Cells[1].Value);
            nmrShift.Value = Convert.ToDecimal(row.Cells[2].Value);
            cbbDayOfWeek.Text = row.Cells[3].Value.ToString();
            txtCourceID.Text = cla.GetNameCource(row.Cells[4].Value.ToString());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (nmrStudents.Value > 20)
            {
                string error = "";
                bool t = cla.UpdateClasses(int.Parse(txtID.Text), Convert.ToInt32(nmrStudents.Value), ref error);
                if (t == true)
                {
                    if (rbtAll.Checked == true)
                        this.dgvListClasses.DataSource = cla.GetListClasses(0);
                    else if (rbtEven.Checked == true)
                        this.dgvListClasses.DataSource = cla.GetListClasses(1);
                    else
                        this.dgvListClasses.DataSource = cla.GetListClasses(2);
                    MessageBox.Show("Update successful", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show(error, "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Please fill out all information", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (nmrStudentsNew.Value > 20 && nmrShiftNew.Value > 0 && cmbCourseIDNew.Text != null && cmbCourseIDNew.Text != "" && cmbDOWNew.Text != "" && cmbDOWNew.Text != null)
            {
                string error = "";
                bool t = cla.InsertClass(int.Parse(txtIDNew.Text), Convert.ToInt32(nmrStudentsNew.Value), Convert.ToInt32(nmrShiftNew.Value), cmbDOWNew.Text, Convert.ToInt32(cmbCourseIDNew.Text), ref error);
                if (t == true)
                {
                    if (rbtAll.Checked == true)
                        this.dgvListClasses.DataSource = cla.GetListClasses(0);
                    else if (rbtEven.Checked == true)
                        this.dgvListClasses.DataSource = cla.GetListClasses(1);
                    else
                        this.dgvListClasses.DataSource = cla.GetListClasses(2);
                    txtIDNew.Text = cla.CreateID().ToString();
                    nmrStudentsNew.ResetText();
                    nmrShiftNew.ResetText();
                    cmbCourseIDNew.ResetText();
                    cmbDOWNew.ResetText();
                    MessageBox.Show("Insert successful", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Error", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Please fill out all information", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (rbtAll.Checked == true)
                this.dgvListClasses.DataSource = cla.GetListLikeClasses(0, txtSearch.Text);
            else if (rbtEven.Checked == true)
                this.dgvListClasses.DataSource = cla.GetListLikeClasses(1, txtSearch.Text);
            else
                this.dgvListClasses.DataSource = cla.GetListLikeClasses(2, txtSearch.Text);

        }
    }
}
