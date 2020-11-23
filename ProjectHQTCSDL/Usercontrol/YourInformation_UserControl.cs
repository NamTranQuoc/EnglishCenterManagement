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
    public partial class YourInformation_UserControl : UserControl
    {

        YourInformation info;
        public int IDUser;

        private bool update = false;

        public YourInformation_UserControl()
        {
            InitializeComponent();
            info = new YourInformation();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            update = true;

            txtHoTen.Enabled = true;
            txtDiaChi.Enabled = true;
            txtEmail.Enabled = true;
            txtSDT.Enabled = true;
            dtpNgaySinh.Enabled = true;

            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnCapNhat.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string hoten = txtHoTen.Text.Trim();
                string sdt = txtSDT.Text.Trim();
                string diachi = txtDiaChi.Text.Trim();
                string email = txtEmail.Text.Trim();

                DateTime ngaysinh = dtpNgaySinh.Value;

                int result = 1; // câu truy vấn chưa thục hiện
                if (update && result == 1)
                {
                    MessageBox.Show("Cập nhật thông tin thành công !!!", "Cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin không thành công !!!", "Cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                txtHoTen.Enabled = false;
                txtDiaChi.Enabled = false;
                txtEmail.Enabled = false;
                txtSDT.Enabled = false;
                dtpNgaySinh.Enabled = false;

                btnLuu.Enabled = false;
                btnHuy.Enabled = false;
                btnCapNhat.Enabled = true;

                Getinfo();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Getinfo();

            txtHoTen.Enabled = false;
            txtDiaChi.Enabled = false;
            txtEmail.Enabled = false;
            txtSDT.Enabled = false;
            dtpNgaySinh.Enabled = false;

            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnCapNhat.Enabled = true;
        }

        private void YourInformation_UserControl_Load(object sender, EventArgs e)
        {
            Getinfo();

            txtHoTen.Enabled = false;
            txtDiaChi.Enabled = false;
            txtEmail.Enabled = false;
            txtSDT.Enabled = false;
            dtpNgaySinh.Enabled = false;

            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnCapNhat.Enabled = true;
        }

        private void Getinfo()
        {
            DataTable table = info.GetHocVien(IDUser);
            txtHoTen.Text = table.Rows[0]["HoTen"].ToString();
            txtSDT.Text = table.Rows[0]["SDT"].ToString();
            txtDiaChi.Text = table.Rows[0]["DiaChi"].ToString();
            txtEmail.Text = table.Rows[0]["Email"].ToString();
            dtpNgaySinh.Value = (DateTime)table.Rows[0]["NgaySinh"];

        }
    }
}
