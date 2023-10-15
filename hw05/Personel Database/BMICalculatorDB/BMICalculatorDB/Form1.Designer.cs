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
            this.textBoxBMI = new System.Windows.Forms.TextBox();
            this.labelBMI = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.numericWeight = new System.Windows.Forms.NumericUpDown();
            this.numericHeight = new System.Windows.Forms.NumericUpDown();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelEnterGender = new System.Windows.Forms.Label();
            this.labelEnterHeight = new System.Windows.Forms.Label();
            this.labelEnterWeight = new System.Windows.Forms.Label();
            this.labelEnterName = new System.Windows.Forms.Label();
            this.buttonDB = new System.Windows.Forms.Button();
            this.groupBoxCalculator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHeight)).BeginInit();
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
            this.groupBoxCalculator.Location = new System.Drawing.Point(27, 20);
            this.groupBoxCalculator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxCalculator.Name = "groupBoxCalculator";
            this.groupBoxCalculator.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxCalculator.Size = new System.Drawing.Size(547, 214);
            this.groupBoxCalculator.TabIndex = 0;
            this.groupBoxCalculator.TabStop = false;
            this.groupBoxCalculator.Text = "Calculator";
            // 
            // textBoxBMI
            // 
            this.textBoxBMI.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBMI.Location = new System.Drawing.Point(317, 170);
            this.textBoxBMI.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxBMI.Name = "textBoxBMI";
            this.textBoxBMI.Size = new System.Drawing.Size(79, 27);
            this.textBoxBMI.TabIndex = 10;
            // 
            // labelBMI
            // 
            this.labelBMI.AutoSize = true;
            this.labelBMI.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBMI.Location = new System.Drawing.Point(268, 172);
            this.labelBMI.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBMI.Name = "labelBMI";
            this.labelBMI.Size = new System.Drawing.Size(38, 20);
            this.labelBMI.TabIndex = 9;
            this.labelBMI.Text = "BMI:";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(75, 150);
            this.buttonCalculate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(116, 47);
            this.buttonCalculate.TabIndex = 8;
            this.buttonCalculate.Text = "Calculate Enhanced BMI";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.comboBoxGender.Location = new System.Drawing.Point(289, 122);
            this.comboBoxGender.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(153, 23);
            this.comboBoxGender.TabIndex = 7;
            this.comboBoxGender.SelectedIndex = 0;
            // 
            // numericWeight
            // 
            this.numericWeight.Location = new System.Drawing.Point(289, 59);
            this.numericWeight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericWeight.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericWeight.Name = "numericWeight";
            this.numericWeight.Size = new System.Drawing.Size(93, 23);
            this.numericWeight.TabIndex = 6;
            // 
            // numericHeight
            // 
            this.numericHeight.Location = new System.Drawing.Point(289, 89);
            this.numericHeight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericHeight.Name = "numericHeight";
            this.numericHeight.Size = new System.Drawing.Size(93, 23);
            this.numericHeight.TabIndex = 5;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(289, 26);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(153, 23);
            this.textBoxName.TabIndex = 4;
            // 
            // labelEnterGender
            // 
            this.labelEnterGender.AutoSize = true;
            this.labelEnterGender.Location = new System.Drawing.Point(125, 122);
            this.labelEnterGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEnterGender.Name = "labelEnterGender";
            this.labelEnterGender.Size = new System.Drawing.Size(48, 15);
            this.labelEnterGender.TabIndex = 3;
            this.labelEnterGender.Text = "Gender:";
            // 
            // labelEnterHeight
            // 
            this.labelEnterHeight.AutoSize = true;
            this.labelEnterHeight.Location = new System.Drawing.Point(125, 89);
            this.labelEnterHeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEnterHeight.Name = "labelEnterHeight";
            this.labelEnterHeight.Size = new System.Drawing.Size(96, 15);
            this.labelEnterHeight.TabIndex = 2;
            this.labelEnterHeight.Text = "Height in Inches:";
            // 
            // labelEnterWeight
            // 
            this.labelEnterWeight.AutoSize = true;
            this.labelEnterWeight.Location = new System.Drawing.Point(125, 59);
            this.labelEnterWeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEnterWeight.Name = "labelEnterWeight";
            this.labelEnterWeight.Size = new System.Drawing.Size(104, 15);
            this.labelEnterWeight.TabIndex = 1;
            this.labelEnterWeight.Text = "Weight in Pounds:";
            // 
            // labelEnterName
            // 
            this.labelEnterName.AutoSize = true;
            this.labelEnterName.Location = new System.Drawing.Point(125, 28);
            this.labelEnterName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEnterName.Name = "labelEnterName";
            this.labelEnterName.Size = new System.Drawing.Size(69, 15);
            this.labelEnterName.TabIndex = 0;
            this.labelEnterName.Text = "Your Name:";
            // 
            // buttonDB
            // 
            this.buttonDB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDB.Location = new System.Drawing.Point(27, 246);
            this.buttonDB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDB.Name = "buttonDB";
            this.buttonDB.Size = new System.Drawing.Size(106, 30);
            this.buttonDB.TabIndex = 11;
            this.buttonDB.Text = "Save to DB";
            this.buttonDB.UseVisualStyleBackColor = true;
            this.buttonDB.Click += new System.EventHandler(this.buttonDB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 295);
            this.Controls.Add(this.buttonDB);
            this.Controls.Add(this.groupBoxCalculator);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "BMI Calculator with DB";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxCalculator.ResumeLayout(false);
            this.groupBoxCalculator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHeight)).EndInit();
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

