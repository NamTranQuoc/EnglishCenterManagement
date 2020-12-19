
namespace ProjectHQTCSDL.Usercontrol
{
    partial class Guest_UserControl
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
         this.lbName = new System.Windows.Forms.Label();
         this.dgvListClass = new System.Windows.Forms.DataGridView();
         this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         ((System.ComponentModel.ISupportInitialize)(this.dgvListClass)).BeginInit();
         this.SuspendLayout();
         // 
         // lbName
         // 
         this.lbName.AutoSize = true;
         this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lbName.Location = new System.Drawing.Point(566, 21);
         this.lbName.Name = "lbName";
         this.lbName.Size = new System.Drawing.Size(139, 25);
         this.lbName.TabIndex = 0;
         this.lbName.Text = "Name course";
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
            this.Column6});
         this.dgvListClass.Location = new System.Drawing.Point(116, 69);
         this.dgvListClass.Name = "dgvListClass";
         this.dgvListClass.ReadOnly = true;
         this.dgvListClass.RowHeadersVisible = false;
         this.dgvListClass.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
         this.dgvListClass.Size = new System.Drawing.Size(991, 579);
         this.dgvListClass.TabIndex = 1;
         // 
         // Column1
         // 
         this.Column1.DataPropertyName = "IdClass";
         this.Column1.HeaderText = "ID Class";
         this.Column1.Name = "Column1";
         this.Column1.ReadOnly = true;
         // 
         // Column2
         // 
         this.Column2.DataPropertyName = "Shift";
         this.Column2.HeaderText = "Shift";
         this.Column2.Name = "Column2";
         this.Column2.ReadOnly = true;
         // 
         // Column3
         // 
         this.Column3.DataPropertyName = "DOW";
         this.Column3.HeaderText = "DOW";
         this.Column3.Name = "Column3";
         this.Column3.ReadOnly = true;
         this.Column3.Width = 180;
         // 
         // Column4
         // 
         this.Column4.DataPropertyName = "NOS";
         this.Column4.HeaderText = "NOS";
         this.Column4.Name = "Column4";
         this.Column4.ReadOnly = true;
         this.Column4.Width = 180;
         // 
         // Column5
         // 
         this.Column5.DataPropertyName = "Tuition";
         this.Column5.HeaderText = "Tuition";
         this.Column5.Name = "Column5";
         this.Column5.ReadOnly = true;
         this.Column5.Width = 220;
         // 
         // Column6
         // 
         this.Column6.DataPropertyName = "StartDay";
         this.Column6.HeaderText = "Start Dates";
         this.Column6.Name = "Column6";
         this.Column6.ReadOnly = true;
         this.Column6.Width = 220;
         // 
         // Guest_UserControl
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.White;
         this.Controls.Add(this.dgvListClass);
         this.Controls.Add(this.lbName);
         this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Margin = new System.Windows.Forms.Padding(4);
         this.Name = "Guest_UserControl";
         this.Size = new System.Drawing.Size(1233, 674);
         ((System.ComponentModel.ISupportInitialize)(this.dgvListClass)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lbName;
        public System.Windows.Forms.DataGridView dgvListClass;
      private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
      private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
      private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
      private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
      private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
      private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
   }
}
