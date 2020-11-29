namespace ProjectHQTCSDL.Usercontrol
{
    partial class Reports_Employees_UserControl
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
            this.btnClassOfCourse = new System.Windows.Forms.Button();
            this.btnRevenueCenter = new System.Windows.Forms.Button();
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
            this.panel2.TabIndex = 6;
            // 
            // lblDashboardStudent
            // 
            this.lblDashboardStudent.AutoSize = true;
            this.lblDashboardStudent.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboardStudent.Location = new System.Drawing.Point(18, 12);
            this.lblDashboardStudent.Name = "lblDashboardStudent";
            this.lblDashboardStudent.Size = new System.Drawing.Size(400, 33);
            this.lblDashboardStudent.TabIndex = 0;
            this.lblDashboardStudent.Text = "Generate Employees Reports";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnClassOfCourse);
            this.flowLayoutPanel1.Controls.Add(this.btnRevenueCenter);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(115, 88);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(437, 195);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // btnClassOfCourse
            // 
            this.btnClassOfCourse.BackColor = System.Drawing.Color.Blue;
            this.btnClassOfCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClassOfCourse.ForeColor = System.Drawing.Color.White;
            this.btnClassOfCourse.Location = new System.Drawing.Point(3, 3);
            this.btnClassOfCourse.Name = "btnClassOfCourse";
            this.btnClassOfCourse.Size = new System.Drawing.Size(200, 100);
            this.btnClassOfCourse.TabIndex = 1;
            this.btnClassOfCourse.Text = "Class of Course";
            this.btnClassOfCourse.UseVisualStyleBackColor = false;
            this.btnClassOfCourse.Click += new System.EventHandler(this.btnClassOfCourse_Click);
            // 
            // btnRevenueCenter
            // 
            this.btnRevenueCenter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRevenueCenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevenueCenter.ForeColor = System.Drawing.Color.White;
            this.btnRevenueCenter.Location = new System.Drawing.Point(209, 3);
            this.btnRevenueCenter.Name = "btnRevenueCenter";
            this.btnRevenueCenter.Size = new System.Drawing.Size(200, 100);
            this.btnRevenueCenter.TabIndex = 1;
            this.btnRevenueCenter.Text = "Revenue Center";
            this.btnRevenueCenter.UseVisualStyleBackColor = false;
            this.btnRevenueCenter.Click += new System.EventHandler(this.btnRevenueCenter_Click);
            // 
            // Reports_Employees_UserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Name = "Reports_Employees_UserControl";
            this.Size = new System.Drawing.Size(1233, 332);
            this.Load += new System.EventHandler(this.Reports_Employees_UserControl_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDashboardStudent;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnClassOfCourse;
        private System.Windows.Forms.Button btnRevenueCenter;
    }
}
