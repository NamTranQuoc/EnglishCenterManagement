
namespace ProjectHQTCSDL.Usercontrol
{
    partial class MakeUpClass_UserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvMUC = new System.Windows.Forms.DataGridView();
            this.MaGiaoVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Buoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chon = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cboLopHoc = new System.Windows.Forms.ComboBox();
            this.cboBuoiHoc = new System.Windows.Forms.ComboBox();
            this.lblLopHoc = new System.Windows.Forms.Label();
            this.lblBuoiHoc = new System.Windows.Forms.Label();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.lblMakeUpClass = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMUC)).BeginInit();
            this.SuspendLayout();
            // 
            // MaGiaoVien
            // 
            this.MaGiaoVien.DataPropertyName = "MaGiaoVien";
            this.MaGiaoVien.HeaderText = "Mã giáo viên";
            this.MaGiaoVien.Name = "MaGiaoVien";
            this.MaGiaoVien.Width = 140;
            // 
            // MaLop
            // 
            this.MaLop.DataPropertyName = "MaLop";
            this.MaLop.HeaderText = "Mã lớp";
            this.MaLop.Name = "MaLop";
            this.MaLop.Width = 125;
            // 
            // Buoi
            // 
            this.Buoi.DataPropertyName = "Buoi";
            this.Buoi.HeaderText = "Buổi";
            this.Buoi.Name = "Buoi";
            this.Buoi.Width = 125;
            // 
            // Phong
            // 
            this.Phong.DataPropertyName = "Phong";
            this.Phong.HeaderText = "Phòng";
            this.Phong.Name = "Phong";
            this.Phong.Width = 125;
            // 
            // NgayHoc
            // 
            this.NgayHoc.DataPropertyName = "NgayHoc";
            this.NgayHoc.HeaderText = "Ngày học";
            this.NgayHoc.Name = "NgayHoc";
            this.NgayHoc.Width = 125;
            // 
            // Chon
            // 
            this.Chon.DataPropertyName = "Chon";
            this.Chon.HeaderText = "Chọn";
            this.Chon.Name = "Chon";
            this.Chon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Chon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // cboLopHoc
            // 
            this.cboLopHoc.FormattingEnabled = true;
            this.cboLopHoc.Location = new System.Drawing.Point(437, 143);
            this.cboLopHoc.Name = "cboLopHoc";
            this.cboLopHoc.Size = new System.Drawing.Size(121, 28);
            this.cboLopHoc.TabIndex = 10;
            this.cboLopHoc.SelectedIndexChanged += new System.EventHandler(this.cboLopHoc_SelectedIndexChanged);
            // 
            // cboBuoiHoc
            // 
            this.cboBuoiHoc.FormattingEnabled = true;
            this.cboBuoiHoc.Location = new System.Drawing.Point(707, 143);
            this.cboBuoiHoc.Name = "cboBuoiHoc";
            this.cboBuoiHoc.Size = new System.Drawing.Size(121, 28);
            this.cboBuoiHoc.TabIndex = 11;
            this.cboBuoiHoc.SelectedIndexChanged += new System.EventHandler(this.cboBuoiHoc_SelectedIndexChanged);
            // 
            // lblLopHoc
            // 
            this.lblLopHoc.AutoSize = true;
            this.lblLopHoc.Location = new System.Drawing.Point(350, 143);
            this.lblLopHoc.Name = "lblLopHoc";
            this.lblLopHoc.Size = new System.Drawing.Size(72, 20);
            this.lblLopHoc.TabIndex = 8;
            this.lblLopHoc.Text = "Lớp Học:";
            // 
            // lblBuoiHoc
            // 
            this.lblBuoiHoc.AutoSize = true;
            this.lblBuoiHoc.Location = new System.Drawing.Point(615, 146);
            this.lblBuoiHoc.Name = "lblBuoiHoc";
            this.lblBuoiHoc.Size = new System.Drawing.Size(75, 20);
            this.lblBuoiHoc.TabIndex = 9;
            this.lblBuoiHoc.Text = "Buổi học:";
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.Location = new System.Drawing.Point(985, 399);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(75, 27);
            this.btnHuyBo.TabIndex = 6;
            this.btnHuyBo.Text = "Hủy bỏ";
            this.btnHuyBo.UseVisualStyleBackColor = true;
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(985, 274);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 27);
            this.btnLuu.TabIndex = 7;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // lblMakeUpClass
            // 
            this.lblMakeUpClass.AutoSize = true;
            this.lblMakeUpClass.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMakeUpClass.Location = new System.Drawing.Point(482, 45);
            this.lblMakeUpClass.Name = "lblMakeUpClass";
            this.lblMakeUpClass.Size = new System.Drawing.Size(247, 41);
            this.lblMakeUpClass.TabIndex = 12;
            this.lblMakeUpClass.Text = "MakeUpClass";
            // 
            // MakeUpClass_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblMakeUpClass);
            this.Controls.Add(this.dgvMUC);
            this.Controls.Add(this.cboLopHoc);
            this.Controls.Add(this.cboBuoiHoc);
            this.Controls.Add(this.lblLopHoc);
            this.Controls.Add(this.lblBuoiHoc);
            this.Controls.Add(this.btnHuyBo);
            this.Controls.Add(this.btnLuu);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MakeUpClass_UserControl";
            this.Size = new System.Drawing.Size(1233, 674);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMUC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
            // 
            // dgvMUC
            // 
            this.dgvMUC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMUC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaGiaoVien,
            this.MaLop,
            this.Buoi,
            this.Phong,
            this.NgayHoc,
            this.Chon});
            this.dgvMUC.Location = new System.Drawing.Point(96, 237);
            this.dgvMUC.Name = "dgvMUC";
            this.dgvMUC.Size = new System.Drawing.Size(778, 323);
            this.dgvMUC.TabIndex = 5;
            this.dgvMUC.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMUC_CellValueChanged);
            this.dgvMUC.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvMUC_CurrentCellDirtyStateChanged);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMUC;
        private System.Windows.Forms.ComboBox cboLopHoc;
        private System.Windows.Forms.ComboBox cboBuoiHoc;
        private System.Windows.Forms.Label lblLopHoc;
        private System.Windows.Forms.Label lblBuoiHoc;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGiaoVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Buoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phong;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayHoc;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Chon;
        private System.Windows.Forms.Label lblMakeUpClass;
    }
}
