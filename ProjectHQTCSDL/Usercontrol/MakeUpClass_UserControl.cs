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
    public partial class MakeUpClass_UserControl : UserControl
    {
        // Lấy maHocVien là tài khoản đăng nhập
        public int maHocVien;
        private int maLopHocBu = 0;

        DataTable dtHocBu = null;
        MakeUpClass dbMUC = new MakeUpClass();

        public MakeUpClass_UserControl()
        {
            InitializeComponent();
        }

        public void LoadCboLopHoc()
        {
            cboLopHoc.Items.Clear();
            List<int> dsLopHoc = dbMUC.LayLopHocHV(maHocVien);
            for (int i = 0; i < dsLopHoc.Count; i++)
                cboLopHoc.Items.Add(dsLopHoc[i]);
            cboLopHoc.Text = dsLopHoc[0].ToString();
        }

        public void LoadSoBuoi()
        {
            cboBuoiHoc.Items.Clear();
            int soBuoi = dbMUC.SoBuoiHoc(Convert.ToInt32(cboLopHoc.Text));
            for (int i = 1; i < soBuoi + 1; i++)
                cboBuoiHoc.Items.Add(i);
        }

        public void HienThiHocBuNeuCo()
        {
            int check = dbMUC.KtraHocBuCoTonTai(maHocVien, Convert.ToInt32(cboLopHoc.Text), Convert.ToInt32(cboBuoiHoc.Text));
            if (check!=-1)
            {
                foreach (DataGridViewRow row in dgvMUC.Rows)
                {
                    if (Convert.ToInt32(row.Cells[1].Value) == check)
                        row.Cells[5].Value = true;
                }
                btnLuu.Enabled = true;
                btnHuyBo.Enabled = true;
            }    
        }

        public void Load_Data()
        {
            try
            {
                dtHocBu = new DataTable();
                dtHocBu.Clear();
                int theoKhoaHoc = dbMUC.LayKhoaLH(Convert.ToInt32(cboLopHoc.Text));
                dtHocBu = dbMUC.LayHocBu(theoKhoaHoc, Convert.ToInt32(cboLopHoc.Text.Trim()), Convert.ToInt32(cboBuoiHoc.Text.Trim()));
                dgvMUC.DataSource = dtHocBu;
                btnLuu.Enabled = false;
                btnHuyBo.Enabled = false;
                HienThiHocBuNeuCo();
           //     dgvMUC.AutoResizeColumns();
           //     dgvMUC.Rows[0].Cells[5].Value = true;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong bảng Học bù!");
            }
        }


        private void dgvMUC_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int columnIndex = 5;
            if (e.ColumnIndex == columnIndex)
            {
                bool isChecked = Convert.ToBoolean(dgvMUC.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                if (isChecked)
                {
                    foreach (DataGridViewRow row in dgvMUC.Rows)
                    {
                        if (row.Index != e.RowIndex)
                            row.Cells[columnIndex].Value = false;
                    }
                }
            }
        }

        private void dgvMUC_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvMUC.IsCurrentCellDirty)
                dgvMUC.CommitEdit(DataGridViewDataErrorContexts.Commit);

            int columnIndex = 5;
            foreach (DataGridViewRow row in dgvMUC.Rows)
                if (Convert.ToBoolean(row.Cells[columnIndex].Value))
                    maLopHocBu = Convert.ToInt32(row.Cells[1].Value);

            btnLuu.Enabled = true;
            btnHuyBo.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (dbMUC.KtraHocBuCoTonTai(maHocVien, Convert.ToInt32(cboLopHoc.Text), Convert.ToInt32(cboBuoiHoc.Text)) == -1)
                {
                    dbMUC.ThemVaCapNhatBuoiHocVang(maHocVien, Convert.ToInt32(cboLopHoc.Text), Convert.ToInt32(cboBuoiHoc.Text), maLopHocBu);
                    MessageBox.Show("Đã thêm lớp học bù thành công!");
                }
                else
                {
                    dbMUC.ThemVaCapNhatBuoiHocVang(maHocVien, Convert.ToInt32(cboLopHoc.Text), Convert.ToInt32(cboBuoiHoc.Text), maLopHocBu);
                    MessageBox.Show("Đã cập nhật lớp học bù thành công!");
                }
            }
            catch(SqlException)
            {
                MessageBox.Show("Không thể Lưu! Lỗi rồi!!!");
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            try
            {
                int check = dbMUC.KtraHocBuCoTonTai(maHocVien, Convert.ToInt32(cboLopHoc.Text), Convert.ToInt32(cboBuoiHoc.Text));
                if (check != -1)
                {
                    foreach (DataGridViewRow row in dgvMUC.Rows)
                    {
                        if (Convert.ToInt32(row.Cells[1].Value) == check)
                        {
                            dbMUC.HuyBoHocBu(maHocVien, Convert.ToInt32(cboLopHoc.Text), Convert.ToInt32(row.Cells[2].Value));
                            MessageBox.Show("Hủy bỏ thành công!!!");
                            break;
                        }
                    }
                }
                Load_Data();
            }
            catch(SqlException)
            {
                MessageBox.Show("Hủy bỏ thất bại!");
            }
        }

        private void cboLopHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSoBuoi();
            Load_Data();
        }

        private void cboBuoiHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void MakeUpClass_UserControl_Load(object sender, EventArgs e)
        {
            cboBuoiHoc.Text = "1";
            LoadCboLopHoc();
            LoadSoBuoi();
            Load_Data();
        }
    }
}
