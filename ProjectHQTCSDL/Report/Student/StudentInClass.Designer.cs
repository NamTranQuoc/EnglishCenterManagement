namespace ProjectHQTCSDL.Report.Student
{
    partial class StudentInClass
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
            this.hocVienThuocLopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trungTamAnhNgu = new ProjectHQTCSDL.DataSet.TrungTamAnhNgu();
            this.rvwStudentInClass = new Microsoft.Reporting.WinForms.ReportViewer();
            this.hocVienThuocLopTableAdapter = new ProjectHQTCSDL.DataSet.TrungTamAnhNguTableAdapters.HocVienThuocLopTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.hocVienThuocLopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trungTamAnhNgu)).BeginInit();
            this.SuspendLayout();
            // 
            // hocVienThuocLopBindingSource
            // 
            this.hocVienThuocLopBindingSource.DataMember = "HocVienThuocLop";
            this.hocVienThuocLopBindingSource.DataSource = this.trungTamAnhNgu;
            // 
            // trungTamAnhNgu
            // 
            this.trungTamAnhNgu.DataSetName = "TrungTamAnhNgu";
            this.trungTamAnhNgu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rvwStudentInClass
            // 
            this.rvwStudentInClass.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetStudentInClass";
            reportDataSource1.Value = this.hocVienThuocLopBindingSource;
            this.rvwStudentInClass.LocalReport.DataSources.Add(reportDataSource1);
            this.rvwStudentInClass.LocalReport.ReportEmbeddedResource = "ProjectHQTCSDL.Report.Student.StudentInClass.rdlc";
            this.rvwStudentInClass.Location = new System.Drawing.Point(0, 0);
            this.rvwStudentInClass.Name = "rvwStudentInClass";
            this.rvwStudentInClass.ServerReport.BearerToken = null;
            this.rvwStudentInClass.Size = new System.Drawing.Size(800, 450);
            this.rvwStudentInClass.TabIndex = 0;
            // 
            // hocVienThuocLopTableAdapter
            // 
            this.hocVienThuocLopTableAdapter.ClearBeforeFill = true;
            // 
            // StudentInClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rvwStudentInClass);
            this.Name = "StudentInClass";
            this.Text = "StudentInClass";
            this.Load += new System.EventHandler(this.StudentInClass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hocVienThuocLopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trungTamAnhNgu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvwStudentInClass;
        private DataSet.TrungTamAnhNgu trungTamAnhNgu;
        private System.Windows.Forms.BindingSource hocVienThuocLopBindingSource;
        private DataSet.TrungTamAnhNguTableAdapters.HocVienThuocLopTableAdapter hocVienThuocLopTableAdapter;
    }
}