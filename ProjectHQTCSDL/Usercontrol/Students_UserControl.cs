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
        }

        private void dgvListStudents_RowEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvListStudents.Rows[e.RowIndex];
            txtID.Text = row.Cells[0].Value.ToString();
            txtName.Text = row.Cells[1].Value.ToString();
            txtPhone.Text = row.Cells[2].Value.ToString();
            txtAddress.Text = row.Cells[3].Value.ToString();
            txtEmail.Text = row.Cells[4].Value.ToString();
            txtDOB.Text = row.Cells[5].Value.ToString();
        }
    }
}
