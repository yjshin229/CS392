namespace SalonAppCalendarAPI
{
    partial class SalonApp
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnLoadEvents = new System.Windows.Forms.Button();
            this.btnAddEvent = new System.Windows.Forms.Button();
            this.lstHolidays = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightPink;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(92, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1361, 74);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "WHAT EVENTS ARE ON YOUR CALENDAR?";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLoadEvents
            // 
            this.btnLoadEvents.Location = new System.Drawing.Point(538, 751);
            this.btnLoadEvents.Name = "btnLoadEvents";
            this.btnLoadEvents.Size = new System.Drawing.Size(450, 92);
            this.btnLoadEvents.TabIndex = 3;
            this.btnLoadEvents.Text = "Load Appointments";
            this.btnLoadEvents.UseVisualStyleBackColor = true;
            this.btnLoadEvents.Click += new System.EventHandler(this.btnLoadEvents_Click);
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.Location = new System.Drawing.Point(0, 0);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(75, 23);
            this.btnAddEvent.TabIndex = 0;
            // 
            // lstHolidays
            // 
            this.lstHolidays.BackColor = System.Drawing.Color.PaleVioletRed;
            this.lstHolidays.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstHolidays.HideSelection = false;
            this.lstHolidays.Location = new System.Drawing.Point(118, 129);
            this.lstHolidays.Name = "lstHolidays";
            this.lstHolidays.Size = new System.Drawing.Size(1307, 593);
            this.lstHolidays.TabIndex = 4;
            this.lstHolidays.UseCompatibleStateImageBehavior = false;
            this.lstHolidays.View = System.Windows.Forms.View.Details;
            this.lstHolidays.SelectedIndexChanged += new System.EventHandler(this.lstHolidays_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Appointment";
            this.columnHeader1.Width = 250;
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
            // SalonApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.BackgroundImage = global::SalonAppCalendarAPI.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1595, 876);
            this.Controls.Add(this.lstHolidays);
            this.Controls.Add(this.btnAddEvent);
            this.Controls.Add(this.btnLoadEvents);
            this.Controls.Add(this.textBox1);
            this.Name = "SalonApp";
            this.Text = "SalonApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnLoadEvents;
        private System.Windows.Forms.Button btnAddEvent;
        private System.Windows.Forms.ListView lstHolidays;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

