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
        }
    }
}
