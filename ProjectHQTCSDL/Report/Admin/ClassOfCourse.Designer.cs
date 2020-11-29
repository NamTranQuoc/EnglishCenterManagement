namespace ProjectHQTCSDL.Report.Admin
{
    partial class ClassOfCourse
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
            this.rvwClassOfCourse = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lopThuocKhoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trungTamAnhNgu = new ProjectHQTCSDL.DataSet.TrungTamAnhNgu();
            this.lopThuocKhoaTableAdapter = new ProjectHQTCSDL.DataSet.TrungTamAnhNguTableAdapters.LopThuocKhoaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.lopThuocKhoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trungTamAnhNgu)).BeginInit();
            this.SuspendLayout();
            // 
            // rvwClassOfCourse
            // 
            this.rvwClassOfCourse.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetClassOfCourse";
            reportDataSource1.Value = this.lopThuocKhoaBindingSource;
            this.rvwClassOfCourse.LocalReport.DataSources.Add(reportDataSource1);
            this.rvwClassOfCourse.LocalReport.ReportEmbeddedResource = "ProjectHQTCSDL.Report.Admin.ClassOfCourse.rdlc";
            this.rvwClassOfCourse.Location = new System.Drawing.Point(0, 0);
            this.rvwClassOfCourse.Name = "rvwClassOfCourse";
            this.rvwClassOfCourse.ServerReport.BearerToken = null;
            this.rvwClassOfCourse.Size = new System.Drawing.Size(800, 450);
            this.rvwClassOfCourse.TabIndex = 0;
            // 
            // lopThuocKhoaBindingSource
            // 
            this.lopThuocKhoaBindingSource.DataMember = "LopThuocKhoa";
            this.lopThuocKhoaBindingSource.DataSource = this.trungTamAnhNgu;
            // 
            // trungTamAnhNgu
            // 
            this.trungTamAnhNgu.DataSetName = "TrungTamAnhNgu";
            this.trungTamAnhNgu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lopThuocKhoaTableAdapter
            // 
            this.lopThuocKhoaTableAdapter.ClearBeforeFill = true;
            // 
            // ClassOfCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rvwClassOfCourse);
            this.Name = "ClassOfCourse";
            this.Text = "ClassOfCourse";
            this.Load += new System.EventHandler(this.ClassOfCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lopThuocKhoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trungTamAnhNgu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DataSet.TrungTamAnhNgu trungTamAnhNgu;
        private System.Windows.Forms.BindingSource lopThuocKhoaBindingSource;
        private DataSet.TrungTamAnhNguTableAdapters.LopThuocKhoaTableAdapter lopThuocKhoaTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer rvwClassOfCourse;
    }
}