namespace ProjectHQTCSDL.Report.Admin
{
    partial class Revenue
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
            this.doanhThuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trungTamAnhNgu = new ProjectHQTCSDL.DataSet.TrungTamAnhNgu();
            this.rvwRevenue = new Microsoft.Reporting.WinForms.ReportViewer();
            this.doanhThuTableAdapter = new ProjectHQTCSDL.DataSet.TrungTamAnhNguTableAdapters.DoanhThuTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.doanhThuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trungTamAnhNgu)).BeginInit();
            this.SuspendLayout();
            // 
            // doanhThuBindingSource
            // 
            this.doanhThuBindingSource.DataMember = "DoanhThu";
            this.doanhThuBindingSource.DataSource = this.trungTamAnhNgu;
            // 
            // trungTamAnhNgu
            // 
            this.trungTamAnhNgu.DataSetName = "TrungTamAnhNgu";
            this.trungTamAnhNgu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rvwRevenue
            // 
            this.rvwRevenue.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetRevenue";
            reportDataSource1.Value = this.doanhThuBindingSource;
            this.rvwRevenue.LocalReport.DataSources.Add(reportDataSource1);
            this.rvwRevenue.LocalReport.ReportEmbeddedResource = "ProjectHQTCSDL.Report.Admin.Revenue.rdlc";
            this.rvwRevenue.Location = new System.Drawing.Point(0, 0);
            this.rvwRevenue.Name = "rvwRevenue";
            this.rvwRevenue.ServerReport.BearerToken = null;
            this.rvwRevenue.Size = new System.Drawing.Size(622, 450);
            this.rvwRevenue.TabIndex = 0;
            // 
            // doanhThuTableAdapter
            // 
            this.doanhThuTableAdapter.ClearBeforeFill = true;
            // 
            // Revenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 450);
            this.Controls.Add(this.rvwRevenue);
            this.Name = "Revenue";
            this.Text = "Revenue";
            this.Load += new System.EventHandler(this.Revenue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.doanhThuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trungTamAnhNgu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvwRevenue;
        private DataSet.TrungTamAnhNgu trungTamAnhNgu;
        private System.Windows.Forms.BindingSource doanhThuBindingSource;
        private DataSet.TrungTamAnhNguTableAdapters.DoanhThuTableAdapter doanhThuTableAdapter;
    }
}