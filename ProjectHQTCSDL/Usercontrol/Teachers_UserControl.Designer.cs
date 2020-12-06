
namespace ProjectHQTCSDL.Usercontrol
{
    partial class Teachers_UserControl
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabAdd = new System.Windows.Forms.TabPage();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSalaryNew = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIDNew = new System.Windows.Forms.TextBox();
            this.txtNameNew = new System.Windows.Forms.TextBox();
            this.txtAddressNew = new System.Windows.Forms.TextBox();
            this.txtPhoneNew = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvListTeachers = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabEdit = new System.Windows.Forms.TabPage();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.btnResetPass = new System.Windows.Forms.Button();
            this.tabAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListTeachers)).BeginInit();
            this.tabEdit.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(83, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(354, 26);
            this.txtSearch.TabIndex = 17;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(188, 58);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(200, 26);
            this.txtID.TabIndex = 21;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(184, 127);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 26);
            this.txtName.TabIndex = 20;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(184, 281);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(200, 26);
            this.txtAddress.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Search";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(184, 203);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(200, 26);
            this.txtPhone.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Phone Number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Teacher\'s ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Name:";
            // 
            // tabAdd
            // 
            this.tabAdd.Controls.Add(this.txtUsername);
            this.tabAdd.Controls.Add(this.label10);
            this.tabAdd.Controls.Add(this.txtSalaryNew);
            this.tabAdd.Controls.Add(this.label5);
            this.tabAdd.Controls.Add(this.txtIDNew);
            this.tabAdd.Controls.Add(this.txtNameNew);
            this.tabAdd.Controls.Add(this.txtAddressNew);
            this.tabAdd.Controls.Add(this.txtPhoneNew);
            this.tabAdd.Controls.Add(this.label6);
            this.tabAdd.Controls.Add(this.label7);
            this.tabAdd.Controls.Add(this.label8);
            this.tabAdd.Controls.Add(this.label11);
            this.tabAdd.Controls.Add(this.btnAdd);
            this.tabAdd.Location = new System.Drawing.Point(4, 29);
            this.tabAdd.Name = "tabAdd";
            this.tabAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdd.Size = new System.Drawing.Size(413, 635);
            this.tabAdd.TabIndex = 1;
            this.tabAdd.Text = "Add";
            this.tabAdd.UseVisualStyleBackColor = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(179, 105);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(200, 26);
            this.txtUsername.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(61, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 20);
            this.label10.TabIndex = 34;
            this.label10.Text = "Username:";
            // 
            // txtSalaryNew
            // 
            this.txtSalaryNew.Location = new System.Drawing.Point(179, 396);
            this.txtSalaryNew.Name = "txtSalaryNew";
            this.txtSalaryNew.Size = new System.Drawing.Size(200, 26);
            this.txtSalaryNew.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 399);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "Salary:";
            // 
            // txtIDNew
            // 
            this.txtIDNew.Location = new System.Drawing.Point(179, 41);
            this.txtIDNew.Name = "txtIDNew";
            this.txtIDNew.ReadOnly = true;
            this.txtIDNew.Size = new System.Drawing.Size(200, 26);
            this.txtIDNew.TabIndex = 31;
            // 
            // txtNameNew
            // 
            this.txtNameNew.Location = new System.Drawing.Point(179, 174);
            this.txtNameNew.Name = "txtNameNew";
            this.txtNameNew.Size = new System.Drawing.Size(200, 26);
            this.txtNameNew.TabIndex = 30;
            // 
            // txtAddressNew
            // 
            this.txtAddressNew.Location = new System.Drawing.Point(179, 328);
            this.txtAddressNew.Name = "txtAddressNew";
            this.txtAddressNew.Size = new System.Drawing.Size(200, 26);
            this.txtAddressNew.TabIndex = 29;
            // 
            // txtPhoneNew
            // 
            this.txtPhoneNew.Location = new System.Drawing.Point(179, 250);
            this.txtPhoneNew.Name = "txtPhoneNew";
            this.txtPhoneNew.Size = new System.Drawing.Size(200, 26);
            this.txtPhoneNew.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Address:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "Phone Number:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(91, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "Name:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(47, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 20);
            this.label11.TabIndex = 24;
            this.label11.Text = "Teacher\'s ID:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(141, 536);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 42);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvListTeachers
            // 
            this.dgvListTeachers.AllowUserToAddRows = false;
            this.dgvListTeachers.AllowUserToDeleteRows = false;
            this.dgvListTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListTeachers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvListTeachers.Location = new System.Drawing.Point(3, 35);
            this.dgvListTeachers.Name = "dgvListTeachers";
            this.dgvListTeachers.ReadOnly = true;
            this.dgvListTeachers.RowHeadersVisible = false;
            this.dgvListTeachers.RowHeadersWidth = 51;
            this.dgvListTeachers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListTeachers.Size = new System.Drawing.Size(804, 636);
            this.dgvListTeachers.TabIndex = 15;
            this.dgvListTeachers.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListTeachers_RowEnter);
            // 
            // colID
            // 
            this.colID.DataPropertyName = "MaGiaoVien";
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Width = 60;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "HoTen";
            this.Column1.HeaderText = "Full name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 210;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "SDT";
            this.Column2.HeaderText = "Phone Number";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 160;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DiaChi";
            this.Column3.HeaderText = "Address";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 210;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "LuongCoBan";
            this.Column4.HeaderText = "Salary";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 160;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(41, 513);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 42);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tabEdit
            // 
            this.tabEdit.Controls.Add(this.btnResetPass);
            this.tabEdit.Controls.Add(this.txtSalary);
            this.tabEdit.Controls.Add(this.label12);
            this.tabEdit.Controls.Add(this.txtID);
            this.tabEdit.Controls.Add(this.txtName);
            this.tabEdit.Controls.Add(this.txtAddress);
            this.tabEdit.Controls.Add(this.txtPhone);
            this.tabEdit.Controls.Add(this.label4);
            this.tabEdit.Controls.Add(this.label3);
            this.tabEdit.Controls.Add(this.label2);
            this.tabEdit.Controls.Add(this.label1);
            this.tabEdit.Controls.Add(this.btnSave);
            this.tabEdit.Location = new System.Drawing.Point(4, 29);
            this.tabEdit.Name = "tabEdit";
            this.tabEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tabEdit.Size = new System.Drawing.Size(413, 635);
            this.tabEdit.TabIndex = 0;
            this.tabEdit.Text = "Edit";
            this.tabEdit.UseVisualStyleBackColor = true;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(184, 351);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(200, 26);
            this.txtSalary.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(103, 354);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 20);
            this.label12.TabIndex = 24;
            this.label12.Text = "Salary:";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabEdit);
            this.tabControl.Controls.Add(this.tabAdd);
            this.tabControl.Location = new System.Drawing.Point(809, 4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(421, 668);
            this.tabControl.TabIndex = 16;
            // 
            // btnResetPass
            // 
            this.btnResetPass.Location = new System.Drawing.Point(234, 513);
            this.btnResetPass.Name = "btnResetPass";
            this.btnResetPass.Size = new System.Drawing.Size(150, 42);
            this.btnResetPass.TabIndex = 26;
            this.btnResetPass.Text = "Reset Pass";
            this.btnResetPass.UseVisualStyleBackColor = true;
            this.btnResetPass.Click += new System.EventHandler(this.btnResetPass_Click);
            // 
            // Teachers_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvListTeachers);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Teachers_UserControl";
            this.Size = new System.Drawing.Size(1233, 674);
            this.Load += new System.EventHandler(this.Teachers_UserControl_Load);
            this.tabAdd.ResumeLayout(false);
            this.tabAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListTeachers)).EndInit();
            this.tabEdit.ResumeLayout(false);
            this.tabEdit.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabAdd;
        private System.Windows.Forms.TextBox txtNameNew;
        private System.Windows.Forms.TextBox txtAddressNew;
        private System.Windows.Forms.TextBox txtPhoneNew;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvListTeachers;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabPage tabEdit;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TextBox txtSalaryNew;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSalary;
        public System.Windows.Forms.TextBox txtIDNew;
        private System.Windows.Forms.Button btnResetPass;
    }
}
