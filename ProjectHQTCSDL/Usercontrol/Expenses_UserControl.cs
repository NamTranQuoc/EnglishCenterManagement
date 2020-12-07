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
    public partial class Expenses_UserControl : UserControl
    {
        Cources course;
        Expenses expenses;

        public dbMain connectData;

        public Expenses_UserControl()
        {
            InitializeComponent();
            course = new Cources();
            expenses = new Expenses();
        }

        private void Expenses_UserControl_Load(object sender, EventArgs e)
        {
            string error = "";
            DataTable dt1 = expenses.GetExpense(ref error, connectData);
            if (dt1 != null)
                dgvExpense.DataSource = dt1;
            else
                MessageBox.Show(error, "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);

            DataTable dt2 = course.GetListCources(0, ref error, connectData);
            if (dt2 != null)
            {
                cbNameCourse.DataSource = dt2;
                cbNameCourse.DisplayMember = "TenKhoaHoc";
            }
            else
                MessageBox.Show(error, "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string name = cbNameCourse.Text;
            string error = "";
            DataTable dt = expenses.GetExpenseByCourse(name, ref error, connectData);
            if (dt != null)
                dgvExpense.DataSource = dt;
            else
                MessageBox.Show(error, "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            bool result = expenses.UpdateExpense(MaLop, MaHV, pay.ToString(), ref error, connectData);

            if (result)
                MessageBox.Show("The student has paid successfully", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Unsuccessfull payment", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
