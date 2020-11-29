namespace ProjectHQTCSDL.Report.Teacher
{
    partial class TeacherOfTheCourse
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rvwTeacherOfTheCourse = new Microsoft.Reporting.WinForms.ReportViewer();
            this.trungTamAnhNgu = new ProjectHQTCSDL.DataSet.TrungTamAnhNgu();
            this.giaoVienThuocKhoaHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.giaoVienThuocKhoaHocTableAdapter = new ProjectHQTCSDL.DataSet.TrungTamAnhNguTableAdapters.GiaoVienThuocKhoaHocTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.trungTamAnhNgu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaoVienThuocKhoaHocBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rvwTeacherOfTheCourse
            // 
            this.rvwTeacherOfTheCourse.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetTeacherOfTheCourse";
            reportDataSource1.Value = this.giaoVienThuocKhoaHocBindingSource;
            this.rvwTeacherOfTheCourse.LocalReport.DataSources.Add(reportDataSource1);
            this.rvwTeacherOfTheCourse.LocalReport.ReportEmbeddedResource = "ProjectHQTCSDL.Report.Teacher.TeacherOfTheCourse.rdlc";
            this.rvwTeacherOfTheCourse.Location = new System.Drawing.Point(0, 0);
            this.rvwTeacherOfTheCourse.Name = "rvwTeacherOfTheCourse";
            this.rvwTeacherOfTheCourse.ServerReport.BearerToken = null;
            this.rvwTeacherOfTheCourse.Size = new System.Drawing.Size(800, 450);
            this.rvwTeacherOfTheCourse.TabIndex = 0;
            // 
            // trungTamAnhNgu
            // 
            this.trungTamAnhNgu.DataSetName = "TrungTamAnhNgu";
            this.trungTamAnhNgu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // giaoVienThuocKhoaHocBindingSource
            // 
            this.giaoVienThuocKhoaHocBindingSource.DataMember = "GiaoVienThuocKhoaHoc";
            this.giaoVienThuocKhoaHocBindingSource.DataSource = this.trungTamAnhNgu;
            // 
            // giaoVienThuocKhoaHocTableAdapter
            // 
            this.giaoVienThuocKhoaHocTableAdapter.ClearBeforeFill = true;
            // 
            // TeacherOfTheCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rvwTeacherOfTheCourse);
            this.Name = "TeacherOfTheCourse";
            this.Text = "TeacherOfTheCourse";
            this.Load += new System.EventHandler(this.TeacherOfTheCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trungTamAnhNgu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaoVienThuocKhoaHocBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvwTeacherOfTheCourse;
        private DataSet.TrungTamAnhNgu trungTamAnhNgu;
        private System.Windows.Forms.BindingSource giaoVienThuocKhoaHocBindingSource;
        private DataSet.TrungTamAnhNguTableAdapters.GiaoVienThuocKhoaHocTableAdapter giaoVienThuocKhoaHocTableAdapter;
    }
}