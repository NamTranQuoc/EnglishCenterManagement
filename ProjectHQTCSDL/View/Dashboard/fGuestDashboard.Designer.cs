
namespace ProjectHQTCSDL.View.Dashboard
{
    partial class fGuestDashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCommunication = new System.Windows.Forms.Button();
            this.btnBasic = new System.Windows.Forms.Button();
            this.btnIelts = new System.Windows.Forms.Button();
            this.btnCourse = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pUserControl = new System.Windows.Forms.Panel();
            this.account_UserControl1 = new ProjectHQTCSDL.Usercontrol.Account_UserControl();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pUserControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this.btnCommunication);
            this.panel1.Controls.Add(this.btnBasic);
            this.panel1.Controls.Add(this.btnIelts);
            this.panel1.Controls.Add(this.btnCourse);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 756);
            this.panel1.TabIndex = 3;
            // 
            // btnCommunication
            // 
            this.btnCommunication.BackgroundImage = global::ProjectHQTCSDL.Properties.Resources.login;
            this.btnCommunication.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCommunication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCommunication.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCommunication.Location = new System.Drawing.Point(20, 294);
            this.btnCommunication.Name = "btnCommunication";
            this.btnCommunication.Size = new System.Drawing.Size(181, 41);
            this.btnCommunication.TabIndex = 3;
            this.btnCommunication.Text = "COMMUNICATION";
            this.btnCommunication.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCommunication.UseVisualStyleBackColor = true;
            this.btnCommunication.Click += new System.EventHandler(this.btnCommunication_Click);
            // 
            // btnBasic
            // 
            this.btnBasic.BackgroundImage = global::ProjectHQTCSDL.Properties.Resources.login;
            this.btnBasic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBasic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBasic.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBasic.Location = new System.Drawing.Point(20, 380);
            this.btnBasic.Name = "btnBasic";
            this.btnBasic.Size = new System.Drawing.Size(181, 41);
            this.btnBasic.TabIndex = 3;
            this.btnBasic.Text = "BASIC";
            this.btnBasic.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBasic.UseVisualStyleBackColor = true;
            this.btnBasic.Click += new System.EventHandler(this.btnBasic_Click);
            // 
            // btnIelts
            // 
            this.btnIelts.BackgroundImage = global::ProjectHQTCSDL.Properties.Resources.login;
            this.btnIelts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnIelts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIelts.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIelts.Location = new System.Drawing.Point(20, 215);
            this.btnIelts.Name = "btnIelts";
            this.btnIelts.Size = new System.Drawing.Size(181, 41);
            this.btnIelts.TabIndex = 3;
            this.btnIelts.Text = "IELTS";
            this.btnIelts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIelts.UseVisualStyleBackColor = true;
            this.btnIelts.Click += new System.EventHandler(this.btnIelts_Click);
            // 
            // btnCourse
            // 
            this.btnCourse.BackgroundImage = global::ProjectHQTCSDL.Properties.Resources.login;
            this.btnCourse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCourse.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCourse.Location = new System.Drawing.Point(20, 107);
            this.btnCourse.Name = "btnCourse";
            this.btnCourse.Size = new System.Drawing.Size(181, 41);
            this.btnCourse.TabIndex = 3;
            this.btnCourse.Text = "TOEIC";
            this.btnCourse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCourse.UseVisualStyleBackColor = true;
            this.btnCourse.Click += new System.EventHandler(this.btnCourse_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackgroundImage = global::ProjectHQTCSDL.Properties.Resources.login;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(20, 674);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(181, 41);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Login";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
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
            this.label1.Size = new System.Drawing.Size(245, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Guest Dashboard";
            // 
            // pUserControl
            // 
            this.pUserControl.Controls.Add(this.account_UserControl1);
            this.pUserControl.Location = new System.Drawing.Point(227, 83);
            this.pUserControl.Name = "pUserControl";
            this.pUserControl.Size = new System.Drawing.Size(1233, 674);
            this.pUserControl.TabIndex = 5;
            // 
            // account_UserControl1
            // 
            this.account_UserControl1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.account_UserControl1.Location = new System.Drawing.Point(0, 0);
            this.account_UserControl1.Margin = new System.Windows.Forms.Padding(4);
            this.account_UserControl1.Name = "account_UserControl1";
            this.account_UserControl1.Size = new System.Drawing.Size(1233, 674);
            this.account_UserControl1.TabIndex = 0;
            // 
            // fGuestDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1461, 758);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pUserControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fGuestDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guest";
            this.Load += new System.EventHandler(this.fGuestDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pUserControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pUserControl;
        private System.Windows.Forms.Button btnIelts;
        private System.Windows.Forms.Button btnCourse;
        private System.Windows.Forms.Button btnCommunication;
        private System.Windows.Forms.Button btnBasic;
        private Usercontrol.Account_UserControl account_UserControl1;
    }
}