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
using ProjectHQTCSDL.Usercontrol;
using ProjectHQTCSDL.DB_Layer;

namespace ProjectHQTCSDL.View.Dashboard
{
    public partial class fGuestDashboard : Form
    {
        Guest guest;
        DataTable lCource;
        Guest_UserControl ucGuest;

        dbMain connectData;
        public fGuestDashboard()
        {
            InitializeComponent();
            connectData = new dbMain();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            fLogin log = new fLogin();
            log.connectData = this.connectData;
            log.ShowDialog();
            this.flpCource.Controls.Clear();
            this.LoadData();
        }

        private void fGuestDashboard_Load(object sender, EventArgs e)
        {
            ucGuest = new Guest_UserControl();
            pUserControl.Controls.Add(ucGuest);
            this.ucGuest.Hide();

            guest = new Guest();
            this.LoadData();
        }

        public void LoadData()
        {
            string error = "";
            lCource = guest.GetListNameCource(ref error, connectData);
            if (lCource != null)
            {
                for (int i = 0; i < lCource.Rows.Count; i++)
                {
                    Button btn = new Button();
                    btn.Name = "btn" + lCource.Rows[i]["IdCourse"].ToString();
                    btn.Text = lCource.Rows[i]["NameCourse"].ToString();
                    btn.Click += btn_Click;
                    btn.Width = 270;
                    btn.Height = 200;
                    btn.Font = new Font("Century Gothic", 30);
                    btn.BackColor = Color.LightBlue;
                    btn.ForeColor = Color.DarkRed;
                    flpCource.Controls.Add(btn);
                }
            }
            else
            {
                MessageBox.Show(error, "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string id = btn.Name;
            id = id.Replace("btn", "");

            this.flpCource.Hide();
            string error = "";
            DataTable dt = guest.GetListClassOfCource(int.Parse(id), ref error, connectData);
            if (dt != null)
            {
                ucGuest.dgvListClass.DataSource = dt;
                ucGuest.lbName.Text = btn.Text;
                ucGuest.Show();
            }
            else
            {
                MessageBox.Show(error, "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.flpCource.Show();
            this.ucGuest.Hide();
        }
    }
}
