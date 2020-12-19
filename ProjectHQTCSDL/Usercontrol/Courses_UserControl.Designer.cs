
namespace ProjectHQTCSDL.Usercontrol
{
    partial class Courses_UserControl
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
         this.dgvListCources = new System.Windows.Forms.DataGridView();
         this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.colNoOfSessions = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.colTuitionFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.tabControl = new System.Windows.Forms.TabControl();
         this.tabEdit = new System.Windows.Forms.TabPage();
         this.btnHideOrAvailable = new System.Windows.Forms.Button();
         this.btnSave = new System.Windows.Forms.Button();
         this.txtID = new System.Windows.Forms.TextBox();
         this.txtName = new System.Windows.Forms.TextBox();
         this.txtTuitionFee = new System.Windows.Forms.TextBox();
         this.txtNo = new System.Windows.Forms.TextBox();
         this.label4 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.tabAdd = new System.Windows.Forms.TabPage();
         this.btnAdd = new System.Windows.Forms.Button();
         this.txtIDNew = new System.Windows.Forms.TextBox();
         this.txtNameNew = new System.Windows.Forms.TextBox();
         this.txtTuitionFeeNew = new System.Windows.Forms.TextBox();
         this.txtNoNew = new System.Windows.Forms.TextBox();
         this.label5 = new System.Windows.Forms.Label();
         this.label6 = new System.Windows.Forms.Label();
         this.label7 = new System.Windows.Forms.Label();
         this.label8 = new System.Windows.Forms.Label();
         this.rbtAll = new System.Windows.Forms.RadioButton();
         this.rbtHide = new System.Windows.Forms.RadioButton();
         this.rbtAvailable = new System.Windows.Forms.RadioButton();
         ((System.ComponentModel.ISupportInitialize)(this.dgvListCources)).BeginInit();
         this.tabControl.SuspendLayout();
         this.tabEdit.SuspendLayout();
         this.tabAdd.SuspendLayout();
         this.SuspendLayout();
         // 
         // dgvListCources
         // 
         this.dgvListCources.AllowUserToAddRows = false;
         this.dgvListCources.AllowUserToDeleteRows = false;
         this.dgvListCources.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dgvListCources.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colName,
            this.colNoOfSessions,
            this.colTuitionFee});
         this.dgvListCources.Location = new System.Drawing.Point(3, 35);
         this.dgvListCources.Name = "dgvListCources";
         this.dgvListCources.ReadOnly = true;
         this.dgvListCources.RowHeadersVisible = false;
         this.dgvListCources.RowHeadersWidth = 51;
         this.dgvListCources.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
         this.dgvListCources.Size = new System.Drawing.Size(804, 636);
         this.dgvListCources.TabIndex = 0;
         this.dgvListCources.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListCources_RowEnter);
         // 
         // colID
         // 
         this.colID.DataPropertyName = "IdCourse";
         this.colID.HeaderText = "Cource\'s ID";
         this.colID.MinimumWidth = 6;
         this.colID.Name = "colID";
         this.colID.ReadOnly = true;
         this.colID.Width = 120;
         // 
         // colName
         // 
         this.colName.DataPropertyName = "NameCourse";
         this.colName.HeaderText = "Name";
         this.colName.MinimumWidth = 6;
         this.colName.Name = "colName";
         this.colName.ReadOnly = true;
         this.colName.Width = 280;
         // 
         // colNoOfSessions
         // 
         this.colNoOfSessions.DataPropertyName = "NOS";
         this.colNoOfSessions.HeaderText = "Number of sessions";
         this.colNoOfSessions.MinimumWidth = 6;
         this.colNoOfSessions.Name = "colNoOfSessions";
         this.colNoOfSessions.ReadOnly = true;
         this.colNoOfSessions.Width = 200;
         // 
         // colTuitionFee
         // 
         this.colTuitionFee.DataPropertyName = "Tuition";
         this.colTuitionFee.HeaderText = "Tuition fee";
         this.colTuitionFee.MinimumWidth = 6;
         this.colTuitionFee.Name = "colTuitionFee";
         this.colTuitionFee.ReadOnly = true;
         this.colTuitionFee.Width = 200;
         // 
         // tabControl
         // 
         this.tabControl.Controls.Add(this.tabEdit);
         this.tabControl.Controls.Add(this.tabAdd);
         this.tabControl.Location = new System.Drawing.Point(809, 3);
         this.tabControl.Name = "tabControl";
         this.tabControl.SelectedIndex = 0;
         this.tabControl.Size = new System.Drawing.Size(421, 668);
         this.tabControl.TabIndex = 1;
         // 
         // tabEdit
         // 
         this.tabEdit.Controls.Add(this.btnHideOrAvailable);
         this.tabEdit.Controls.Add(this.btnSave);
         this.tabEdit.Controls.Add(this.txtID);
         this.tabEdit.Controls.Add(this.txtName);
         this.tabEdit.Controls.Add(this.txtTuitionFee);
         this.tabEdit.Controls.Add(this.txtNo);
         this.tabEdit.Controls.Add(this.label4);
         this.tabEdit.Controls.Add(this.label3);
         this.tabEdit.Controls.Add(this.label2);
         this.tabEdit.Controls.Add(this.label1);
         this.tabEdit.Location = new System.Drawing.Point(4, 29);
         this.tabEdit.Name = "tabEdit";
         this.tabEdit.Padding = new System.Windows.Forms.Padding(3);
         this.tabEdit.Size = new System.Drawing.Size(413, 635);
         this.tabEdit.TabIndex = 0;
         this.tabEdit.Text = "Edit";
         this.tabEdit.UseVisualStyleBackColor = true;
         // 
         // btnHideOrAvailable
         // 
         this.btnHideOrAvailable.BackColor = System.Drawing.Color.Brown;
         this.btnHideOrAvailable.ForeColor = System.Drawing.Color.White;
         this.btnHideOrAvailable.Location = new System.Drawing.Point(235, 538);
         this.btnHideOrAvailable.Name = "btnHideOrAvailable";
         this.btnHideOrAvailable.Size = new System.Drawing.Size(150, 42);
         this.btnHideOrAvailable.TabIndex = 4;
         this.btnHideOrAvailable.Text = "Hide";
         this.btnHideOrAvailable.UseVisualStyleBackColor = false;
         this.btnHideOrAvailable.Click += new System.EventHandler(this.btnHideOrAvailable_Click);
         // 
         // btnSave
         // 
         this.btnSave.BackColor = System.Drawing.Color.Green;
         this.btnSave.ForeColor = System.Drawing.Color.White;
         this.btnSave.Location = new System.Drawing.Point(27, 538);
         this.btnSave.Name = "btnSave";
         this.btnSave.Size = new System.Drawing.Size(150, 42);
         this.btnSave.TabIndex = 3;
         this.btnSave.Text = "Save";
         this.btnSave.UseVisualStyleBackColor = false;
         this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
         // 
         // txtID
         // 
         this.txtID.Location = new System.Drawing.Point(166, 77);
         this.txtID.Name = "txtID";
         this.txtID.ReadOnly = true;
         this.txtID.Size = new System.Drawing.Size(219, 26);
         this.txtID.TabIndex = 7;
         // 
         // txtName
         // 
         this.txtName.Location = new System.Drawing.Point(166, 177);
         this.txtName.Name = "txtName";
         this.txtName.Size = new System.Drawing.Size(219, 26);
         this.txtName.TabIndex = 0;
         // 
         // txtTuitionFee
         // 
         this.txtTuitionFee.Location = new System.Drawing.Point(166, 377);
         this.txtTuitionFee.Name = "txtTuitionFee";
         this.txtTuitionFee.Size = new System.Drawing.Size(219, 26);
         this.txtTuitionFee.TabIndex = 2;
         // 
         // txtNo
         // 
         this.txtNo.Location = new System.Drawing.Point(166, 277);
         this.txtNo.Name = "txtNo";
         this.txtNo.Size = new System.Drawing.Size(219, 26);
         this.txtNo.TabIndex = 1;
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(74, 380);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(86, 20);
         this.label4.TabIndex = 3;
         this.label4.Text = "Tuition fee:";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(10, 280);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(150, 20);
         this.label3.TabIndex = 2;
         this.label3.Text = "Number of sessions:";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(103, 180);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(57, 20);
         this.label2.TabIndex = 1;
         this.label2.Text = "Name:";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(72, 80);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(88, 20);
         this.label1.TabIndex = 0;
         this.label1.Text = "Cource\'ID:";
         // 
         // tabAdd
         // 
         this.tabAdd.Controls.Add(this.btnAdd);
         this.tabAdd.Controls.Add(this.txtIDNew);
         this.tabAdd.Controls.Add(this.txtNameNew);
         this.tabAdd.Controls.Add(this.txtTuitionFeeNew);
         this.tabAdd.Controls.Add(this.txtNoNew);
         this.tabAdd.Controls.Add(this.label5);
         this.tabAdd.Controls.Add(this.label6);
         this.tabAdd.Controls.Add(this.label7);
         this.tabAdd.Controls.Add(this.label8);
         this.tabAdd.Location = new System.Drawing.Point(4, 29);
         this.tabAdd.Name = "tabAdd";
         this.tabAdd.Padding = new System.Windows.Forms.Padding(3);
         this.tabAdd.Size = new System.Drawing.Size(413, 635);
         this.tabAdd.TabIndex = 1;
         this.tabAdd.Text = "Add";
         this.tabAdd.UseVisualStyleBackColor = true;
         // 
         // btnAdd
         // 
         this.btnAdd.BackColor = System.Drawing.Color.Green;
         this.btnAdd.ForeColor = System.Drawing.Color.White;
         this.btnAdd.Location = new System.Drawing.Point(141, 536);
         this.btnAdd.Name = "btnAdd";
         this.btnAdd.Size = new System.Drawing.Size(150, 42);
         this.btnAdd.TabIndex = 10;
         this.btnAdd.Text = "Add";
         this.btnAdd.UseVisualStyleBackColor = false;
         this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
         // 
         // txtIDNew
         // 
         this.txtIDNew.Location = new System.Drawing.Point(166, 77);
         this.txtIDNew.Name = "txtIDNew";
         this.txtIDNew.ReadOnly = true;
         this.txtIDNew.Size = new System.Drawing.Size(219, 26);
         this.txtIDNew.TabIndex = 17;
         // 
         // txtNameNew
         // 
         this.txtNameNew.Location = new System.Drawing.Point(166, 177);
         this.txtNameNew.Name = "txtNameNew";
         this.txtNameNew.Size = new System.Drawing.Size(219, 26);
         this.txtNameNew.TabIndex = 7;
         // 
         // txtTuitionFeeNew
         // 
         this.txtTuitionFeeNew.Location = new System.Drawing.Point(166, 377);
         this.txtTuitionFeeNew.Name = "txtTuitionFeeNew";
         this.txtTuitionFeeNew.Size = new System.Drawing.Size(219, 26);
         this.txtTuitionFeeNew.TabIndex = 9;
         // 
         // txtNoNew
         // 
         this.txtNoNew.Location = new System.Drawing.Point(166, 277);
         this.txtNoNew.Name = "txtNoNew";
         this.txtNoNew.Size = new System.Drawing.Size(219, 26);
         this.txtNoNew.TabIndex = 8;
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(74, 380);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(86, 20);
         this.label5.TabIndex = 13;
         this.label5.Text = "Tuition fee:";
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Location = new System.Drawing.Point(10, 280);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(150, 20);
         this.label6.TabIndex = 12;
         this.label6.Text = "Number of sessions:";
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Location = new System.Drawing.Point(103, 180);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(57, 20);
         this.label7.TabIndex = 11;
         this.label7.Text = "Name:";
         // 
         // label8
         // 
         this.label8.AutoSize = true;
         this.label8.Location = new System.Drawing.Point(72, 80);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(88, 20);
         this.label8.TabIndex = 10;
         this.label8.Text = "Cource\'ID:";
         // 
         // rbtAll
         // 
         this.rbtAll.AutoSize = true;
         this.rbtAll.Location = new System.Drawing.Point(594, 4);
         this.rbtAll.Name = "rbtAll";
         this.rbtAll.Size = new System.Drawing.Size(44, 24);
         this.rbtAll.TabIndex = 4;
         this.rbtAll.Text = "All";
         this.rbtAll.UseVisualStyleBackColor = true;
         this.rbtAll.CheckedChanged += new System.EventHandler(this.rbtAll_CheckedChanged);
         // 
         // rbtHide
         // 
         this.rbtHide.AutoSize = true;
         this.rbtHide.Location = new System.Drawing.Point(644, 4);
         this.rbtHide.Name = "rbtHide";
         this.rbtHide.Size = new System.Drawing.Size(60, 24);
         this.rbtHide.TabIndex = 5;
         this.rbtHide.Text = "Hide";
         this.rbtHide.UseVisualStyleBackColor = true;
         this.rbtHide.CheckedChanged += new System.EventHandler(this.rbtHide_CheckedChanged);
         // 
         // rbtAvailable
         // 
         this.rbtAvailable.AutoSize = true;
         this.rbtAvailable.Checked = true;
         this.rbtAvailable.Location = new System.Drawing.Point(710, 4);
         this.rbtAvailable.Name = "rbtAvailable";
         this.rbtAvailable.Size = new System.Drawing.Size(97, 24);
         this.rbtAvailable.TabIndex = 6;
         this.rbtAvailable.TabStop = true;
         this.rbtAvailable.Text = "Available";
         this.rbtAvailable.UseVisualStyleBackColor = true;
         this.rbtAvailable.CheckedChanged += new System.EventHandler(this.rbtAvailable_CheckedChanged);
         // 
         // Courses_UserControl
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.White;
         this.Controls.Add(this.rbtAvailable);
         this.Controls.Add(this.rbtHide);
         this.Controls.Add(this.rbtAll);
         this.Controls.Add(this.tabControl);
         this.Controls.Add(this.dgvListCources);
         this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.Name = "Courses_UserControl";
         this.Size = new System.Drawing.Size(1233, 674);
         this.Load += new System.EventHandler(this.Cources_UserControl_Load);
         ((System.ComponentModel.ISupportInitialize)(this.dgvListCources)).EndInit();
         this.tabControl.ResumeLayout(false);
         this.tabEdit.ResumeLayout(false);
         this.tabEdit.PerformLayout();
         this.tabAdd.ResumeLayout(false);
         this.tabAdd.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListCources;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabEdit;
        private System.Windows.Forms.Button btnHideOrAvailable;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtTuitionFee;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtIDNew;
        private System.Windows.Forms.TextBox txtNameNew;
        private System.Windows.Forms.TextBox txtTuitionFeeNew;
        private System.Windows.Forms.TextBox txtNoNew;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rbtAll;
        private System.Windows.Forms.RadioButton rbtHide;
        private System.Windows.Forms.RadioButton rbtAvailable;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNoOfSessions;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTuitionFee;
    }
}
