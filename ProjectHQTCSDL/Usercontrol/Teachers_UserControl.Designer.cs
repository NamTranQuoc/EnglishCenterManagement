
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
            this.colTuitionFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNoOfSessions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.rbtHide = new System.Windows.Forms.RadioButton();
            this.rbtAll = new System.Windows.Forms.RadioButton();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtAvailable = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tabAdd = new System.Windows.Forms.TabPage();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvListTeachers = new System.Windows.Forms.DataGridView();
            this.btnHideOrAvailable = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabEdit = new System.Windows.Forms.TabPage();
            this.nmrSessions = new System.Windows.Forms.NumericUpDown();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListTeachers)).BeginInit();
            this.tabEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSessions)).BeginInit();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // colTuitionFee
            // 
            this.colTuitionFee.DataPropertyName = "HocPhi";
            this.colTuitionFee.HeaderText = "Tuition fee";
            this.colTuitionFee.MinimumWidth = 6;
            this.colTuitionFee.Name = "colTuitionFee";
            this.colTuitionFee.ReadOnly = true;
            this.colTuitionFee.Width = 200;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "TenKhoaHoc";
            this.colName.HeaderText = "Name";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 280;
            // 
            // colID
            // 
            this.colID.DataPropertyName = "MaKhoaHoc";
            this.colID.HeaderText = "Cource\'s ID";
            this.colID.MinimumWidth = 6;
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Width = 120;
            // 
            // colNoOfSessions
            // 
            this.colNoOfSessions.DataPropertyName = "SoBuoi";
            this.colNoOfSessions.HeaderText = "Number of sessions";
            this.colNoOfSessions.MinimumWidth = 6;
            this.colNoOfSessions.Name = "colNoOfSessions";
            this.colNoOfSessions.ReadOnly = true;
            this.colNoOfSessions.Width = 200;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(83, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(354, 30);
            this.txtSearch.TabIndex = 17;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(188, 58);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(200, 30);
            this.txtID.TabIndex = 21;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(184, 127);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 30);
            this.txtName.TabIndex = 20;
            // 
            // rbtHide
            // 
            this.rbtHide.AutoSize = true;
            this.rbtHide.Location = new System.Drawing.Point(610, 3);
            this.rbtHide.Name = "rbtHide";
            this.rbtHide.Size = new System.Drawing.Size(72, 26);
            this.rbtHide.TabIndex = 19;
            this.rbtHide.Text = "Hide";
            this.rbtHide.UseVisualStyleBackColor = true;
            // 
            // rbtAll
            // 
            this.rbtAll.AutoSize = true;
            this.rbtAll.Location = new System.Drawing.Point(552, 3);
            this.rbtAll.Name = "rbtAll";
            this.rbtAll.Size = new System.Drawing.Size(52, 26);
            this.rbtAll.TabIndex = 18;
            this.rbtAll.Text = "All";
            this.rbtAll.UseVisualStyleBackColor = true;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(184, 281);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(200, 30);
            this.txtAddress.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 22);
            this.label9.TabIndex = 21;
            this.label9.Text = "Search";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(89, 360);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 22);
            this.label10.TabIndex = 22;
            this.label10.Text = "Sessions:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(184, 203);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(200, 30);
            this.txtPhone.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 22);
            this.label4.TabIndex = 17;
            this.label4.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 22);
            this.label3.TabIndex = 16;
            this.label3.Text = "Phone Number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 22);
            this.label1.TabIndex = 14;
            this.label1.Text = "Teacher\'s ID:";
            // 
            // rbtAvailable
            // 
            this.rbtAvailable.AutoSize = true;
            this.rbtAvailable.Checked = true;
            this.rbtAvailable.Location = new System.Drawing.Point(688, 3);
            this.rbtAvailable.Name = "rbtAvailable";
            this.rbtAvailable.Size = new System.Drawing.Size(119, 26);
            this.rbtAvailable.TabIndex = 20;
            this.rbtAvailable.TabStop = true;
            this.rbtAvailable.Text = "Available";
            this.rbtAvailable.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "Name:";
            // 
            // tabAdd
            // 
            this.tabAdd.Controls.Add(this.numericUpDown2);
            this.tabAdd.Controls.Add(this.label5);
            this.tabAdd.Controls.Add(this.textBox1);
            this.tabAdd.Controls.Add(this.textBox2);
            this.tabAdd.Controls.Add(this.textBox3);
            this.tabAdd.Controls.Add(this.textBox4);
            this.tabAdd.Controls.Add(this.label6);
            this.tabAdd.Controls.Add(this.label7);
            this.tabAdd.Controls.Add(this.label8);
            this.tabAdd.Controls.Add(this.label11);
            this.tabAdd.Controls.Add(this.btnAdd);
            this.tabAdd.Location = new System.Drawing.Point(4, 31);
            this.tabAdd.Name = "tabAdd";
            this.tabAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdd.Size = new System.Drawing.Size(413, 633);
            this.tabAdd.TabIndex = 1;
            this.tabAdd.Text = "Add";
            this.tabAdd.UseVisualStyleBackColor = true;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(179, 369);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 30);
            this.numericUpDown2.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 22);
            this.label5.TabIndex = 32;
            this.label5.Text = "Sessions:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(183, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(200, 30);
            this.textBox1.TabIndex = 31;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(179, 138);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 30);
            this.textBox2.TabIndex = 30;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(179, 292);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(200, 30);
            this.textBox3.TabIndex = 29;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(179, 214);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(200, 30);
            this.textBox4.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 22);
            this.label6.TabIndex = 27;
            this.label6.Text = "Address:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 22);
            this.label7.TabIndex = 26;
            this.label7.Text = "Phone Number:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(97, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 22);
            this.label8.TabIndex = 25;
            this.label8.Text = "Name:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(47, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 22);
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
            // 
            // dgvListTeachers
            // 
            this.dgvListTeachers.AllowUserToAddRows = false;
            this.dgvListTeachers.AllowUserToDeleteRows = false;
            this.dgvListTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListTeachers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colName,
            this.colNoOfSessions,
            this.colTuitionFee});
            this.dgvListTeachers.Location = new System.Drawing.Point(-258, 32);
            this.dgvListTeachers.Name = "dgvListTeachers";
            this.dgvListTeachers.ReadOnly = true;
            this.dgvListTeachers.RowHeadersVisible = false;
            this.dgvListTeachers.RowHeadersWidth = 51;
            this.dgvListTeachers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListTeachers.Size = new System.Drawing.Size(804, 636);
            this.dgvListTeachers.TabIndex = 15;
            this.dgvListTeachers.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListTeachers_RowEnter);
            // 
            // btnHideOrAvailable
            // 
            this.btnHideOrAvailable.Location = new System.Drawing.Point(235, 538);
            this.btnHideOrAvailable.Name = "btnHideOrAvailable";
            this.btnHideOrAvailable.Size = new System.Drawing.Size(150, 42);
            this.btnHideOrAvailable.TabIndex = 9;
            this.btnHideOrAvailable.Text = "Hide";
            this.btnHideOrAvailable.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(27, 538);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 42);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // tabEdit
            // 
            this.tabEdit.Controls.Add(this.nmrSessions);
            this.tabEdit.Controls.Add(this.label10);
            this.tabEdit.Controls.Add(this.txtID);
            this.tabEdit.Controls.Add(this.txtName);
            this.tabEdit.Controls.Add(this.txtAddress);
            this.tabEdit.Controls.Add(this.txtPhone);
            this.tabEdit.Controls.Add(this.label4);
            this.tabEdit.Controls.Add(this.label3);
            this.tabEdit.Controls.Add(this.label2);
            this.tabEdit.Controls.Add(this.label1);
            this.tabEdit.Controls.Add(this.btnHideOrAvailable);
            this.tabEdit.Controls.Add(this.btnSave);
            this.tabEdit.Location = new System.Drawing.Point(4, 31);
            this.tabEdit.Name = "tabEdit";
            this.tabEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tabEdit.Size = new System.Drawing.Size(413, 633);
            this.tabEdit.TabIndex = 0;
            this.tabEdit.Text = "Edit";
            this.tabEdit.UseVisualStyleBackColor = true;
            // 
            // nmrSessions
            // 
            this.nmrSessions.Location = new System.Drawing.Point(184, 358);
            this.nmrSessions.Name = "nmrSessions";
            this.nmrSessions.Size = new System.Drawing.Size(120, 30);
            this.nmrSessions.TabIndex = 23;
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
            // Teachers_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.rbtHide);
            this.Controls.Add(this.rbtAll);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.rbtAvailable);
            this.Controls.Add(this.dgvListTeachers);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Teachers_UserControl";
            this.Size = new System.Drawing.Size(1233, 674);
            this.Load += new System.EventHandler(this.Teachers_UserControl_Load);
            this.tabAdd.ResumeLayout(false);
            this.tabAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListTeachers)).EndInit();
            this.tabEdit.ResumeLayout(false);
            this.tabEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSessions)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn colTuitionFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNoOfSessions;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RadioButton rbtHide;
        private System.Windows.Forms.RadioButton rbtAll;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtAvailable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabAdd;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvListTeachers;
        private System.Windows.Forms.Button btnHideOrAvailable;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabPage tabEdit;
        private System.Windows.Forms.NumericUpDown nmrSessions;
        private System.Windows.Forms.TabControl tabControl;
    }
}
