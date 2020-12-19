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
    public partial class Courses_UserControl : UserControl
    {
        Courses cou;
        public bool f;

        public dbMain connectData;

        public Courses_UserControl()
        {
            InitializeComponent();
            cou = new Courses();
            f = false;
        }

        private void Cources_UserControl_Load(object sender, EventArgs e)
        {
            string error = "";
            DataTable dt = cou.GetListCources(1, ref error, connectData);
            if (dt != null)
            {
                this.dgvListCources.DataSource = dt;
                this.txtIDNew.Text = cou.CreateID(connectData).ToString();
            }
            else
                MessageBox.Show(error, "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void rbtAvailable_CheckedChanged(object sender, EventArgs e)
        {
            string error = "";
            DataTable dt = cou.GetListCources(1, ref error, connectData);
            if (dt != null)
                this.dgvListCources.DataSource = dt;
            else
                MessageBox.Show(error, "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void rbtHide_CheckedChanged(object sender, EventArgs e)
        {
            string error = "";
            DataTable dt = cou.GetListCources(2, ref error, connectData);
            if (dt != null)
                this.dgvListCources.DataSource = dt;
            else
                MessageBox.Show(error, "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void rbtAll_CheckedChanged(object sender, EventArgs e)
        {
            string error = "";
            DataTable dt = cou.GetListCources(0, ref error, connectData);
            if (dt != null)
                this.dgvListCources.DataSource = dt;
            else
                MessageBox.Show(error, "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dgvListCources_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvListCources.Rows[e.RowIndex];
            txtID.Text = row.Cells[0].Value.ToString();
            txtName.Text = row.Cells[1].Value.ToString();
            txtNo.Text = row.Cells[2].Value.ToString();
            txtTuitionFee.Text = row.Cells[3].Value.ToString();
            if (row.Cells[4].Value.ToString() == "1")
                btnHideOrAvailable.Text = "Hide";
            else
                btnHideOrAvailable.Text = "Show";
        }

        public void GetListCources ()
        {
            string error = "";
            DataTable dt;
            if (rbtAll.Checked == true)
                dt = cou.GetListCources(0, ref error, connectData);
            else if (rbtAvailable.Checked == true)
                dt= cou.GetListCources(1, ref error, connectData);
            else
                dt = cou.GetListCources(2, ref error, connectData);
            if (dt != null)
                this.dgvListCources.DataSource = dt;
            else
                MessageBox.Show(error, "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text != null && txtName.Text != "" && txtNo.Text != null && txtNo.Text != "" && txtTuitionFee.Text != null && txtTuitionFee.Text != "")
            {
                int no, tuition;
                bool tNo = int.TryParse(txtNo.Text, out no);
                bool tTuition = int.TryParse(txtTuitionFee.Text, out tuition);
                if (tNo != false && tTuition != false)
                {
                    string error = "";
                    bool t = cou.UpdateCource(int.Parse(txtID.Text), txtName.Text, tuition, no, ref error, connectData);
                    if (t == true)
                    {
                        this.GetListCources();
                        MessageBox.Show("Update successful", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        f = true; // set biến cờ để load lại lịch nếu có thay đổi
                    }
                    else
                        MessageBox.Show(error, "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Please enter a number for Number of session and Tuition fee", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Please fill out all information", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnHideOrAvailable_Click(object sender, EventArgs e)
        {
            bool t;
            string error = "";
            if (btnHideOrAvailable.Text == "Hide")
                t = cou.UpdateStatus(int.Parse(txtID.Text), 0, ref error, connectData);
            else
                t = cou.UpdateStatus(int.Parse(txtID.Text), 1, ref error, connectData);
            if (t == true)
            {
                this.GetListCources();
                MessageBox.Show("Update successful", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show(error, "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtNameNew.Text != null && txtNameNew.Text != "" && txtNoNew.Text != null && txtNoNew.Text != "" && txtTuitionFeeNew.Text != null && txtTuitionFeeNew.Text != "")
            {
                int no, tuition;
                bool tNo = int.TryParse(txtNoNew.Text, out no);
                bool tTuition = int.TryParse(txtTuitionFeeNew.Text, out tuition);
                if (tNo != false && tTuition != false)
                {
                    string error = "Error";
                    bool t = cou.InsertCource(int.Parse(txtIDNew.Text), txtNameNew.Text, no, tuition, ref error, connectData);
                    if (t == true)
                    {
                        this.GetListCources();
                        txtIDNew.Text = cou.CreateID(connectData).ToString();
                        txtNameNew.ResetText();
                        txtNoNew.ResetText();
                        txtTuitionFeeNew.ResetText();
                        MessageBox.Show("Insert successful", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show(error, "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Please enter a number for Number of session and Tuition fee", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Please fill out all information", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            this.GetListCources();
        }
    }
}
