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
    public partial class Teachers_UserControl : UserControl
    {
        Teachers teacher;
        public Teachers_UserControl()
        {
            InitializeComponent();
            teacher = new Teachers();
        }

        private void Teachers_UserControl_Load(object sender, EventArgs e)
        {
            this.dgvListTeachers.DataSource = teacher.GetListTeachers();
        }

        private void dgvListTeachers_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvListTeachers.Rows[e.RowIndex];
            txtID.Text = row.Cells[0].Value.ToString();
            txtName.Text = row.Cells[1].Value.ToString();
            txtPhone.Text = row.Cells[2].Value.ToString();
            txtAddress.Text = row.Cells[3].Value.ToString();
            nmrSessions.Value = Convert.ToDecimal(row.Cells[4].Value);
        }
    }
}
