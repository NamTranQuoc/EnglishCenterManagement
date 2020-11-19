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
using ProjectHQTCSDL.View.Login;

namespace ProjectHQTCSDL.View.Dashboard
{
    public partial class fGuestDashboard : Form
    {
        public fGuestDashboard()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            fLogin log = new fLogin();
            log.ShowDialog();
        }
    }
}
