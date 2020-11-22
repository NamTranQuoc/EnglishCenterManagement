
namespace ProjectHQTCSDL.Usercontrol
{
    partial class Classes_UserControl
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
            this.nmrShift = new System.Windows.Forms.NumericUpDown();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tabEdit = new System.Windows.Forms.TabPage();
            this.cmbDayOfWeek = new System.Windows.Forms.ComboBox();
            this.nmrStudents = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHideOrAvailable = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabAdd = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rbtOdd = new System.Windows.Forms.RadioButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.rbtEven = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvListClasses = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rbtAll = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCource = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmrShift)).BeginInit();
            this.tabEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrStudents)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListClasses)).BeginInit();
            this.SuspendLayout();
            // 
            // nmrShift
            // 
            this.nmrShift.Location = new System.Drawing.Point(188, 209);
            this.nmrShift.Name = "nmrShift";
            this.nmrShift.Size = new System.Drawing.Size(197, 26);
            this.nmrShift.TabIndex = 23;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(188, 58);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(200, 26);
            this.txtID.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Course\'s ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Shift:";
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
            // tabEdit
            // 
            this.tabEdit.Controls.Add(this.txtCource);
            this.tabEdit.Controls.Add(this.label10);
            this.tabEdit.Controls.Add(this.cmbDayOfWeek);
            this.tabEdit.Controls.Add(this.nmrStudents);
            this.tabEdit.Controls.Add(this.nmrShift);
            this.tabEdit.Controls.Add(this.txtID);
            this.tabEdit.Controls.Add(this.label4);
            this.tabEdit.Controls.Add(this.label3);
            this.tabEdit.Controls.Add(this.label2);
            this.tabEdit.Controls.Add(this.label1);
            this.tabEdit.Controls.Add(this.btnHideOrAvailable);
            this.tabEdit.Controls.Add(this.btnSave);
            this.tabEdit.Location = new System.Drawing.Point(4, 29);
            this.tabEdit.Name = "tabEdit";
            this.tabEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tabEdit.Size = new System.Drawing.Size(413, 635);
            this.tabEdit.TabIndex = 0;
            this.tabEdit.Text = "Edit";
            this.tabEdit.UseVisualStyleBackColor = true;
            // 
            // cmbDayOfWeek
            // 
            this.cmbDayOfWeek.FormattingEnabled = true;
            this.cmbDayOfWeek.Items.AddRange(new object[] {
            "2-4-6",
            "3-5-7"});
            this.cmbDayOfWeek.Location = new System.Drawing.Point(188, 389);
            this.cmbDayOfWeek.Name = "cmbDayOfWeek";
            this.cmbDayOfWeek.Size = new System.Drawing.Size(197, 28);
            this.cmbDayOfWeek.TabIndex = 25;
            // 
            // nmrStudents
            // 
            this.nmrStudents.Location = new System.Drawing.Point(188, 131);
            this.nmrStudents.Name = "nmrStudents";
            this.nmrStudents.Size = new System.Drawing.Size(197, 26);
            this.nmrStudents.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Expected Students:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Class\'s ID:";
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
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabEdit);
            this.tabControl.Controls.Add(this.tabAdd);
            this.tabControl.Location = new System.Drawing.Point(809, 4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(421, 668);
            this.tabControl.TabIndex = 23;
            // 
            // tabAdd
            // 
            this.tabAdd.Controls.Add(this.label11);
            this.tabAdd.Controls.Add(this.comboBox2);
            this.tabAdd.Controls.Add(this.comboBox1);
            this.tabAdd.Controls.Add(this.numericUpDown1);
            this.tabAdd.Controls.Add(this.numericUpDown2);
            this.tabAdd.Controls.Add(this.textBox1);
            this.tabAdd.Controls.Add(this.label5);
            this.tabAdd.Controls.Add(this.label6);
            this.tabAdd.Controls.Add(this.label7);
            this.tabAdd.Controls.Add(this.label8);
            this.tabAdd.Controls.Add(this.btnAdd);
            this.tabAdd.Location = new System.Drawing.Point(4, 29);
            this.tabAdd.Name = "tabAdd";
            this.tabAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdd.Size = new System.Drawing.Size(413, 635);
            this.tabAdd.TabIndex = 1;
            this.tabAdd.Text = "Add";
            this.tabAdd.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(190, 292);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(197, 28);
            this.comboBox1.TabIndex = 33;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(190, 139);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown1.TabIndex = 32;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(190, 217);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown2.TabIndex = 31;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(190, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(200, 26);
            this.textBox1.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Course\'s ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(119, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Shift:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "Expected Students:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(82, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "Class\'s ID:";
            // 
            // rbtOdd
            // 
            this.rbtOdd.AutoSize = true;
            this.rbtOdd.Location = new System.Drawing.Point(736, 5);
            this.rbtOdd.Name = "rbtOdd";
            this.rbtOdd.Size = new System.Drawing.Size(61, 24);
            this.rbtOdd.TabIndex = 27;
            this.rbtOdd.Text = "3-5-7";
            this.rbtOdd.UseVisualStyleBackColor = true;
            this.rbtOdd.CheckedChanged += new System.EventHandler(this.rbtOdd_CheckedChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(83, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(354, 26);
            this.txtSearch.TabIndex = 24;
            // 
            // rbtEven
            // 
            this.rbtEven.AutoSize = true;
            this.rbtEven.Location = new System.Drawing.Point(659, 4);
            this.rbtEven.Name = "rbtEven";
            this.rbtEven.Size = new System.Drawing.Size(61, 24);
            this.rbtEven.TabIndex = 26;
            this.rbtEven.Text = "2-4-6";
            this.rbtEven.UseVisualStyleBackColor = true;
            this.rbtEven.CheckedChanged += new System.EventHandler(this.rbtEven_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 20);
            this.label9.TabIndex = 28;
            this.label9.Text = "Search";
            // 
            // dgvListClasses
            // 
            this.dgvListClasses.AllowUserToAddRows = false;
            this.dgvListClasses.AllowUserToDeleteRows = false;
            this.dgvListClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListClasses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvListClasses.Location = new System.Drawing.Point(3, 36);
            this.dgvListClasses.Name = "dgvListClasses";
            this.dgvListClasses.ReadOnly = true;
            this.dgvListClasses.RowHeadersVisible = false;
            this.dgvListClasses.RowHeadersWidth = 51;
            this.dgvListClasses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListClasses.Size = new System.Drawing.Size(804, 636);
            this.dgvListClasses.TabIndex = 22;
            this.dgvListClasses.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListClasses_RowEnter);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaLop";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 160;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "SoHocVienDuKien";
            this.Column2.HeaderText = "Expected Students";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 160;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "CaHoc";
            this.Column3.HeaderText = "Shift";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 160;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ThuocKhoaHoc";
            this.Column4.HeaderText = "Course\'s ID";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 160;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "NgayHocTrongTuan";
            this.Column5.HeaderText = "Day of week";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 160;
            // 
            // rbtAll
            // 
            this.rbtAll.AutoSize = true;
            this.rbtAll.Checked = true;
            this.rbtAll.Location = new System.Drawing.Point(595, 5);
            this.rbtAll.Name = "rbtAll";
            this.rbtAll.Size = new System.Drawing.Size(44, 24);
            this.rbtAll.TabIndex = 29;
            this.rbtAll.TabStop = true;
            this.rbtAll.Text = "All";
            this.rbtAll.UseVisualStyleBackColor = true;
            this.rbtAll.CheckedChanged += new System.EventHandler(this.rbtAll_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(65, 392);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 20);
            this.label10.TabIndex = 26;
            this.label10.Text = "Day of week:";
            // 
            // txtCource
            // 
            this.txtCource.Location = new System.Drawing.Point(188, 301);
            this.txtCource.Name = "txtCource";
            this.txtCource.ReadOnly = true;
            this.txtCource.Size = new System.Drawing.Size(200, 26);
            this.txtCource.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(67, 385);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 20);
            this.label11.TabIndex = 35;
            this.label11.Text = "Day of week:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "2-4-6",
            "3-5-7"});
            this.comboBox2.Location = new System.Drawing.Point(190, 382);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(197, 28);
            this.comboBox2.TabIndex = 34;
            // 
            // Classes_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rbtAll);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.rbtOdd);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.rbtEven);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvListClasses);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Classes_UserControl";
            this.Size = new System.Drawing.Size(1233, 674);
            this.Load += new System.EventHandler(this.Classes_UserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrShift)).EndInit();
            this.tabEdit.ResumeLayout(false);
            this.tabEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrStudents)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabAdd.ResumeLayout(false);
            this.tabAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListClasses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown nmrShift;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TabPage tabEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHideOrAvailable;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabAdd;
        private System.Windows.Forms.RadioButton rbtOdd;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.RadioButton rbtEven;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvListClasses;
        private System.Windows.Forms.ComboBox cmbDayOfWeek;
        private System.Windows.Forms.NumericUpDown nmrStudents;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rbtAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TextBox txtCource;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}
