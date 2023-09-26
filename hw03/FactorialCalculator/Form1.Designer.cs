namespace FactorialCalculator
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
            input = new TextBox();
            result = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 145);
            label1.Name = "label1";
            label1.Size = new Size(163, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter a non-negative integer:";
            // 
            // input
            // 
            input.Location = new Point(203, 142);
            input.Name = "input";
            input.Size = new Size(100, 23);
            input.TabIndex = 1;
            input.Click += input_Click;
            input.KeyPress += input_KeyPress;
            // 
            // result
            // 
            result.Location = new Point(25, 302);
            result.Name = "result";
            result.Size = new Size(326, 117);
            result.TabIndex = 2;
            result.Text = "label2";
            result.TextAlign = ContentAlignment.MiddleCenter;
            result.Visible = false;
            // 
            // button1
            // 
            button1.Location = new Point(138, 222);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 450);
            Controls.Add(button1);
            Controls.Add(result);
            Controls.Add(input);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox input;
        private Label result;
        private Button button1;
    }
}