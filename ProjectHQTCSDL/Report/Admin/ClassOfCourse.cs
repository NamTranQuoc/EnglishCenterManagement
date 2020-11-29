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
    public partial class ClassOfCourse : Form
    {
        public ClassOfCourse()
        {
            InitializeComponent();
        }

        private void ClassOfCourse_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'trungTamAnhNgu.LopThuocKhoa' table. You can move, or remove it, as needed.
            this.lopThuocKhoaTableAdapter.Fill(this.trungTamAnhNgu.LopThuocKhoa);

            this.rvwClassOfCourse.RefreshReport();
        }
    }
}
