namespace LatinTranslator
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
            Latin = new Label();
            English = new Label();
            latin_1 = new Label();
            latin_2 = new Label();
            latin_3 = new Label();
            english_1 = new Label();
            english_2 = new Label();
            english_3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // Latin
            // 
            Latin.AutoSize = true;
            Latin.Font = new Font("Malgun Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Latin.Location = new Point(12, 9);
            Latin.Name = "Latin";
            Latin.Size = new Size(70, 32);
            Latin.TabIndex = 0;
            Latin.Text = "Latin";
            // 
            // English
            // 
            English.AutoSize = true;
            English.Font = new Font("Malgun Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            English.Location = new Point(258, 9);
            English.Name = "English";
            English.Size = new Size(97, 32);
            English.TabIndex = 1;
            English.Text = "English";
            English.Click += label1_Click;
            // 
            // latin_1
            // 
            latin_1.AutoSize = true;
            latin_1.Location = new Point(27, 64);
            latin_1.Name = "latin_1";
            latin_1.Size = new Size(41, 15);
            latin_1.TabIndex = 2;
            latin_1.Text = "autem";
            latin_1.Click += label1_Click_1;
            // 
            // latin_2
            // 
            latin_2.AutoSize = true;
            latin_2.Location = new Point(27, 106);
            latin_2.Name = "latin_2";
            latin_2.Size = new Size(58, 15);
            latin_2.TabIndex = 3;
            latin_2.Text = "descendit";
            // 
            // latin_3
            // 
            latin_3.AutoSize = true;
            latin_3.Location = new Point(27, 148);
            latin_3.Name = "latin_3";
            latin_3.Size = new Size(52, 15);
            latin_3.TabIndex = 4;
            latin_3.Text = "medium";
            // 
            // english_1
            // 
            english_1.AutoSize = true;
            english_1.Location = new Point(287, 64);
            english_1.Name = "english_1";
            english_1.Size = new Size(21, 15);
            english_1.TabIndex = 5;
            english_1.Text = "up";
            english_1.Visible = false;
            // 
            // english_2
            // 
            english_2.AutoSize = true;
            english_2.Location = new Point(287, 106);
            english_2.Name = "english_2";
            english_2.Size = new Size(37, 15);
            english_2.TabIndex = 6;
            english_2.Text = "down";
            english_2.Visible = false;
            // 
            // english_3
            // 
            english_3.AutoSize = true;
            english_3.Location = new Point(287, 148);
            english_3.Name = "english_3";
            english_3.Size = new Size(40, 15);
            english_3.TabIndex = 7;
            english_3.Text = "center";
            english_3.Visible = false;
            // 
            // button1
            // 
            button1.Location = new Point(133, 56);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "translate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(133, 102);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 9;
            button2.Text = "translate";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(133, 148);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 10;
            button3.Text = "translate";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(english_3);
            Controls.Add(english_2);
            Controls.Add(english_1);
            Controls.Add(latin_3);
            Controls.Add(latin_2);
            Controls.Add(latin_1);
            Controls.Add(English);
            Controls.Add(Latin);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Latin;
        private Label English;
        private Label latin_1;
        private Label latin_2;
        private Label latin_3;
        private Label english_1;
        private Label english_2;
        private Label english_3;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}