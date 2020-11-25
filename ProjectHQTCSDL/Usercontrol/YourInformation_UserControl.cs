﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectHQTCSDL.BS_Layer;
using System.Data.SqlClient;

namespace ProjectHQTCSDL.Usercontrol
{
    public partial class YourInformation_UserControl : UserControl
    {
        public int IDTaiKhoan;
        public bool state = true; // true -- hiện Hoc Vien , false -- Giao vien


        private bool update = false;
        private YourInformation infor;
        public YourInformation_UserControl()
        {
            InitializeComponent();
            infor = new YourInformation();
        }

        private void YourInformation_UserControl_Load(object sender, EventArgs e)
        {
            if( state == true)
            {
                this.pnlHocVien.Show();
                this.pnlGiaoVien.Hide();

                this.pnlHocVien.Location = new Point(390, 211);

                GetInfoHocVien();

                txtHoTen.Enabled = false;
                txtSDT.Enabled = false;
                txtDiaChi.Enabled = false;
                txtEmail.Enabled = false;
                dtpNgaySinh.Enabled = false;
            }
            else
            {
                this.pnlGiaoVien.Show();
                this.pnlHocVien.Hide();
                this.pnlGiaoVien.Location = new Point(390, 211);

                GetInfoGiaoVien();

                txtHoTenGV.Enabled = false;
                txtSdtGV.Enabled = false;
                txtDiaChiGV.Enabled = false;
                txtLuongGV.Enabled = false;
            }

            btnCapNhat.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }

        private DataTable table;
        private void GetInfoHocVien()
        {
            try
            {
                table = infor.GetHocVien(IDTaiKhoan);

                txtHoTen.Text = table.Rows[0]["HoTen"].ToString();
                txtSDT.Text = table.Rows[0]["SDT"].ToString();
                txtDiaChi.Text = table.Rows[0]["DiaChi"].ToString();
                txtEmail.Text = table.Rows[0]["Email"].ToString();
                dtpNgaySinh.Value = (DateTime)table.Rows[0]["NgaySinh"];
            }
            catch(SqlException e)
            {
                MessageBox.Show(e.Message, "Warning Load Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

        }

        private void GetInfoGiaoVien()
        {
            try
            {
                table = infor.GetGiaoVien(IDTaiKhoan);

                txtHoTenGV.Text = table.Rows[0]["HoTen"].ToString();
                txtSdtGV.Text = table.Rows[0]["SDT"].ToString();
                txtDiaChiGV.Text = table.Rows[0]["DiaChi"].ToString();
                txtLuongGV.Text = table.Rows[0]["LuongCoBan"].ToString();
            }
            catch(SqlException e)
            {
                MessageBox.Show(e.Message, "Warning Load Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (state == true)
            {
                txtHoTen.Enabled = true;
                txtSDT.Enabled = true;
                txtDiaChi.Enabled = true;
                txtEmail.Enabled = true;
                dtpNgaySinh.Enabled = true;
            }
            else
            {
                txtHoTenGV.Enabled = true;
                txtSdtGV.Enabled = true;
                txtDiaChiGV.Enabled = true;
                txtLuongGV.Enabled = true;
            }

            btnCapNhat.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            update = true;

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if(state == true)
            {
                txtHoTen.Enabled = false;
                txtSDT.Enabled = false;
                txtDiaChi.Enabled = false;
                txtEmail.Enabled = false;
                dtpNgaySinh.Enabled = false;

                GetInfoHocVien();
            }
            else
            {
                txtHoTenGV.Enabled = false;
                txtSdtGV.Enabled = false;
                txtDiaChiGV.Enabled = false;
                txtLuongGV.Enabled = false;

                GetInfoGiaoVien();
            }

            btnCapNhat.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            update = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(update == true)
            {
                string text = "Would you like to update your information ?";
                DialogResult result = MessageBox.Show(text, "Update infor", MessageBoxButtons.YesNo , MessageBoxIcon.Question);

                if( result == DialogResult.Yes)
                {
                    Excute();
                }

                btnCapNhat.Enabled = true;
                btnLuu.Enabled = false;
                btnHuy.Enabled = false;

                update = false;
            }
            
        }


        private void Excute()
        {
            int id = IDTaiKhoan;

            string error = "Not excute";
            bool result;
            if (state == true)
            {
                Students stu = new Students();
                
                string name = txtHoTen.Text.Trim();
                string phone = txtSDT.Text.Trim();
                string diachi = txtDiaChi.Text.Trim();
                string email = txtEmail.Text.Trim();
                DateTime birthdate = dtpNgaySinh.Value;

                result = stu.UpdateStudent(id, name, phone, diachi, email, birthdate, ref error);

                if (result)
                {
                    MessageBox.Show("Update successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Update unsuccessfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


                txtHoTen.Enabled = false;
                txtSDT.Enabled = false;
                txtDiaChi.Enabled = false;
                txtEmail.Enabled = false;
                dtpNgaySinh.Enabled = false;

                GetInfoHocVien();
            }
            else
            {
                Teachers teacher = new Teachers();

                string name = txtHoTenGV.Text.Trim();
                string phone = txtSdtGV.Text.Trim();
                string diachi = txtDiaChiGV.Text.Trim();

                int luong = Convert.ToInt32(txtLuongGV.Text.Trim());

                result = teacher.UpdateTeacher(id, name, phone, diachi, luong, ref error);

                if (result)
                {
                    MessageBox.Show("Update successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Update unsuccessfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                txtHoTenGV.Enabled = false;
                txtSdtGV.Enabled = false;
                txtDiaChiGV.Enabled = false;
                txtLuongGV.Enabled = false;

                GetInfoGiaoVien();
            }
            
        }
    }
}
