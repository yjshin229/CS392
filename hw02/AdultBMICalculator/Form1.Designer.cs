namespace AdultBMICalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            height = new Label();
            weight = new Label();
            h1 = new Label();
            h2 = new Label();
            w = new Label();
            english = new LinkLabel();
            metric = new LinkLabel();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // height
            // 
            height.AutoSize = true;
            height.Location = new Point(98, 73);
            height.Name = "height";
            height.Size = new Size(60, 15);
            height.TabIndex = 0;
            height.Text = "1. Height:";
            // 
            // weight
            // 
            weight.AutoSize = true;
            weight.Location = new Point(98, 215);
            weight.Name = "weight";
            weight.Size = new Size(62, 15);
            weight.TabIndex = 1;
            weight.Text = "2. Weight:";
            // 
            // h1
            // 
            h1.AutoSize = true;
            h1.Location = new Point(139, 104);
            h1.Name = "h1";
            h1.Size = new Size(29, 15);
            h1.TabIndex = 2;
            h1.Text = "Feet";
            // 
            // h2
            // 
            h2.AutoSize = true;
            h2.Location = new Point(263, 104);
            h2.Name = "h2";
            h2.Size = new Size(41, 15);
            h2.TabIndex = 3;
            h2.Text = "Inches";
            // 
            // w
            // 
            w.AutoSize = true;
            w.Location = new Point(144, 246);
            w.Name = "w";
            w.Size = new Size(47, 15);
            w.TabIndex = 4;
            w.Text = "Pounds";
            // 
            // english
            // 
            english.AutoSize = true;
            english.Enabled = false;
            english.Location = new Point(614, 33);
            english.Name = "english";
            english.Size = new Size(45, 15);
            english.TabIndex = 7;
            english.TabStop = true;
            english.Text = "English";
            english.LinkClicked += english_LinkClicked;
            // 
            // metric
            // 
            metric.AutoSize = true;
            metric.Location = new Point(687, 33);
            metric.Name = "metric";
            metric.Size = new Size(41, 15);
            metric.TabIndex = 8;
            metric.TabStop = true;
            metric.Text = "Metric";
            metric.LinkClicked += metric_LinkClicked;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(145, 134);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(263, 134);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(144, 264);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(599, 33);
            label1.Name = "label1";
            label1.Size = new Size(146, 15);
            label1.TabIndex = 12;
            label1.Text = "(                |                )";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.Font = new Font("Malgun Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(144, 329);
            button1.Name = "button1";
            button1.Size = new Size(142, 50);
            button1.TabIndex = 13;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(metric);
            Controls.Add(english);
            Controls.Add(w);
            Controls.Add(h2);
            Controls.Add(h1);
            Controls.Add(weight);
            Controls.Add(height);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Adult BMI Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label height;
        private Label weight;
        private Label h1;
        private Label h2;
        private Label w;
        private LinkLabel english;
        private LinkLabel metric;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Button button1;
    }
}