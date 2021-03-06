﻿using ProjectHQTCSDL.BS_Layer;
using ProjectHQTCSDL.DB_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectHQTCSDL.Usercontrol
{
    public partial class DeleteSchedule_UserControl : UserControl
    {
        public bool f;
        Schedule sche;

        public dbMain connectData;

        public DeleteSchedule_UserControl()
        {
            InitializeComponent();

            sche = new Schedule();
            f = false;
        }

        private void cbAllDay_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAllDay.Checked == true)
                this.dtpDay.Enabled = false;
            else
                this.dtpDay.Enabled = true;
            this.LoadSchedule();
        }

        public void LoadSchedule()
        {
            if (cbAllDay.Checked != true)
            {
                this.dgvSchedule.DataSource = sche.GetSchedule(cbbClass.Text, dtpDay.Value, cbbSession.Text, connectData, true);
            }    
            else
            {
                this.dgvSchedule.DataSource = sche.GetSchedule(cbbClass.Text, dtpDay.Value, cbbSession.Text, connectData);
            }    
        }

        private void cbbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            string error = "Error";
            try
            {
                this.cbbSession.DataSource = sche.GetListSession(cbbClass.Text, ref error, connectData);
                this.cbbSession.DisplayMember = "Session";
                this.cbbSession.Text = "All";
            }
            catch
            {
                MessageBox.Show(error, "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteSchedule_UserControl_Load(object sender, EventArgs e)
        {
            string error = "Error";
            try
            {
                this.cbbClass.DataSource = sche.GetListClass(ref error, connectData);
                this.cbbClass.DisplayMember = "IdClass";
                this.cbbClass.Text = "All";
                this.cbbSession.DataSource = sche.GetListSession(cbbClass.Text, ref error, connectData);
                this.cbbSession.DisplayMember = "Session";
                this.cbbSession.Text = "All";
                this.LoadSchedule();
            }
            catch
            {
                MessageBox.Show(error, "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtpDay_ValueChanged(object sender, EventArgs e)
        {
            this.LoadSchedule();
        }

        private void cbbSession_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.LoadSchedule();
            }
            catch { }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int sDel = 0;
            foreach (DataGridViewRow row in dgvSchedule.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[6];
                if ((bool)chk.Value == true)
                {
                    sDel++;
                    sche.DeleteSchedule((int)row.Cells[0].Value, (int)row.Cells[1].Value, connectData);
                    f = true;
                }
            }
            this.LoadSchedule();
            if (sDel == 0)
                MessageBox.Show("There is no option to delete", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Deleted successfully", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
