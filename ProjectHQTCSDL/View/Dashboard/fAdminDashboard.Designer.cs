
namespace ProjectHQTCSDL.View.Dashboard
{
    partial class fAdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAdminDashboard));
            this.pUserControl = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExpenses = new System.Windows.Forms.Button();
            this.btnCource = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnClass = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            this.btnTeacher = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnDelSchedule = new System.Windows.Forms.Button();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pUserControl
            // 
            this.pUserControl.BackColor = System.Drawing.Color.White;
            this.pUserControl.Location = new System.Drawing.Point(227, 83);
            this.pUserControl.Name = "pUserControl";
            this.pUserControl.Size = new System.Drawing.Size(1233, 674);
            this.pUserControl.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaGreen;
            this.panel2.Controls.Add(this.label1);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(227, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1233, 81);
            this.panel2.TabIndex = 10;
            this.panel2.TabStop = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Dashboard";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this.btnExpenses);
            this.panel1.Controls.Add(this.btnCource);
            this.panel1.Controls.Add(this.btnReport);
            this.panel1.Controls.Add(this.btnClass);
            this.panel1.Controls.Add(this.btnStudent);
            this.panel1.Controls.Add(this.btnTeacher);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnDelSchedule);
            this.panel1.Controls.Add(this.btnSchedule);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 756);
            this.panel1.TabIndex = 9;
            this.panel1.TabStop = true;
            // 
            // btnExpenses
            // 
            this.btnExpenses.BackgroundImage = global::ProjectHQTCSDL.Properties.Resources.expenses;
            this.btnExpenses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExpenses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpenses.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpenses.Location = new System.Drawing.Point(20, 589);
            this.btnExpenses.Name = "btnExpenses";
            this.btnExpenses.Size = new System.Drawing.Size(181, 41);
            this.btnExpenses.TabIndex = 10;
            this.btnExpenses.Text = "Expenses";
            this.btnExpenses.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExpenses.UseVisualStyleBackColor = true;
            this.btnExpenses.Click += new System.EventHandler(this.btnExpenses_Click);
            // 
            // btnCource
            // 
            this.btnCource.BackgroundImage = global::ProjectHQTCSDL.Properties.Resources.cource;
            this.btnCource.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCource.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCource.Location = new System.Drawing.Point(20, 520);
            this.btnCource.Name = "btnCource";
            this.btnCource.Size = new System.Drawing.Size(181, 41);
            this.btnCource.TabIndex = 9;
            this.btnCource.Text = "Cources";
            this.btnCource.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCource.UseVisualStyleBackColor = true;
            this.btnCource.Click += new System.EventHandler(this.btnCource_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackgroundImage = global::ProjectHQTCSDL.Properties.Resources.report;
            this.btnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Location = new System.Drawing.Point(20, 450);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(181, 41);
            this.btnReport.TabIndex = 8;
            this.btnReport.Text = "Reports";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnClass
            // 
            this.btnClass.BackgroundImage = global::ProjectHQTCSDL.Properties.Resources._class;
            this.btnClass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClass.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClass.Location = new System.Drawing.Point(20, 380);
            this.btnClass.Name = "btnClass";
            this.btnClass.Size = new System.Drawing.Size(181, 41);
            this.btnClass.TabIndex = 6;
            this.btnClass.Text = "Classes";
            this.btnClass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClass.UseVisualStyleBackColor = true;
            this.btnClass.Click += new System.EventHandler(this.btnClass_Click);
            // 
            // btnStudent
            // 
            this.btnStudent.BackgroundImage = global::ProjectHQTCSDL.Properties.Resources.student;
            this.btnStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudent.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudent.Location = new System.Drawing.Point(20, 240);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(181, 41);
            this.btnStudent.TabIndex = 5;
            this.btnStudent.Text = "Students";
            this.btnStudent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStudent.UseVisualStyleBackColor = true;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // btnTeacher
            // 
            this.btnTeacher.BackgroundImage = global::ProjectHQTCSDL.Properties.Resources.teacher;
            this.btnTeacher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeacher.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeacher.Location = new System.Drawing.Point(20, 170);
            this.btnTeacher.Name = "btnTeacher";
            this.btnTeacher.Size = new System.Drawing.Size(181, 41);
            this.btnTeacher.TabIndex = 4;
            this.btnTeacher.Text = "Teachers";
            this.btnTeacher.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTeacher.UseVisualStyleBackColor = true;
            this.btnTeacher.Click += new System.EventHandler(this.btnTeacher_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackgroundImage = global::ProjectHQTCSDL.Properties.Resources.Logout;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(20, 684);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(181, 41);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnDelSchedule
            // 
            this.btnDelSchedule.BackgroundImage = global::ProjectHQTCSDL.Properties.Resources.enroll;
            this.btnDelSchedule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDelSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelSchedule.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelSchedule.Location = new System.Drawing.Point(20, 310);
            this.btnDelSchedule.Name = "btnDelSchedule";
            this.btnDelSchedule.Size = new System.Drawing.Size(181, 41);
            this.btnDelSchedule.TabIndex = 1;
            this.btnDelSchedule.Text = "Delete schedule";
            this.btnDelSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelSchedule.UseVisualStyleBackColor = true;
            this.btnDelSchedule.Click += new System.EventHandler(this.btnDelSchedule_Click);
            // 
            // btnSchedule
            // 
            this.btnSchedule.BackgroundImage = global::ProjectHQTCSDL.Properties.Resources.schedule;
            this.btnSchedule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSchedule.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchedule.Location = new System.Drawing.Point(20, 100);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(181, 41);
            this.btnSchedule.TabIndex = 0;
            this.btnSchedule.Text = "Schedule";
            this.btnSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSchedule.UseVisualStyleBackColor = true;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // fAdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1461, 758);
            this.Controls.Add(this.pUserControl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "fAdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.fAdminDashboard_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pUserControl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCource;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnClass;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Button btnTeacher;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnDelSchedule;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Button btnExpenses;
    }
}