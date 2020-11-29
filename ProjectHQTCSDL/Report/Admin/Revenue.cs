using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectHQTCSDL.Report.Admin
{
    public partial class Revenue : Form
    {
        public Revenue()
        {
            InitializeComponent();
        }

        private void Revenue_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'trungTamAnhNgu.DoanhThu' table. You can move, or remove it, as needed.
            this.doanhThuTableAdapter.Fill(this.trungTamAnhNgu.DoanhThu);

            this.rvwRevenue.RefreshReport();
        }
    }
}
