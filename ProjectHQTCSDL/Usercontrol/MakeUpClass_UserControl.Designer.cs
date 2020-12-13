
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
            this.cboClass = new System.Windows.Forms.ComboBox();
            this.cboSession = new System.Windows.Forms.ComboBox();
            this.lblLopHoc = new System.Windows.Forms.Label();
            this.lblBuoiHoc = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblMakeUpClass = new System.Windows.Forms.Label();
            this.MaGiaoVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Buoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chon = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMUC)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMUC
            // 
            this.dgvMUC.AllowUserToAddRows = false;
            this.dgvMUC.AllowUserToDeleteRows = false;
            this.dgvMUC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMUC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaGiaoVien,
            this.MaLop,
            this.Buoi,
            this.Phong,
            this.NgayHoc,
            this.Chon});
            this.dgvMUC.Location = new System.Drawing.Point(236, 221);
            this.dgvMUC.Name = "dgvMUC";
            this.dgvMUC.ReadOnly = true;
            this.dgvMUC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMUC.Size = new System.Drawing.Size(787, 323);
            this.dgvMUC.TabIndex = 13;
            this.dgvMUC.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMUC_CellEnter);
            // 
            // cboClass
            // 
            this.cboClass.FormattingEnabled = true;
            this.cboClass.Location = new System.Drawing.Point(428, 140);
            this.cboClass.Name = "cboClass";
            this.cboClass.Size = new System.Drawing.Size(121, 28);
            this.cboClass.TabIndex = 10;
            this.cboClass.SelectedIndexChanged += new System.EventHandler(this.cboClass_SelectedIndexChanged);
            // 
            // cboSession
            // 
            this.cboSession.FormattingEnabled = true;
            this.cboSession.Location = new System.Drawing.Point(696, 140);
            this.cboSession.Name = "cboSession";
            this.cboSession.Size = new System.Drawing.Size(121, 28);
            this.cboSession.TabIndex = 11;
            this.cboSession.SelectedIndexChanged += new System.EventHandler(this.cboSession_SelectedIndexChanged);
            // 
            // lblLopHoc
            // 
            this.lblLopHoc.AutoSize = true;
            this.lblLopHoc.Location = new System.Drawing.Point(350, 143);
            this.lblLopHoc.Name = "lblLopHoc";
            this.lblLopHoc.Size = new System.Drawing.Size(50, 20);
            this.lblLopHoc.TabIndex = 8;
            this.lblLopHoc.Text = "Class:";
            // 
            // lblBuoiHoc
            // 
            this.lblBuoiHoc.AutoSize = true;
            this.lblBuoiHoc.Location = new System.Drawing.Point(615, 143);
            this.lblBuoiHoc.Name = "lblBuoiHoc";
            this.lblBuoiHoc.Size = new System.Drawing.Size(64, 20);
            this.lblBuoiHoc.TabIndex = 9;
            this.lblBuoiHoc.Text = "Session:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(911, 588);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 38);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Enroll";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            // MaGiaoVien
            // 
            this.MaGiaoVien.DataPropertyName = "IdTeacher";
            this.MaGiaoVien.HeaderText = "ID Teacher";
            this.MaGiaoVien.Name = "MaGiaoVien";
            this.MaGiaoVien.ReadOnly = true;
            this.MaGiaoVien.Width = 140;
            // 
            // MaLop
            // 
            this.MaLop.DataPropertyName = "IdClass";
            this.MaLop.HeaderText = "ID Class";
            this.MaLop.Name = "MaLop";
            this.MaLop.ReadOnly = true;
            this.MaLop.Width = 125;
            // 
            // Buoi
            // 
            this.Buoi.DataPropertyName = "Session";
            this.Buoi.HeaderText = "Session";
            this.Buoi.Name = "Buoi";
            this.Buoi.ReadOnly = true;
            this.Buoi.Width = 125;
            // 
            // Phong
            // 
            this.Phong.DataPropertyName = "NameClassroom";
            this.Phong.HeaderText = "Classroom";
            this.Phong.Name = "Phong";
            this.Phong.ReadOnly = true;
            this.Phong.Width = 125;
            // 
            // NgayHoc
            // 
            this.NgayHoc.DataPropertyName = "Day";
            this.NgayHoc.HeaderText = "Day";
            this.NgayHoc.Name = "NgayHoc";
            this.NgayHoc.ReadOnly = true;
            this.NgayHoc.Width = 125;
            // 
            // Chon
            // 
            this.Chon.DataPropertyName = "Select";
            this.Chon.HeaderText = "Select";
            this.Chon.Name = "Chon";
            this.Chon.ReadOnly = true;
            this.Chon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Chon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // MakeUpClass_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblMakeUpClass);
            this.Controls.Add(this.dgvMUC);
            this.Controls.Add(this.cboClass);
            this.Controls.Add(this.cboSession);
            this.Controls.Add(this.lblLopHoc);
            this.Controls.Add(this.lblBuoiHoc);
            this.Controls.Add(this.btnSave);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MakeUpClass_UserControl";
            this.Size = new System.Drawing.Size(1233, 674);
            this.Load += new System.EventHandler(this.MakeUpClass_UserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMUC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMUC;
        private System.Windows.Forms.ComboBox cboClass;
        private System.Windows.Forms.ComboBox cboSession;
        private System.Windows.Forms.Label lblLopHoc;
        private System.Windows.Forms.Label lblBuoiHoc;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblMakeUpClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGiaoVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Buoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phong;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayHoc;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Chon;
    }
}
