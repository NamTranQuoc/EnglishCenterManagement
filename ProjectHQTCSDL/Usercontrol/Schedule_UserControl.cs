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
    public partial class Schedule_UserControl : UserControl
    {
        Schedule sche;
        public int IDUser;
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
            this.cbbWeek.DataSource = sche.GetListDateOfWeek(IDUser);
        }

        private void cbbWeek_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.dgvSchedule.DataSource = sche.GetScheduleOfWeek(IDUser, cbbWeek.Text.Trim());
        }
    }
}
