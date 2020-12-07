using ProjectHQTCSDL.BS_Layer;
using ProjectHQTCSDL.DB_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectHQTCSDL.Usercontrol
{
    public partial class EnrollInClass_UserControl : UserControl
    {
        public int iDStudent;
        public bool f;
        EnrollInClass enr;
        DataTable ListCource;
        int rowListCource;
        int rowListClass;

        public dbMain connectData;

        public EnrollInClass_UserControl()
        {
            InitializeComponent();
            enr = new EnrollInClass();
        }

        private void EnrollInClass_UserControl_Load(object sender, EventArgs e)
        {   
            string error = "";
            try
            {              
                this.dgvListClass.DataSource = enr.GetListClass(iDStudent, "All", "All", 0, ref error, connectData);
                ListCource = enr.GetListCourceName(ref error, connectData);
                this.cbbCourceName.DataSource = ListCource;
                this.cbbCourceName.DisplayMember = "TenKhoaHoc";
                this.cbbCourceName.Text = "All";
            }
            catch
            {
                MessageBox.Show(error, "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbbShift_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void cbbDOW_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void cbbCourceName_SelectedIndexChanged(object sender, EventArgs e)
        {
            rowListCource = cbbCourceName.SelectedIndex;
            this.LoadData();
        }

        public void LoadData()
        {
            string error = "";
            try
            {
                this.dgvListClass.DataSource = enr.GetListClass(iDStudent, cbbShift.Text, cbbDOW.Text, (int)ListCource.Rows[rowListCource]["MaKhoaHoc"], ref error, connectData);
            }
            catch
            {
                MessageBox.Show(error, "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (enr.CheckClassEnable(int.Parse(dgvListClass.Rows[rowListClass].Cells[1].Value.ToString()), int.Parse(dgvListClass.Rows[rowListClass].Cells[2].Value.ToString()), int.Parse(dgvListClass.Rows[rowListClass].Cells[0].Value.ToString()), connectData))
            {
                string error = "";
                if (btnSave.Text == "Unenroll")
                {
                    if (enr.DeleteEnroll(int.Parse(dgvListClass.Rows[rowListClass].Cells[0].Value.ToString()), iDStudent, ref error, connectData))
                    {
                        this.LoadData();
                        MessageBox.Show("Unenroll Sucessfull", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show(error, "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (enr.InsertEnroll(int.Parse(dgvListClass.Rows[rowListClass].Cells[0].Value.ToString()), iDStudent, ref error, connectData))
                    {
                        this.LoadData();
                        MessageBox.Show("Enroll Sucessfull", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } 
                    else
                        MessageBox.Show(error, "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                f = true;
            } 
            else
            {
                MessageBox.Show("Error", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }

        private void dgvListClass_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (enr.GetEnrolled(iDStudent.ToString(), dgvListClass.Rows[e.RowIndex].Cells[0].Value.ToString(), connectData))
            {
                btnSave.Text = "Unenroll";               
            }    
            else
            {
                btnSave.Text = "Enroll";
            }
            rowListClass = e.RowIndex;
        }
    }
}
