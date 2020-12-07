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
    public partial class Classes_UserControl : UserControl
    {
        public dbMain connectData;
        Classes cla;
        public Classes_UserControl()
        {
            InitializeComponent();
            cla = new Classes();
        }
        private void Classes_UserControl_Load(object sender, EventArgs e)
        {
            string error = "";
            DataTable dt1 = cla.GetListClasses(0, ref error, connectData);
            if (dt1 != null)
            {
                this.dgvListClasses.DataSource = dt1;
                this.txtIDNew.Text = cla.CreateID(connectData).ToString();
            }
            else
                MessageBox.Show(error, "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
            DataTable dt2 = cla.GetListCource(ref error, connectData);
            if (dt2 != null)
            {
                this.cmbCourseIDNew.DataSource = dt2;
                this.cmbCourseIDNew.DisplayMember = "MaKhoaHoc";
            }
            else
                MessageBox.Show(error, "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void rbtAll_CheckedChanged(object sender, EventArgs e)
        {
            string error = "";
            DataTable dt = cla.GetListClasses(0, ref error, connectData);
            if (dt != null)
                this.dgvListClasses.DataSource = dt;
            else
                MessageBox.Show(error, "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void rbtEven_CheckedChanged(object sender, EventArgs e)
        {
            string error = "";
            DataTable dt = cla.GetListClasses(1, ref error, connectData);
            if (dt != null)
                this.dgvListClasses.DataSource = dt;
            else
                MessageBox.Show(error, "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void rbtOdd_CheckedChanged(object sender, EventArgs e)
        {
            string error = "";
            DataTable dt = cla.GetListClasses(2, ref error, connectData);
            if (dt != null)
                this.dgvListClasses.DataSource = dt;
            else
                MessageBox.Show(error, "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dgvListClasses_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvListClasses.Rows[e.RowIndex];
            txtID.Text = row.Cells[0].Value.ToString();
            nmrStudents.Value = Convert.ToDecimal(row.Cells[1].Value);
            nmrShift.Value = Convert.ToDecimal(row.Cells[2].Value);
            cbbDayOfWeek.Text = row.Cells[3].Value.ToString();
            txtCourceID.Text = cla.GetNameCource(row.Cells[4].Value.ToString(), connectData);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (nmrStudents.Value > 20)
            {
                string error = "";
                bool t = cla.UpdateClasses(int.Parse(txtID.Text), Convert.ToInt32(nmrStudents.Value), ref error, connectData);
                if (t == true)
                {
                    this.GetListClasses();
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
                bool t = cla.InsertClass(int.Parse(txtIDNew.Text), Convert.ToInt32(nmrStudentsNew.Value), Convert.ToInt32(nmrShiftNew.Value), cmbDOWNew.Text, Convert.ToInt32(cmbCourseIDNew.Text), ref error, connectData);
                if (t == true)
                {
                    this.GetListClasses();
                    txtIDNew.Text = cla.CreateID(connectData).ToString();
                    nmrStudentsNew.ResetText();
                    nmrShiftNew.ResetText();
                    cmbCourseIDNew.ResetText();
                    cmbDOWNew.ResetText();
                    MessageBox.Show("Insert successful", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show(error, "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Please fill out all information", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void GetListClasses ()
        {
            string error = "";
            DataTable dt;
            if (rbtAll.Checked == true)
                dt = cla.GetListClasses(0, ref error, connectData);
            else if (rbtEven.Checked == true)
                dt = cla.GetListClasses(1, ref error, connectData);
            else
                dt = cla.GetListClasses(2, ref error, connectData);
            if (dt != null)
                this.dgvListClasses.DataSource = dt;
            else
                MessageBox.Show(error, "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string error = "";
            DataTable dt;
            if (rbtAll.Checked == true)
                dt = cla.GetListLikeClasses(0, txtSearch.Text, ref error, connectData);
            else if (rbtEven.Checked == true)
                dt = cla.GetListLikeClasses(1, txtSearch.Text, ref error, connectData);
            else
                dt = cla.GetListLikeClasses(2, txtSearch.Text, ref error, connectData);
            if (dt != null)
                this.dgvListClasses.DataSource = dt;
            else
                MessageBox.Show(error, "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
