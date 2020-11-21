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
    public partial class Cources_UserControl : UserControl
    {
        Cources cou;
        public Cources_UserControl()
        {
            InitializeComponent();
            cou = new Cources();
        }

        private void Cources_UserControl_Load(object sender, EventArgs e)
        {
            this.dgvListCources.DataSource = cou.GetListCources(1);
            this.txtIDNew.Text = cou.CreateID().ToString();
        }

        private void rbtAvailable_CheckedChanged(object sender, EventArgs e)
        {
            this.dgvListCources.DataSource = cou.GetListCources(1);
        }

        private void rbtHide_CheckedChanged(object sender, EventArgs e)
        {
            this.dgvListCources.DataSource = cou.GetListCources(2);
        }

        private void rbtAll_CheckedChanged(object sender, EventArgs e)
        {
            this.dgvListCources.DataSource = cou.GetListCources(0);
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text != null && txtName.Text != "" && txtNo.Text != null && txtNo.Text != "" && txtTuitionFee.Text != null && txtTuitionFee.Text != "")
            {
                int no, tuition;
                bool tNo = int.TryParse(txtNo.Text, out no);
                bool tTuition = int.TryParse(txtTuitionFee.Text, out tuition);
                if (tNo != false && tTuition != false)
                {
                    bool t = cou.UpdateCource(int.Parse(txtID.Text), txtName.Text, tuition);
                    if (t == true)
                    {
                        if (rbtAll.Checked == true)
                            this.dgvListCources.DataSource = cou.GetListCources(0);
                        else if (rbtAvailable.Checked == true)
                            this.dgvListCources.DataSource = cou.GetListCources(1);
                        else
                            this.dgvListCources.DataSource = cou.GetListCources(2);
                        MessageBox.Show("Update successful", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);                        
                    }
                    else
                        MessageBox.Show("Error", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (btnHideOrAvailable.Text == "Hide")
                t = cou.UpdateStatus(int.Parse(txtID.Text), 0);
            else
                t = cou.UpdateStatus(int.Parse(txtID.Text), 1);
            if (t == true)
            {
                if (rbtAll.Checked == true)
                    this.dgvListCources.DataSource = cou.GetListCources(0);
                else if (rbtAvailable.Checked == true)
                    this.dgvListCources.DataSource = cou.GetListCources(1);
                else
                    this.dgvListCources.DataSource = cou.GetListCources(2);
                MessageBox.Show("Update successful", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
                    bool t = cou.InsertCource(int.Parse(txtIDNew.Text), txtNameNew.Text, no, tuition);
                    if (t == true)
                    {
                        if (rbtAll.Checked == true)
                            this.dgvListCources.DataSource = cou.GetListCources(0);
                        else if (rbtAvailable.Checked == true)
                            this.dgvListCources.DataSource = cou.GetListCources(1);
                        else
                            this.dgvListCources.DataSource = cou.GetListCources(2);
                        txtIDNew.Text = cou.CreateID().ToString();
                        txtNameNew.ResetText();
                        txtNoNew.ResetText();
                        txtTuitionFeeNew.ResetText();
                        MessageBox.Show("Insert successful", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Error", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Please enter a number for Number of session and Tuition fee", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Please fill out all information", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (rbtAll.Checked == true)
                this.dgvListCources.DataSource = cou.GetListLikeCource(0, txtSearch.Text);
            else if (rbtAvailable.Checked == true)
                this.dgvListCources.DataSource = cou.GetListLikeCource(1, txtSearch.Text);
            else
                this.dgvListCources.DataSource = cou.GetListLikeCource(2, txtSearch.Text);
        }
    }
}
