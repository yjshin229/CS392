namespace RandomNumberGuessingGame
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
            textBox1 = new TextBox();
            guess = new Button();
            again = new Button();
            congrats = new Label();
            hint = new Label();
            numGuess = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 154);
            label1.Name = "label1";
            label1.Size = new Size(146, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter a number to guess: ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(202, 151);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // guess
            // 
            guess.Location = new Point(166, 282);
            guess.Name = "guess";
            guess.Size = new Size(75, 23);
            guess.TabIndex = 2;
            guess.Text = "Guess";
            guess.UseVisualStyleBackColor = true;
            guess.Click += guess_Click;
            // 
            // again
            // 
            again.Location = new Point(166, 336);
            again.Name = "again";
            again.Size = new Size(75, 23);
            again.TabIndex = 3;
            again.Text = "Start Over";
            again.UseVisualStyleBackColor = true;
            again.Visible = false;
            again.Click += again_Click;
            // 
            // congrats
            // 
            congrats.AutoSize = true;
            congrats.Font = new Font("Malgun Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point);
            congrats.Location = new Point(94, 75);
            congrats.Name = "congrats";
            congrats.Size = new Size(220, 37);
            congrats.TabIndex = 4;
            congrats.Text = "Congratulations!";
            congrats.Visible = false;
            // 
            // hint
            // 
            hint.AutoSize = true;
            hint.Location = new Point(184, 205);
            hint.Name = "hint";
            hint.Size = new Size(39, 15);
            hint.TabIndex = 5;
            hint.Text = "label2";
            hint.Visible = false;
            hint.Click += label2_Click;
            // 
            // numGuess
            // 
            numGuess.AutoSize = true;
            numGuess.Location = new Point(193, 239);
            numGuess.Name = "numGuess";
            numGuess.Size = new Size(14, 15);
            numGuess.TabIndex = 6;
            numGuess.Text = "0";
            numGuess.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 450);
            Controls.Add(numGuess);
            Controls.Add(hint);
            Controls.Add(congrats);
            Controls.Add(again);
            Controls.Add(guess);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button guess;
        private Button again;
        private Label congrats;
        private Label hint;
        private Label numGuess;
    }
}