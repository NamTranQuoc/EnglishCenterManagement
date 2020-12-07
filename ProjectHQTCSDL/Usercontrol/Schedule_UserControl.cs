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
    public partial class Schedule_UserControl : UserControl
    {
        Schedule sche;
        public int IDUser;
        public dbMain connectData;
        public Schedule_UserControl()
        {
            InitializeComponent();
            sche = new Schedule();

            dgvSchedule.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSchedule.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvSchedule.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void Schedule_UserControl_Load(object sender, EventArgs e)
        {
            this.LoadccbView();
        }

        public void LoadccbView()
        {
            this.cbbWeek.DataSource = sche.GetListDateOfWeek(IDUser, connectData);
        }

        private void cbbWeek_SelectedIndexChanged(object sender, EventArgs e)
        {
            string error = "";
            DataTable dt = sche.GetScheduleOfWeek(IDUser, cbbWeek.Text.Trim(), ref error, connectData);
            if (dt != null)
                this.dgvSchedule.DataSource = dt;
            else
                MessageBox.Show(error, "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
