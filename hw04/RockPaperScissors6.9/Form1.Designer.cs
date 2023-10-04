namespace RockPaperScissors_6._9
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
            btnRock = new Button();
            btnPaper = new Button();
            btnScissors = new Button();
            lblComputerChoice = new Label();
            lblResult = new Label();
            btnEnd = new Button();
            SuspendLayout();
            // 
            // btnRock
            // 
            btnRock.DialogResult = DialogResult.Ignore;
            btnRock.Location = new Point(72, 78);
            btnRock.Name = "btnRock";
            btnRock.Size = new Size(150, 46);
            btnRock.TabIndex = 0;
            btnRock.Text = "Rock";
            btnRock.UseVisualStyleBackColor = true;
            btnRock.Click += btnRock_Click;
            // 
            // btnPaper
            // 
            btnPaper.Location = new Point(305, 78);
            btnPaper.Name = "btnPaper";
            btnPaper.Size = new Size(150, 46);
            btnPaper.TabIndex = 1;
            btnPaper.Text = "Paper";
            btnPaper.UseVisualStyleBackColor = true;
            btnPaper.Click += btnPaper_Click;
            // 
            // btnScissors
            // 
            btnScissors.Location = new Point(558, 78);
            btnScissors.Name = "btnScissors";
            btnScissors.Size = new Size(150, 46);
            btnScissors.TabIndex = 2;
            btnScissors.Text = "Scissors";
            btnScissors.UseVisualStyleBackColor = true;
            btnScissors.Click += btnScissors_Click;
            // 
            // lblComputerChoice
            // 
            lblComputerChoice.Location = new Point(191, 177);
            lblComputerChoice.Name = "lblComputerChoice";
            lblComputerChoice.Size = new Size(422, 64);
            lblComputerChoice.TabIndex = 4;
            // 
            // lblResult
            // 
            lblResult.Location = new Point(191, 277);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(422, 64);
            lblResult.TabIndex = 5;
            // 
            // btnEnd
            // 
            btnEnd.Location = new Point(558, 374);
            btnEnd.Name = "btnEnd";
            btnEnd.Size = new Size(150, 46);
            btnEnd.TabIndex = 6;
            btnEnd.Text = "End Game";
            btnEnd.UseVisualStyleBackColor = true;
            btnEnd.Click += btnEnd_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEnd);
            Controls.Add(lblResult);
            Controls.Add(lblComputerChoice);
            Controls.Add(btnScissors);
            Controls.Add(btnPaper);
            Controls.Add(btnRock);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRock;
        private Button btnPaper;
        private Button btnScissors;
        private Label lblComputerChoice;
        private Label lblResult;
        private Button btnEnd;
    }
}