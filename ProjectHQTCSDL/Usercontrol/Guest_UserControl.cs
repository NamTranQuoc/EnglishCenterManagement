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

namespace ProjectHQTCSDL.Usercontrol
{
    public partial class Guest_UserControl : UserControl
    {
        public string loai = "";
        DataTable dtLopHoc = null;
        Guest dbGuest = new Guest();

        public Guest_UserControl()
        {
            InitializeComponent();
            lblTieuDe.Visible = false;
            dgvGuest.Visible = false;
        }

        private void Guest_UserControl_Load(object sender, EventArgs e)
        {
 //           Load_Data();
        }

        public void Load_Data()
        {
            lblTieuDe.Visible = true;
            dgvGuest.Visible = true;
            try
            {
                dtLopHoc = new DataTable();
                dtLopHoc.Clear();
                switch (loai)
                {
                    case "TOEIC":
                        lblTieuDe.Text = "CLASSES TOEIC";
                        dtLopHoc = dbGuest.LayLopToeic();
                        break;
                    case "IELTS":
                        lblTieuDe.Text = "CLASSES IELTS";
                        dtLopHoc = dbGuest.LayLopIelts();
                        break;
                    case "COMMUNICATION":
                        lblTieuDe.Text = "CLASSES COMMUNICATION";
                        dtLopHoc = dbGuest.LayLopCommunication();
                        break;
                    default:
                        lblTieuDe.Text = "CLASSES BASIC";
                        dtLopHoc = dbGuest.LayLopBasic();
                        break;
                }

              //  dtLopHoc = dbGuest.LayLopToeic();
                dgvGuest.DataSource = dtLopHoc;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong bảng Học bù!");
            }
        }
    }
}
