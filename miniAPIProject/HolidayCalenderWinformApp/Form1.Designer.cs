namespace HolidayCalenderWinformApp
{
    partial class HolidayApp
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
            this.btnHolidays = new System.Windows.Forms.Button();
            this.holidayLabel = new System.Windows.Forms.Label();
            this.lstHolidays = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnHolidays
            // 
            this.btnHolidays.BackColor = System.Drawing.Color.HotPink;
            this.btnHolidays.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHolidays.Location = new System.Drawing.Point(596, 178);
            this.btnHolidays.Name = "btnHolidays";
            this.btnHolidays.Size = new System.Drawing.Size(455, 117);
            this.btnHolidays.TabIndex = 0;
            this.btnHolidays.Text = "Press Here to See All U.S. Holidays";
            this.btnHolidays.UseVisualStyleBackColor = false;
            this.btnHolidays.Click += new System.EventHandler(this.btnHolidays_Click);
            // 
            // holidayLabel
            // 
            this.holidayLabel.BackColor = System.Drawing.Color.DeepPink;
            this.holidayLabel.Font = new System.Drawing.Font("Trebuchet MS", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.holidayLabel.Location = new System.Drawing.Point(462, 36);
            this.holidayLabel.Name = "holidayLabel";
            this.holidayLabel.Size = new System.Drawing.Size(738, 114);
            this.holidayLabel.TabIndex = 1;
            this.holidayLabel.Text = "U.S. HOLIDAYS!";
            // 
            // lstHolidays
            // 
            this.lstHolidays.BackColor = System.Drawing.Color.PaleVioletRed;
            this.lstHolidays.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstHolidays.HideSelection = false;
            this.lstHolidays.Location = new System.Drawing.Point(233, 322);
            this.lstHolidays.Name = "lstHolidays";
            this.lstHolidays.Size = new System.Drawing.Size(1231, 997);
            this.lstHolidays.TabIndex = 2;
            this.lstHolidays.UseCompatibleStateImageBehavior = false;
            this.lstHolidays.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Holiday";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Start Date";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "End Date";
            this.columnHeader3.Width = 200;
            // 
            // HolidayApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(1711, 1347);
            this.Controls.Add(this.lstHolidays);
            this.Controls.Add(this.holidayLabel);
            this.Controls.Add(this.btnHolidays);
            this.Name = "HolidayApp";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHolidays;
        private System.Windows.Forms.Label holidayLabel;
        private System.Windows.Forms.ListView lstHolidays;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

