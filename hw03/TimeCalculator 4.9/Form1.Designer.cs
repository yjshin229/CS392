namespace TimeCalculator
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
            label1 = new Label();
            label2 = new Label();
            inputSec = new TextBox();
            output = new TextBox();
            calculate = new Button();
            exit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 49);
            label1.Name = "label1";
            label1.Size = new Size(149, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter number of seconds: ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 111);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 1;
            label2.Text = "Result:";
            // 
            // inputSec
            // 
            inputSec.Location = new Point(176, 46);
            inputSec.Name = "inputSec";
            inputSec.Size = new Size(100, 23);
            inputSec.TabIndex = 2;
            inputSec.TextChanged += textBox1_TextChanged;
            inputSec.KeyPress += inputSec_KeyPress;
            // 
            // output
            // 
            output.Location = new Point(146, 108);
            output.Name = "output";
            output.ReadOnly = true;
            output.Size = new Size(100, 23);
            output.TabIndex = 3;
            // 
            // calculate
            // 
            calculate.Location = new Point(61, 178);
            calculate.Name = "calculate";
            calculate.Size = new Size(75, 23);
            calculate.TabIndex = 4;
            calculate.Text = "Calculate";
            calculate.UseVisualStyleBackColor = true;
            calculate.Click += calculate_Click;
            // 
            // exit
            // 
            exit.Location = new Point(171, 178);
            exit.Name = "exit";
            exit.Size = new Size(75, 23);
            exit.TabIndex = 5;
            exit.Text = "Exit";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(305, 239);
            Controls.Add(exit);
            Controls.Add(calculate);
            Controls.Add(output);
            Controls.Add(inputSec);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox inputSec;
        private TextBox output;
        private Button calculate;
        private Button exit;
    }
}