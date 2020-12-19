
namespace ProjectHQTCSDL.Usercontrol
{
    partial class Schedule_UserControl
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
            this.Week = new System.Windows.Forms.Label();
            this.cbbWeek = new System.Windows.Forms.ComboBox();
            this.dgvSchedule = new System.Windows.Forms.DataGridView();
            this.colShift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMonday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTuesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWednesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThursday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFriday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaturday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSunday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // Week
            // 
            this.Week.AutoSize = true;
            this.Week.Location = new System.Drawing.Point(460, 30);
            this.Week.Name = "Week";
            this.Week.Size = new System.Drawing.Size(56, 20);
            this.Week.TabIndex = 0;
            this.Week.Text = "Week:";
            // 
            // cbbWeek
            // 
            this.cbbWeek.FormattingEnabled = true;
            this.cbbWeek.Location = new System.Drawing.Point(544, 27);
            this.cbbWeek.Name = "cbbWeek";
            this.cbbWeek.Size = new System.Drawing.Size(211, 28);
            this.cbbWeek.TabIndex = 1;
            this.cbbWeek.SelectedIndexChanged += new System.EventHandler(this.cbbWeek_SelectedIndexChanged);
            // 
            // dgvSchedule
            // 
            this.dgvSchedule.AllowUserToAddRows = false;
            this.dgvSchedule.AllowUserToDeleteRows = false;
            this.dgvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colShift,
            this.colMonday,
            this.colTuesday,
            this.colWednesday,
            this.colThursday,
            this.colFriday,
            this.colSaturday,
            this.colSunday});
            this.dgvSchedule.Location = new System.Drawing.Point(45, 94);
            this.dgvSchedule.Name = "dgvSchedule";
            this.dgvSchedule.ReadOnly = true;
            this.dgvSchedule.RowHeadersVisible = false;
            this.dgvSchedule.Size = new System.Drawing.Size(1142, 550);
            this.dgvSchedule.TabIndex = 2;
            // 
            // colShift
            // 
            this.colShift.DataPropertyName = "colShift";
            this.colShift.HeaderText = "Shift";
            this.colShift.Name = "colShift";
            this.colShift.ReadOnly = true;
            this.colShift.Width = 50;
            // 
            // colMonday
            // 
            this.colMonday.DataPropertyName = "colMonday";
            this.colMonday.HeaderText = "Monday";
            this.colMonday.Name = "colMonday";
            this.colMonday.ReadOnly = true;
            this.colMonday.Width = 157;
            // 
            // colTuesday
            // 
            this.colTuesday.DataPropertyName = "colTuesday";
            this.colTuesday.HeaderText = "Tuesday";
            this.colTuesday.Name = "colTuesday";
            this.colTuesday.ReadOnly = true;
            this.colTuesday.Width = 157;
            // 
            // colWednesday
            // 
            this.colWednesday.DataPropertyName = "colWednesday";
            this.colWednesday.HeaderText = "Wednesday";
            this.colWednesday.Name = "colWednesday";
            this.colWednesday.ReadOnly = true;
            this.colWednesday.Width = 157;
            // 
            // colThursday
            // 
            this.colThursday.DataPropertyName = "colThursday";
            this.colThursday.HeaderText = "Thursday";
            this.colThursday.Name = "colThursday";
            this.colThursday.ReadOnly = true;
            this.colThursday.Width = 157;
            // 
            // colFriday
            // 
            this.colFriday.DataPropertyName = "colFriday";
            this.colFriday.HeaderText = "Friday";
            this.colFriday.Name = "colFriday";
            this.colFriday.ReadOnly = true;
            this.colFriday.Width = 157;
            // 
            // colSaturday
            // 
            this.colSaturday.DataPropertyName = "colSaturday";
            this.colSaturday.HeaderText = "Saturday";
            this.colSaturday.Name = "colSaturday";
            this.colSaturday.ReadOnly = true;
            this.colSaturday.Width = 157;
            // 
            // colSunday
            // 
            this.colSunday.DataPropertyName = "colSunday";
            this.colSunday.HeaderText = "Sunday";
            this.colSunday.Name = "colSunday";
            this.colSunday.ReadOnly = true;
            this.colSunday.Width = 148;
            // 
            // Schedule_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvSchedule);
            this.Controls.Add(this.cbbWeek);
            this.Controls.Add(this.Week);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Schedule_UserControl";
            this.Size = new System.Drawing.Size(1233, 674);
            this.Load += new System.EventHandler(this.Schedule_UserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Week;
        private System.Windows.Forms.DataGridView dgvSchedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShift;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMonday;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTuesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWednesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThursday;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFriday;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaturday;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSunday;
        public System.Windows.Forms.ComboBox cbbWeek;
    }
}
