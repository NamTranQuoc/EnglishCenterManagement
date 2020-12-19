
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
         this.btnStudentsInClass = new System.Windows.Forms.Button();
         this.btnTeacherOfTheCourse = new System.Windows.Forms.Button();
         this.btnClassOfCourse = new System.Windows.Forms.Button();
         this.btnRevenueCenter = new System.Windows.Forms.Button();
         this.panel1 = new System.Windows.Forms.Panel();
         this.rpv = new Microsoft.Reporting.WinForms.ReportViewer();
         this.panel1.SuspendLayout();
         this.SuspendLayout();
         // 
         // btnStudentsInClass
         // 
         this.btnStudentsInClass.BackColor = System.Drawing.Color.SeaGreen;
         this.btnStudentsInClass.ForeColor = System.Drawing.Color.White;
         this.btnStudentsInClass.Location = new System.Drawing.Point(185, 27);
         this.btnStudentsInClass.Name = "btnStudentsInClass";
         this.btnStudentsInClass.Size = new System.Drawing.Size(204, 38);
         this.btnStudentsInClass.TabIndex = 1;
         this.btnStudentsInClass.Text = "Students In Class";
         this.btnStudentsInClass.UseVisualStyleBackColor = false;
         this.btnStudentsInClass.Click += new System.EventHandler(this.btnStudentsInClass_Click);
         // 
         // btnTeacherOfTheCourse
         // 
         this.btnTeacherOfTheCourse.BackColor = System.Drawing.Color.SeaGreen;
         this.btnTeacherOfTheCourse.ForeColor = System.Drawing.Color.White;
         this.btnTeacherOfTheCourse.Location = new System.Drawing.Point(391, 27);
         this.btnTeacherOfTheCourse.Name = "btnTeacherOfTheCourse";
         this.btnTeacherOfTheCourse.Size = new System.Drawing.Size(204, 38);
         this.btnTeacherOfTheCourse.TabIndex = 1;
         this.btnTeacherOfTheCourse.Text = "Teacher Of The Course";
         this.btnTeacherOfTheCourse.UseVisualStyleBackColor = false;
         this.btnTeacherOfTheCourse.Click += new System.EventHandler(this.btnTeacherOfTheCourse_Click);
         // 
         // btnClassOfCourse
         // 
         this.btnClassOfCourse.BackColor = System.Drawing.Color.SeaGreen;
         this.btnClassOfCourse.ForeColor = System.Drawing.Color.White;
         this.btnClassOfCourse.Location = new System.Drawing.Point(597, 27);
         this.btnClassOfCourse.Name = "btnClassOfCourse";
         this.btnClassOfCourse.Size = new System.Drawing.Size(204, 38);
         this.btnClassOfCourse.TabIndex = 1;
         this.btnClassOfCourse.Text = "Class Of Course";
         this.btnClassOfCourse.UseVisualStyleBackColor = false;
         this.btnClassOfCourse.Click += new System.EventHandler(this.btnClassOfCourse_Click);
         // 
         // btnRevenueCenter
         // 
         this.btnRevenueCenter.BackColor = System.Drawing.Color.SeaGreen;
         this.btnRevenueCenter.ForeColor = System.Drawing.Color.White;
         this.btnRevenueCenter.Location = new System.Drawing.Point(803, 27);
         this.btnRevenueCenter.Name = "btnRevenueCenter";
         this.btnRevenueCenter.Size = new System.Drawing.Size(204, 38);
         this.btnRevenueCenter.TabIndex = 1;
         this.btnRevenueCenter.Text = "Revenue Center";
         this.btnRevenueCenter.UseVisualStyleBackColor = false;
         this.btnRevenueCenter.Click += new System.EventHandler(this.btnRevenueCenter_Click);
         // 
         // panel1
         // 
         this.panel1.Controls.Add(this.btnRevenueCenter);
         this.panel1.Controls.Add(this.btnStudentsInClass);
         this.panel1.Controls.Add(this.btnClassOfCourse);
         this.panel1.Controls.Add(this.btnTeacherOfTheCourse);
         this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
         this.panel1.Location = new System.Drawing.Point(0, 0);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(1233, 86);
         this.panel1.TabIndex = 2;
         // 
         // rpv
         // 
         this.rpv.Location = new System.Drawing.Point(235, 92);
         this.rpv.Name = "rpv";
         this.rpv.ServerReport.BearerToken = null;
         this.rpv.Size = new System.Drawing.Size(663, 579);
         this.rpv.TabIndex = 3;
         // 
         // Reports_UserControl
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.White;
         this.Controls.Add(this.rpv);
         this.Controls.Add(this.panel1);
         this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.Name = "Reports_UserControl";
         this.Size = new System.Drawing.Size(1233, 674);
         this.panel1.ResumeLayout(false);
         this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStudentsInClass;
        private System.Windows.Forms.Button btnTeacherOfTheCourse;
        private System.Windows.Forms.Button btnClassOfCourse;
        private System.Windows.Forms.Button btnRevenueCenter;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer rpv;
    }
}
