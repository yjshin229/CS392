namespace JokeAndPunchLine
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
            joke = new Label();
            answer = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // joke
            // 
            joke.AutoSize = true;
            joke.Location = new Point(236, 153);
            joke.Name = "joke";
            joke.Size = new Size(334, 15);
            joke.TabIndex = 0;
            joke.Text = "How many programmers does it take to change a lightbulb?";
            joke.Visible = false;
            // 
            // answer
            // 
            answer.AutoSize = true;
            answer.Location = new Point(305, 292);
            answer.Name = "answer";
            answer.Size = new Size(182, 15);
            answer.TabIndex = 1;
            answer.Text = "None. That's a harware problem.";
            answer.Visible = false;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Location = new Point(305, 94);
            button1.Name = "button1";
            button1.Size = new Size(171, 25);
            button1.TabIndex = 2;
            button1.Text = "Do you want to hear a joke?";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.Location = new Point(334, 216);
            button2.Name = "button2";
            button2.Size = new Size(121, 25);
            button2.TabIndex = 3;
            button2.Text = "What's the answer?";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(answer);
            Controls.Add(joke);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label joke;
        private Label answer;
        private Button button1;
        private Button button2;
    }
}