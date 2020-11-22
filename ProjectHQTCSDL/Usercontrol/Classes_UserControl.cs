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
            this.dgvListClasses.DataSource = cla.GetListCources(0);
        }

        private void rbtAll_CheckedChanged(object sender, EventArgs e)
        {
            this.dgvListClasses.DataSource = cla.GetListCources(0);
        }

        private void rbtEven_CheckedChanged(object sender, EventArgs e)
        {
            this.dgvListClasses.DataSource = cla.GetListCources(1);
        }

        private void rbtOdd_CheckedChanged(object sender, EventArgs e)
        {
            this.dgvListClasses.DataSource = cla.GetListCources(2);
        }

        private void dgvListClasses_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvListClasses.Rows[e.RowIndex];
            txtID.Text = row.Cells[0].Value.ToString();
            nmrStudents.Value = Convert.ToDecimal(row.Cells[1].Value);
            nmrShift.Value = Convert.ToDecimal(row.Cells[2].Value);
            cbbDayOfWeek.Text = row.Cells[3].Value.ToString();
            cmbCourseID.Text = row.Cells[4].Value.ToString();
        }
    }
}
