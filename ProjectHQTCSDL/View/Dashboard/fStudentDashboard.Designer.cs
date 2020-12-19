
namespace ProjectHQTCSDL.View.Dashboard
{
    partial class fStudentDashboard
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fStudentDashboard));
         this.pUserControl = new System.Windows.Forms.Panel();
         this.panel2 = new System.Windows.Forms.Panel();
         this.label1 = new System.Windows.Forms.Label();
         this.panel1 = new System.Windows.Forms.Panel();
         this.btnEnroll = new System.Windows.Forms.Button();
         this.btnLogout = new System.Windows.Forms.Button();
         this.btnMakeUpClass = new System.Windows.Forms.Button();
         this.btnInformation = new System.Windows.Forms.Button();
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
         this.pUserControl.TabIndex = 5;
         // 
         // panel2
         // 
         this.panel2.BackColor = System.Drawing.Color.SeaGreen;
         this.panel2.Controls.Add(this.label1);
         this.panel2.ForeColor = System.Drawing.Color.White;
         this.panel2.Location = new System.Drawing.Point(227, 1);
         this.panel2.Name = "panel2";
         this.panel2.Size = new System.Drawing.Size(1233, 81);
         this.panel2.TabIndex = 4;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(17, 24);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(269, 33);
         this.label1.TabIndex = 0;
         this.label1.Text = "Student Dashboard";
         // 
         // panel1
         // 
         this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
         this.panel1.Controls.Add(this.btnEnroll);
         this.panel1.Controls.Add(this.btnLogout);
         this.panel1.Controls.Add(this.btnMakeUpClass);
         this.panel1.Controls.Add(this.btnInformation);
         this.panel1.Controls.Add(this.btnSchedule);
         this.panel1.ForeColor = System.Drawing.Color.White;
         this.panel1.Location = new System.Drawing.Point(1, 1);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(225, 756);
         this.panel1.TabIndex = 3;
         // 
         // btnEnroll
         // 
         this.btnEnroll.BackgroundImage = global::ProjectHQTCSDL.Properties.Resources.enroll;
         this.btnEnroll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
         this.btnEnroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnEnroll.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnEnroll.Location = new System.Drawing.Point(20, 326);
         this.btnEnroll.Name = "btnEnroll";
         this.btnEnroll.Size = new System.Drawing.Size(181, 41);
         this.btnEnroll.TabIndex = 4;
         this.btnEnroll.Text = "Enroll";
         this.btnEnroll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         this.btnEnroll.UseVisualStyleBackColor = true;
         this.btnEnroll.Click += new System.EventHandler(this.btnEnroll_Click);
         // 
         // btnLogout
         // 
         this.btnLogout.BackgroundImage = global::ProjectHQTCSDL.Properties.Resources.Logout;
         this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
         this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnLogout.Location = new System.Drawing.Point(20, 674);
         this.btnLogout.Name = "btnLogout";
         this.btnLogout.Size = new System.Drawing.Size(181, 41);
         this.btnLogout.TabIndex = 3;
         this.btnLogout.Text = "Logout";
         this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         this.btnLogout.UseVisualStyleBackColor = true;
         this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
         // 
         // btnMakeUpClass
         // 
         this.btnMakeUpClass.BackgroundImage = global::ProjectHQTCSDL.Properties.Resources.make_up;
         this.btnMakeUpClass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
         this.btnMakeUpClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnMakeUpClass.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnMakeUpClass.Location = new System.Drawing.Point(20, 220);
         this.btnMakeUpClass.Name = "btnMakeUpClass";
         this.btnMakeUpClass.Size = new System.Drawing.Size(181, 41);
         this.btnMakeUpClass.TabIndex = 2;
         this.btnMakeUpClass.Text = "Make-up Class";
         this.btnMakeUpClass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         this.btnMakeUpClass.UseVisualStyleBackColor = true;
         this.btnMakeUpClass.Click += new System.EventHandler(this.btnMakeUpClass_Click);
         // 
         // btnInformation
         // 
         this.btnInformation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInformation.BackgroundImage")));
         this.btnInformation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
         this.btnInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnInformation.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnInformation.Location = new System.Drawing.Point(20, 423);
         this.btnInformation.Name = "btnInformation";
         this.btnInformation.Size = new System.Drawing.Size(181, 41);
         this.btnInformation.TabIndex = 1;
         this.btnInformation.Text = "Information";
         this.btnInformation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         this.btnInformation.UseVisualStyleBackColor = true;
         this.btnInformation.Click += new System.EventHandler(this.btnInformation_Click);
         // 
         // btnSchedule
         // 
         this.btnSchedule.BackgroundImage = global::ProjectHQTCSDL.Properties.Resources.schedule;
         this.btnSchedule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
         this.btnSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnSchedule.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnSchedule.Location = new System.Drawing.Point(20, 120);
         this.btnSchedule.Name = "btnSchedule";
         this.btnSchedule.Size = new System.Drawing.Size(181, 41);
         this.btnSchedule.TabIndex = 0;
         this.btnSchedule.Text = "Schedule";
         this.btnSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         this.btnSchedule.UseVisualStyleBackColor = true;
         this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
         // 
         // fStudentDashboard
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1461, 758);
         this.Controls.Add(this.pUserControl);
         this.Controls.Add(this.panel2);
         this.Controls.Add(this.panel1);
         this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.Name = "fStudentDashboard";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Student";
         this.Load += new System.EventHandler(this.fStudentDashboard_Load);
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
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnMakeUpClass;
        private System.Windows.Forms.Button btnInformation;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Button btnEnroll;
    }
}