namespace GeoTest
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.getLocationButton = new System.Windows.Forms.Button();
            this.showLocationTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Location:";
            // 
            // getLocationButton
            // 
            this.getLocationButton.AutoSize = true;
            this.getLocationButton.Location = new System.Drawing.Point(12, 47);
            this.getLocationButton.Name = "getLocationButton";
            this.getLocationButton.Size = new System.Drawing.Size(150, 23);
            this.getLocationButton.TabIndex = 1;
            this.getLocationButton.Text = "Get My Location";
            this.getLocationButton.UseVisualStyleBackColor = true;
            this.getLocationButton.Click += new System.EventHandler(this.getLocationButton_Click);
            // 
            // showLocationTextBox
            // 
            this.showLocationTextBox.Location = new System.Drawing.Point(12, 126);
            this.showLocationTextBox.Multiline = true;
            this.showLocationTextBox.Name = "showLocationTextBox";
            this.showLocationTextBox.Size = new System.Drawing.Size(258, 102);
            this.showLocationTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 270);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.showLocationTextBox);
            this.Controls.Add(this.getLocationButton);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button getLocationButton;
        private System.Windows.Forms.TextBox showLocationTextBox;
        private System.Windows.Forms.Label label2;
    }
}

