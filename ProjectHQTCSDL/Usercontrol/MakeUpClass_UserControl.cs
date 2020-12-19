using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectHQTCSDL.BS_Layer;
using ProjectHQTCSDL.DB_Layer;

namespace ProjectHQTCSDL.Usercontrol
{
    public partial class MakeUpClass_UserControl : UserControl
    {
        // Lấy maHocVien là tài khoản đăng nhập
        public int IdStudent;

        int row;
        MakeUpClass dbMUC = new MakeUpClass();

        public dbMain connectData;

        public MakeUpClass_UserControl()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string error = "error";
            try
            {
                if (btnSave.Text == "Enroll")
                {
                    if (dbMUC.EnrollAbsent(IdStudent, int.Parse(cboClass.Text), int.Parse(cboSession.Text), int.Parse(dgvMUC.Rows[row].Cells[1].Value.ToString()), connectData, ref error))
                    {
                        this.btnSave.Text = "Unenroll";
                        this.GetClassAbsent();
                        MessageBox.Show("Registration successful", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show(error, "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (dbMUC.UnenrollAbsent(IdStudent, int.Parse(cboClass.Text), int.Parse(cboSession.Text), connectData, ref error))
                    {
                        this.btnSave.Text = "Enroll";
                        this.GetClassAbsent();
                        MessageBox.Show("Canceled successfully", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show(error, "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                }
            }
            catch
            {
                MessageBox.Show(error, "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MakeUpClass_UserControl_Load(object sender, EventArgs e)
        {
            this.GetListClass();
        }

        private void cboClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int test;
                if (int.TryParse(cboClass.Text, out test))
                    this.GetListSession();   
            }
            catch { }
        }

        private void cboSession_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int test;
                if (int.TryParse(cboSession.Text, out test))
                    this.GetClassAbsent();
            }
            catch { }
        }

        private void GetListClass()
        {
            string error = "error";
            try
            {
                cboClass.DataSource = dbMUC.GetListClassAbsent(IdStudent, connectData, ref error);
                cboClass.DisplayMember = "IdClass";
            }
            catch
            {
                MessageBox.Show(error, "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetListSession()
        {
            string error = "";
            try
            {
                cboSession.DataSource = dbMUC.GetListSessionAbsent(IdStudent, int.Parse(cboClass.Text), connectData, ref error);
                cboSession.DisplayMember = "Session";
            }
            catch
            {
                MessageBox.Show(error, "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetClassAbsent()
        {
            string error = "";
            try
            {
                dgvMUC.DataSource = dbMUC.GetClassAbsent(IdStudent, int.Parse(cboClass.Text), int.Parse(cboSession.Text), connectData, ref error);
            }
            catch
            {
                MessageBox.Show(error, "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvMUC_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if ((bool)dgvMUC.Rows[e.RowIndex].Cells[5].Value)
            {
                btnSave.Text = "Unenroll";
            }
            else
            {
                btnSave.Text = "Enroll";
            }
            row = e.RowIndex;
        }
    }
}
