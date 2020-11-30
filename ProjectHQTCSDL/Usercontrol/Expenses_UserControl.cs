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
    public partial class Expenses_UserControl : UserControl
    {
        Cources course;
        Expenses expenses;
        public Expenses_UserControl()
        {
            InitializeComponent();
            course = new Cources();
            expenses = new Expenses();
        }

        private void Expenses_UserControl_Load(object sender, EventArgs e)
        {
            dgvExpense.DataSource = expenses.GetExpense();

            cbNameCourse.DataSource = course.GetListCources(0);
            cbNameCourse.DisplayMember = "TenKhoaHoc";
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string name = cbNameCourse.Text;

            dgvExpense.DataSource = expenses.GetExpenseByCourse(name);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int row = dgvExpense.CurrentRow.Index;
            var malop = dgvExpense[0, row].Value;
            var mahv = dgvExpense[1, row].Value;
            var pay = dgvExpense[6, row].Value;

            int MaLop = Convert.ToInt32(malop);
            int MaHV = Convert.ToInt32(mahv);

            string error = null;

            bool result = expenses.UpdateExpense(MaLop, MaHV, pay.ToString(), ref error);

            if (result)
                MessageBox.Show("The student has paid successfully", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Unsuccessfull payment", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
