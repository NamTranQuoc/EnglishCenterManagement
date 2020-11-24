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
    public partial class Attendance_UserControl : UserControl
    {
        Attendance att;
        public int IDTeacher;
        public Attendance_UserControl()
        {
            InitializeComponent();
            att = new Attendance();
        }

        private void Attendance_UserControl_Load(object sender, EventArgs e)
        {
            this.LoadData();
        }

        public void LoadData()
        {
            string id = att.GetIDClass(IDTeacher, cbbShift.Text);
            if (id != null)
            {
                this.lbClass.Text = id;
                this.lbSession.Text = att.GetSession(lbClass.Text);
                this.lbCource.Text = att.GetNameCource(lbClass.Text);
                this.dgvClassList.DataSource = att.GetClassList(lbClass.Text, lbSession.Text);
            }
        }

        private void cbbShift_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtNull = new DataTable();
            dtNull.Columns.Add("MaHocVien");
            dtNull.Columns.Add("HoTen");
            dtNull.Columns.Add("SDT");
            dtNull.Columns.Add("NgaySinh");
            dtNull.Columns.Add("Absent");
            this.dgvClassList.DataSource = dtNull;
            this.LoadData();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            List<int> listAbsent = new List<int>();
            foreach (DataGridViewRow row in dgvClassList.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[6];
                if ((bool)chk.Value == true)
                {
                    listAbsent.Add((int)row.Cells[0].Value);
                }
            }
            if (listAbsent.Count > 0)
                att.InsertAbsent(listAbsent, this.lbClass.Text, this.lbSession.Text);
            MessageBox.Show("Attendance completed", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
