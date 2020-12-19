
namespace ProjectHQTCSDL.Usercontrol
{
    partial class YourInformation_UserControl
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlStudent = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.pnlTeacher = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPassTea = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNameTea = new System.Windows.Forms.TextBox();
            this.txtSalaryTea = new System.Windows.Forms.TextBox();
            this.txtPhoneNumberTea = new System.Windows.Forms.TextBox();
            this.txtAddressTea = new System.Windows.Forms.TextBox();
            this.pnlStudent.SuspendLayout();
            this.pnlTeacher.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Brown;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(732, 562);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(123, 42);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(557, 562);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(123, 42);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Green;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(387, 562);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(123, 42);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(473, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(310, 69);
            this.label6.TabIndex = 16;
            this.label6.Text = "Your Information";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpDOB
            // 
            this.dtpDOB.CustomFormat = "yyyy-MM-dd";
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOB.Location = new System.Drawing.Point(174, 304);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(248, 26);
            this.dtpDOB.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(174, 199);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(248, 26);
            this.txtEmail.TabIndex = 3;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(174, 138);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(248, 26);
            this.txtAddress.TabIndex = 2;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(174, 77);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(248, 26);
            this.txtPhoneNumber.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(174, 21);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(248, 26);
            this.txtName.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "DOB :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Email :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Address :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Phone number :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name :";
            // 
            // pnlStudent
            // 
            this.pnlStudent.Controls.Add(this.label11);
            this.pnlStudent.Controls.Add(this.txtPass);
            this.pnlStudent.Controls.Add(this.label1);
            this.pnlStudent.Controls.Add(this.label2);
            this.pnlStudent.Controls.Add(this.label3);
            this.pnlStudent.Controls.Add(this.label4);
            this.pnlStudent.Controls.Add(this.label5);
            this.pnlStudent.Controls.Add(this.dtpDOB);
            this.pnlStudent.Controls.Add(this.txtName);
            this.pnlStudent.Controls.Add(this.txtEmail);
            this.pnlStudent.Controls.Add(this.txtPhoneNumber);
            this.pnlStudent.Controls.Add(this.txtAddress);
            this.pnlStudent.Location = new System.Drawing.Point(93, 161);
            this.pnlStudent.Name = "pnlStudent";
            this.pnlStudent.Size = new System.Drawing.Size(446, 359);
            this.pnlStudent.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 254);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "Password :";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(174, 251);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(248, 26);
            this.txtPass.TabIndex = 11;
            this.txtPass.Text = "000000";
            this.txtPass.UseSystemPasswordChar = true;
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            // 
            // pnlTeacher
            // 
            this.pnlTeacher.Controls.Add(this.label12);
            this.pnlTeacher.Controls.Add(this.txtPassTea);
            this.pnlTeacher.Controls.Add(this.label7);
            this.pnlTeacher.Controls.Add(this.label8);
            this.pnlTeacher.Controls.Add(this.label9);
            this.pnlTeacher.Controls.Add(this.label10);
            this.pnlTeacher.Controls.Add(this.txtNameTea);
            this.pnlTeacher.Controls.Add(this.txtSalaryTea);
            this.pnlTeacher.Controls.Add(this.txtPhoneNumberTea);
            this.pnlTeacher.Controls.Add(this.txtAddressTea);
            this.pnlTeacher.Location = new System.Drawing.Point(654, 161);
            this.pnlTeacher.Name = "pnlTeacher";
            this.pnlTeacher.Size = new System.Drawing.Size(446, 359);
            this.pnlTeacher.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 224);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 20);
            this.label12.TabIndex = 12;
            this.label12.Text = "Password:";
            // 
            // txtPassTea
            // 
            this.txtPassTea.Location = new System.Drawing.Point(199, 218);
            this.txtPassTea.Name = "txtPassTea";
            this.txtPassTea.Size = new System.Drawing.Size(223, 26);
            this.txtPassTea.TabIndex = 13;
            this.txtPassTea.Text = "000000";
            this.txtPassTea.UseSystemPasswordChar = true;
            this.txtPassTea.TextChanged += new System.EventHandler(this.txtPassGV_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Name :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Phone number :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Address :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 286);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Salary :";
            // 
            // txtNameTea
            // 
            this.txtNameTea.Location = new System.Drawing.Point(199, 21);
            this.txtNameTea.Name = "txtNameTea";
            this.txtNameTea.Size = new System.Drawing.Size(223, 26);
            this.txtNameTea.TabIndex = 8;
            // 
            // txtSalaryTea
            // 
            this.txtSalaryTea.Location = new System.Drawing.Point(199, 283);
            this.txtSalaryTea.Name = "txtSalaryTea";
            this.txtSalaryTea.Size = new System.Drawing.Size(223, 26);
            this.txtSalaryTea.TabIndex = 11;
            // 
            // txtPhoneNumberTea
            // 
            this.txtPhoneNumberTea.Location = new System.Drawing.Point(199, 86);
            this.txtPhoneNumberTea.Name = "txtPhoneNumberTea";
            this.txtPhoneNumberTea.Size = new System.Drawing.Size(223, 26);
            this.txtPhoneNumberTea.TabIndex = 9;
            // 
            // txtAddressTea
            // 
            this.txtAddressTea.Location = new System.Drawing.Point(199, 161);
            this.txtAddressTea.Name = "txtAddressTea";
            this.txtAddressTea.Size = new System.Drawing.Size(223, 26);
            this.txtAddressTea.TabIndex = 10;
            // 
            // YourInformation_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlTeacher);
            this.Controls.Add(this.pnlStudent);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "YourInformation_UserControl";
            this.Size = new System.Drawing.Size(1233, 674);
            this.Load += new System.EventHandler(this.YourInformation_UserControl_Load);
            this.pnlStudent.ResumeLayout(false);
            this.pnlStudent.PerformLayout();
            this.pnlTeacher.ResumeLayout(false);
            this.pnlTeacher.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlStudent;
        private System.Windows.Forms.Panel pnlTeacher;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNameTea;
        private System.Windows.Forms.TextBox txtSalaryTea;
        private System.Windows.Forms.TextBox txtPhoneNumberTea;
        private System.Windows.Forms.TextBox txtAddressTea;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPassTea;
    }
}
