using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectHQTCSDL.Report.Student
{
    public partial class StudentInClass : Form
    {
        public StudentInClass()
        {
            InitializeComponent();
        }

        private void StudentInClass_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'trungTamAnhNgu.HocVienThuocLop' table. You can move, or remove it, as needed.
            this.hocVienThuocLopTableAdapter.Fill(this.trungTamAnhNgu.HocVienThuocLop);
            this.rvwStudentInClass.RefreshReport();
        }
    }
}
