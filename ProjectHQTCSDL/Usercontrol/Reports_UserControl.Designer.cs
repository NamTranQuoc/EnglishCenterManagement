
namespace ProjectHQTCSDL.Usercontrol
{
    partial class Reports_UserControl
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnStudentReport = new System.Windows.Forms.Button();
            this.btnEmployeeReport = new System.Windows.Forms.Button();
            this.btnTeacherReport = new System.Windows.Forms.Button();
            this.Title_UserControl = new System.Windows.Forms.UserControl();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnStudentReport);
            this.flowLayoutPanel1.Controls.Add(this.btnEmployeeReport);
            this.flowLayoutPanel1.Controls.Add(this.btnTeacherReport);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(287, 73);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(619, 106);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnStudentReport
            // 
            this.btnStudentReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnStudentReport.ForeColor = System.Drawing.Color.White;
            this.btnStudentReport.Location = new System.Drawing.Point(3, 3);
            this.btnStudentReport.Name = "btnStudentReport";
            this.btnStudentReport.Size = new System.Drawing.Size(200, 100);
            this.btnStudentReport.TabIndex = 0;
            this.btnStudentReport.Text = "Student Reports";
            this.btnStudentReport.UseVisualStyleBackColor = false;
            this.btnStudentReport.Click += new System.EventHandler(this.btnStudentReport_Click);
            // 
            // btnEmployeeReport
            // 
            this.btnEmployeeReport.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEmployeeReport.ForeColor = System.Drawing.Color.White;
            this.btnEmployeeReport.Location = new System.Drawing.Point(209, 3);
            this.btnEmployeeReport.Name = "btnEmployeeReport";
            this.btnEmployeeReport.Size = new System.Drawing.Size(200, 100);
            this.btnEmployeeReport.TabIndex = 0;
            this.btnEmployeeReport.Text = "Employee Reports";
            this.btnEmployeeReport.UseVisualStyleBackColor = false;
            this.btnEmployeeReport.Click += new System.EventHandler(this.btnEmployeeReport_Click);
            // 
            // btnTeacherReport
            // 
            this.btnTeacherReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTeacherReport.ForeColor = System.Drawing.Color.White;
            this.btnTeacherReport.Location = new System.Drawing.Point(415, 3);
            this.btnTeacherReport.Name = "btnTeacherReport";
            this.btnTeacherReport.Size = new System.Drawing.Size(200, 100);
            this.btnTeacherReport.TabIndex = 0;
            this.btnTeacherReport.Text = "Teacher Reports";
            this.btnTeacherReport.UseVisualStyleBackColor = false;
            this.btnTeacherReport.Click += new System.EventHandler(this.btnTeacherReport_Click);
            // 
            // Title_UserControl
            // 
            this.Title_UserControl.BackColor = System.Drawing.Color.White;
            this.Title_UserControl.Location = new System.Drawing.Point(0, 342);
            this.Title_UserControl.Name = "Title_UserControl";
            this.Title_UserControl.Size = new System.Drawing.Size(1233, 332);
            this.Title_UserControl.TabIndex = 1;
            // 
            // Reports_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Title_UserControl);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Reports_UserControl";
            this.Size = new System.Drawing.Size(1233, 674);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnStudentReport;
        private System.Windows.Forms.Button btnEmployeeReport;
        private System.Windows.Forms.Button btnTeacherReport;
        private System.Windows.Forms.UserControl Title_UserControl;
    }
}
