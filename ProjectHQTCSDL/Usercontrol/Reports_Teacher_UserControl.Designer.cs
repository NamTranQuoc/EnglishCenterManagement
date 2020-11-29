namespace ProjectHQTCSDL.Usercontrol
{
    partial class Reports_Teacher_UserControl
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDashboardStudent = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTeacherOfTheCourse = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaGreen;
            this.panel2.Controls.Add(this.lblDashboardStudent);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1233, 57);
            this.panel2.TabIndex = 7;
            // 
            // lblDashboardStudent
            // 
            this.lblDashboardStudent.AutoSize = true;
            this.lblDashboardStudent.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboardStudent.Location = new System.Drawing.Point(18, 12);
            this.lblDashboardStudent.Name = "lblDashboardStudent";
            this.lblDashboardStudent.Size = new System.Drawing.Size(363, 33);
            this.lblDashboardStudent.TabIndex = 0;
            this.lblDashboardStudent.Text = "Generate Teacher Reports";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnTeacherOfTheCourse);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(122, 100);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(387, 181);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // btnTeacherOfTheCourse
            // 
            this.btnTeacherOfTheCourse.BackColor = System.Drawing.Color.Blue;
            this.btnTeacherOfTheCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeacherOfTheCourse.ForeColor = System.Drawing.Color.White;
            this.btnTeacherOfTheCourse.Location = new System.Drawing.Point(3, 3);
            this.btnTeacherOfTheCourse.Name = "btnTeacherOfTheCourse";
            this.btnTeacherOfTheCourse.Size = new System.Drawing.Size(200, 100);
            this.btnTeacherOfTheCourse.TabIndex = 2;
            this.btnTeacherOfTheCourse.Text = "Teacher Of The Course";
            this.btnTeacherOfTheCourse.UseVisualStyleBackColor = false;
            this.btnTeacherOfTheCourse.Click += new System.EventHandler(this.btnTeacherOfTheCourse_Click);
            // 
            // Reports_Teacher_UserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Name = "Reports_Teacher_UserControl";
            this.Size = new System.Drawing.Size(1233, 332);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDashboardStudent;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnTeacherOfTheCourse;
    }
}
