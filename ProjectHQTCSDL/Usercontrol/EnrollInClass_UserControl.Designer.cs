
namespace ProjectHQTCSDL.Usercontrol
{
    partial class EnrollInClass_UserControl
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
         this.dgvListClass = new System.Windows.Forms.DataGridView();
         this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
         this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.panel1 = new System.Windows.Forms.Panel();
         this.cbbCourceName = new System.Windows.Forms.ComboBox();
         this.cbbDOW = new System.Windows.Forms.ComboBox();
         this.cbbShift = new System.Windows.Forms.ComboBox();
         this.btnSave = new System.Windows.Forms.Button();
         this.label3 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.dgvListClass)).BeginInit();
         this.panel1.SuspendLayout();
         this.SuspendLayout();
         // 
         // dgvListClass
         // 
         this.dgvListClass.AllowUserToAddRows = false;
         this.dgvListClass.AllowUserToDeleteRows = false;
         this.dgvListClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dgvListClass.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Select,
            this.Column7});
         this.dgvListClass.Location = new System.Drawing.Point(3, 3);
         this.dgvListClass.Name = "dgvListClass";
         this.dgvListClass.ReadOnly = true;
         this.dgvListClass.RowHeadersVisible = false;
         this.dgvListClass.ScrollBars = System.Windows.Forms.ScrollBars.None;
         this.dgvListClass.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
         this.dgvListClass.Size = new System.Drawing.Size(918, 668);
         this.dgvListClass.TabIndex = 0;
         this.dgvListClass.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListClass_CellEnter);
         // 
         // Column1
         // 
         this.Column1.DataPropertyName = "IdClass";
         this.Column1.HeaderText = "ID Class";
         this.Column1.Name = "Column1";
         this.Column1.ReadOnly = true;
         this.Column1.Width = 130;
         // 
         // Column2
         // 
         this.Column2.DataPropertyName = "NOSE";
         this.Column2.HeaderText = "Expected";
         this.Column2.Name = "Column2";
         this.Column2.ReadOnly = true;
         this.Column2.Width = 140;
         // 
         // Column3
         // 
         this.Column3.DataPropertyName = "NOS";
         this.Column3.HeaderText = "Registered";
         this.Column3.Name = "Column3";
         this.Column3.ReadOnly = true;
         this.Column3.Width = 140;
         // 
         // Column4
         // 
         this.Column4.DataPropertyName = "Shift";
         this.Column4.HeaderText = "Shift";
         this.Column4.Name = "Column4";
         this.Column4.ReadOnly = true;
         // 
         // Column5
         // 
         this.Column5.DataPropertyName = "DOW";
         this.Column5.HeaderText = "DOW";
         this.Column5.Name = "Column5";
         this.Column5.ReadOnly = true;
         // 
         // Column6
         // 
         this.Column6.DataPropertyName = "NameCourse";
         this.Column6.HeaderText = "Cource\'s Name";
         this.Column6.Name = "Column6";
         this.Column6.ReadOnly = true;
         this.Column6.Width = 220;
         // 
         // Select
         // 
         this.Select.DataPropertyName = "Select";
         this.Select.HeaderText = "Select";
         this.Select.Name = "Select";
         this.Select.ReadOnly = true;
         this.Select.Resizable = System.Windows.Forms.DataGridViewTriState.True;
         this.Select.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
         this.Select.Width = 80;
         // 
         // Column7
         // 
         this.Column7.DataPropertyName = "IdCourse";
         this.Column7.HeaderText = "ID Cource";
         this.Column7.Name = "Column7";
         this.Column7.ReadOnly = true;
         this.Column7.Width = 120;
         // 
         // panel1
         // 
         this.panel1.Controls.Add(this.cbbCourceName);
         this.panel1.Controls.Add(this.cbbDOW);
         this.panel1.Controls.Add(this.cbbShift);
         this.panel1.Controls.Add(this.btnSave);
         this.panel1.Controls.Add(this.label3);
         this.panel1.Controls.Add(this.label2);
         this.panel1.Controls.Add(this.label1);
         this.panel1.Location = new System.Drawing.Point(927, 3);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(303, 668);
         this.panel1.TabIndex = 1;
         // 
         // cbbCourceName
         // 
         this.cbbCourceName.FormattingEnabled = true;
         this.cbbCourceName.Location = new System.Drawing.Point(163, 250);
         this.cbbCourceName.Name = "cbbCourceName";
         this.cbbCourceName.Size = new System.Drawing.Size(121, 28);
         this.cbbCourceName.TabIndex = 6;
         this.cbbCourceName.Text = "All";
         this.cbbCourceName.SelectedIndexChanged += new System.EventHandler(this.cbbCourceName_SelectedIndexChanged);
         // 
         // cbbDOW
         // 
         this.cbbDOW.FormattingEnabled = true;
         this.cbbDOW.Items.AddRange(new object[] {
            "All",
            "2-4-6",
            "3-5-7"});
         this.cbbDOW.Location = new System.Drawing.Point(163, 170);
         this.cbbDOW.Name = "cbbDOW";
         this.cbbDOW.Size = new System.Drawing.Size(121, 28);
         this.cbbDOW.TabIndex = 5;
         this.cbbDOW.Text = "All";
         this.cbbDOW.SelectedIndexChanged += new System.EventHandler(this.cbbDOW_SelectedIndexChanged);
         // 
         // cbbShift
         // 
         this.cbbShift.FormattingEnabled = true;
         this.cbbShift.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "All"});
         this.cbbShift.Location = new System.Drawing.Point(163, 89);
         this.cbbShift.Name = "cbbShift";
         this.cbbShift.Size = new System.Drawing.Size(121, 28);
         this.cbbShift.TabIndex = 4;
         this.cbbShift.Text = "All";
         this.cbbShift.SelectedIndexChanged += new System.EventHandler(this.cbbShift_SelectedIndexChanged);
         // 
         // btnSave
         // 
         this.btnSave.BackColor = System.Drawing.Color.Green;
         this.btnSave.ForeColor = System.Drawing.Color.White;
         this.btnSave.Location = new System.Drawing.Point(97, 487);
         this.btnSave.Name = "btnSave";
         this.btnSave.Size = new System.Drawing.Size(118, 50);
         this.btnSave.TabIndex = 3;
         this.btnSave.Text = "Enroll";
         this.btnSave.UseVisualStyleBackColor = false;
         this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(29, 253);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(128, 20);
         this.label3.TabIndex = 2;
         this.label3.Text = "Cource\'s name: ";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(46, 173);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(111, 20);
         this.label2.TabIndex = 1;
         this.label2.Text = "Day of week: ";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(111, 92);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(46, 20);
         this.label1.TabIndex = 0;
         this.label1.Text = "Shift: ";
         // 
         // EnrollInClass_UserControl
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.White;
         this.Controls.Add(this.panel1);
         this.Controls.Add(this.dgvListClass);
         this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.Name = "EnrollInClass_UserControl";
         this.Size = new System.Drawing.Size(1233, 674);
         this.Load += new System.EventHandler(this.EnrollInClass_UserControl_Load);
         ((System.ComponentModel.ISupportInitialize)(this.dgvListClass)).EndInit();
         this.panel1.ResumeLayout(false);
         this.panel1.PerformLayout();
         this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListClass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbbCourceName;
        private System.Windows.Forms.ComboBox cbbDOW;
        private System.Windows.Forms.ComboBox cbbShift;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}
