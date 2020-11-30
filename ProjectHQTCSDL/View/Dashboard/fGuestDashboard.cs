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

namespace ProjectHQTCSDL.View.Dashboard
{
    public partial class fGuestDashboard : Form
    {
        Guest guest;
        DataTable lCource;
        Guest_UserControl ucGuest;
        public fGuestDashboard()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            fLogin log = new fLogin();
            log.ShowDialog();
        }

        private void fGuestDashboard_Load(object sender, EventArgs e)
        {
            ucGuest = new Guest_UserControl();
            pUserControl.Controls.Add(ucGuest);
            this.ucGuest.Hide();

            guest = new Guest();
            lCource = guest.GetListNameCource();
            for (int i = 0; i < lCource.Rows.Count; i++)
            {
                Button btn = new Button();
                btn.Name = "btn" + lCource.Rows[i]["MaKhoaHoc"].ToString();
                btn.Text = lCource.Rows[i]["TenKhoaHoc"].ToString();
                btn.Click += btn_Click;
                btn.Width = 270;
                btn.Height = 200;
                btn.Font = new Font("Century Gothic", 30);
                btn.BackColor = Color.LightBlue;
                btn.ForeColor = Color.DarkRed;
                flpCource.Controls.Add(btn);
            }    
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string id = btn.Name;
            id = id.Replace("btn", "");

            this.flpCource.Hide();

            ucGuest.dgvListClass.DataSource = guest.GetListClassOfCource(int.Parse(id));
            ucGuest.lbName.Text = btn.Text;
            ucGuest.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.flpCource.Show();
            this.ucGuest.Hide();
        }
    }
}
