using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectHQTCSDL.Report.Teacher
{
    public partial class TeacherOfTheCourse : Form
    {
        public TeacherOfTheCourse()
        {
            InitializeComponent();
        }

        private void TeacherOfTheCourse_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'trungTamAnhNgu.GiaoVienThuocKhoaHoc' table. You can move, or remove it, as needed.
            this.giaoVienThuocKhoaHocTableAdapter.Fill(this.trungTamAnhNgu.GiaoVienThuocKhoaHoc);

            this.rvwTeacherOfTheCourse.RefreshReport();
        }
    }
}
