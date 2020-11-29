
namespace ProjectHQTCSDL.Usercontrol
{
    partial class Guest_UserControl
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
            this.dgvGuest = new System.Windows.Forms.DataGridView();
            this.MaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoHocVienDuKien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CaHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayHocTrongTuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTieuDe = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuest)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGuest
            // 
            this.dgvGuest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGuest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLop,
            this.SoHocVienDuKien,
            this.CaHoc,
            this.NgayHocTrongTuan});
            this.dgvGuest.Location = new System.Drawing.Point(202, 138);
            this.dgvGuest.Name = "dgvGuest";
            this.dgvGuest.Size = new System.Drawing.Size(808, 418);
            this.dgvGuest.TabIndex = 0;
            // 
            // MaLop
            // 
            this.MaLop.DataPropertyName = "MaLop";
            this.MaLop.HeaderText = "Mã Lớp";
            this.MaLop.Name = "MaLop";
            // 
            // SoHocVienDuKien
            // 
            this.SoHocVienDuKien.DataPropertyName = "SoHocVienDuKien";
            this.SoHocVienDuKien.HeaderText = "Số Học Viên Dự Kiến";
            this.SoHocVienDuKien.Name = "SoHocVienDuKien";
            this.SoHocVienDuKien.Width = 180;
            // 
            // CaHoc
            // 
            this.CaHoc.DataPropertyName = "CaHoc";
            this.CaHoc.HeaderText = "Ca Học";
            this.CaHoc.Name = "CaHoc";
            // 
            // NgayHocTrongTuan
            // 
            this.NgayHocTrongTuan.DataPropertyName = "NgayHocTrongTuan";
            this.NgayHocTrongTuan.HeaderText = "Ngày Học Trong Tuần";
            this.NgayHocTrongTuan.Name = "NgayHocTrongTuan";
            this.NgayHocTrongTuan.Width = 180;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.Location = new System.Drawing.Point(466, 41);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(257, 33);
            this.lblTieuDe.TabIndex = 1;
            this.lblTieuDe.Text = "CLASSES TOEIC";
            // 
            // Guest_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.dgvGuest);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Guest_UserControl";
            this.Size = new System.Drawing.Size(1233, 674);
            this.Load += new System.EventHandler(this.Guest_UserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGuest;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoHocVienDuKien;
        private System.Windows.Forms.DataGridViewTextBoxColumn CaHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayHocTrongTuan;
        private System.Windows.Forms.Label lblTieuDe;
    }
}
