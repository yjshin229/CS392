namespace BMICalculatorDB
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
            this.groupBoxCalculator = new System.Windows.Forms.GroupBox();
            this.labelEnterName = new System.Windows.Forms.Label();
            this.labelEnterWeight = new System.Windows.Forms.Label();
            this.labelEnterHeight = new System.Windows.Forms.Label();
            this.labelEnterGender = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.numericHeight = new System.Windows.Forms.NumericUpDown();
            this.numericWeight = new System.Windows.Forms.NumericUpDown();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelBMI = new System.Windows.Forms.Label();
            this.textBoxBMI = new System.Windows.Forms.TextBox();
            this.buttonDB = new System.Windows.Forms.Button();
            this.groupBoxCalculator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCalculator
            // 
            this.groupBoxCalculator.Controls.Add(this.textBoxBMI);
            this.groupBoxCalculator.Controls.Add(this.labelBMI);
            this.groupBoxCalculator.Controls.Add(this.buttonCalculate);
            this.groupBoxCalculator.Controls.Add(this.comboBoxGender);
            this.groupBoxCalculator.Controls.Add(this.numericWeight);
            this.groupBoxCalculator.Controls.Add(this.numericHeight);
            this.groupBoxCalculator.Controls.Add(this.textBoxName);
            this.groupBoxCalculator.Controls.Add(this.labelEnterGender);
            this.groupBoxCalculator.Controls.Add(this.labelEnterHeight);
            this.groupBoxCalculator.Controls.Add(this.labelEnterWeight);
            this.groupBoxCalculator.Controls.Add(this.labelEnterName);
            this.groupBoxCalculator.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCalculator.Location = new System.Drawing.Point(35, 33);
            this.groupBoxCalculator.Name = "groupBoxCalculator";
            this.groupBoxCalculator.Size = new System.Drawing.Size(703, 356);
            this.groupBoxCalculator.TabIndex = 0;
            this.groupBoxCalculator.TabStop = false;
            this.groupBoxCalculator.Text = "Calculator";
            // 
            // labelEnterName
            // 
            this.labelEnterName.AutoSize = true;
            this.labelEnterName.Location = new System.Drawing.Point(161, 46);
            this.labelEnterName.Name = "labelEnterName";
            this.labelEnterName.Size = new System.Drawing.Size(103, 25);
            this.labelEnterName.TabIndex = 0;
            this.labelEnterName.Text = "Your Name:";
            // 
            // labelEnterWeight
            // 
            this.labelEnterWeight.AutoSize = true;
            this.labelEnterWeight.Location = new System.Drawing.Point(161, 98);
            this.labelEnterWeight.Name = "labelEnterWeight";
            this.labelEnterWeight.Size = new System.Drawing.Size(155, 25);
            this.labelEnterWeight.TabIndex = 1;
            this.labelEnterWeight.Text = "Weight in Pounds:";
            // 
            // labelEnterHeight
            // 
            this.labelEnterHeight.AutoSize = true;
            this.labelEnterHeight.Location = new System.Drawing.Point(161, 148);
            this.labelEnterHeight.Name = "labelEnterHeight";
            this.labelEnterHeight.Size = new System.Drawing.Size(143, 25);
            this.labelEnterHeight.TabIndex = 2;
            this.labelEnterHeight.Text = "Height in Inches:";
            // 
            // labelEnterGender
            // 
            this.labelEnterGender.AutoSize = true;
            this.labelEnterGender.Location = new System.Drawing.Point(161, 203);
            this.labelEnterGender.Name = "labelEnterGender";
            this.labelEnterGender.Size = new System.Drawing.Size(73, 25);
            this.labelEnterGender.TabIndex = 3;
            this.labelEnterGender.Text = "Gender:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(371, 43);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(195, 31);
            this.textBoxName.TabIndex = 4;
            // 
            // numericHeight
            // 
            this.numericHeight.Location = new System.Drawing.Point(371, 148);
            this.numericHeight.Name = "numericHeight";
            this.numericHeight.Size = new System.Drawing.Size(120, 31);
            this.numericHeight.TabIndex = 5;
            // 
            // numericWeight
            // 
            this.numericWeight.Location = new System.Drawing.Point(371, 98);
            this.numericWeight.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericWeight.Name = "numericWeight";
            this.numericWeight.Size = new System.Drawing.Size(120, 31);
            this.numericWeight.TabIndex = 6;
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.comboBoxGender.Location = new System.Drawing.Point(371, 203);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(195, 33);
            this.comboBoxGender.TabIndex = 7;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(96, 250);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(149, 78);
            this.buttonCalculate.TabIndex = 8;
            this.buttonCalculate.Text = "Calculate Enhanced BMI";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // labelBMI
            // 
            this.labelBMI.AutoSize = true;
            this.labelBMI.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBMI.Location = new System.Drawing.Point(345, 286);
            this.labelBMI.Name = "labelBMI";
            this.labelBMI.Size = new System.Drawing.Size(57, 30);
            this.labelBMI.TabIndex = 9;
            this.labelBMI.Text = "BMI:";
            // 
            // textBoxBMI
            // 
            this.textBoxBMI.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBMI.Location = new System.Drawing.Point(408, 283);
            this.textBoxBMI.Name = "textBoxBMI";
            this.textBoxBMI.Size = new System.Drawing.Size(100, 37);
            this.textBoxBMI.TabIndex = 10;
            // 
            // buttonDB
            // 
            this.buttonDB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDB.Location = new System.Drawing.Point(35, 410);
            this.buttonDB.Name = "buttonDB";
            this.buttonDB.Size = new System.Drawing.Size(136, 50);
            this.buttonDB.TabIndex = 11;
            this.buttonDB.Text = "Save to DB";
            this.buttonDB.UseVisualStyleBackColor = true;
            this.buttonDB.Click += new System.EventHandler(this.buttonDB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 492);
            this.Controls.Add(this.buttonDB);
            this.Controls.Add(this.groupBoxCalculator);
            this.Name = "Form1";
            this.Text = "BMI Calculator with DB";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxCalculator.ResumeLayout(false);
            this.groupBoxCalculator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericWeight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCalculator;
        private System.Windows.Forms.Label labelEnterGender;
        private System.Windows.Forms.Label labelEnterHeight;
        private System.Windows.Forms.Label labelEnterWeight;
        private System.Windows.Forms.Label labelEnterName;
        private System.Windows.Forms.NumericUpDown numericWeight;
        private System.Windows.Forms.NumericUpDown numericHeight;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxBMI;
        private System.Windows.Forms.Label labelBMI;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.Button buttonDB;
    }
}

