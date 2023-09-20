namespace HeadsOrTails
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
            head_picture = new PictureBox();
            tail_picture = new PictureBox();
            head_button = new Button();
            tail_button = new Button();
            exit = new Button();
            ((System.ComponentModel.ISupportInitialize)head_picture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tail_picture).BeginInit();
            SuspendLayout();
            // 
            // head_picture
            // 
            head_picture.Image = Properties.Resources.coin_head;
            head_picture.Location = new Point(138, 72);
            head_picture.Name = "head_picture";
            head_picture.Size = new Size(226, 211);
            head_picture.SizeMode = PictureBoxSizeMode.CenterImage;
            head_picture.TabIndex = 0;
            head_picture.TabStop = false;
            head_picture.Visible = true;
            // 
            // tail_picture
            // 
            tail_picture.Image = Properties.Resources.coin_tail;
            tail_picture.Location = new Point(451, 72);
            tail_picture.Name = "tail_picture";
            tail_picture.Size = new Size(227, 209);
            tail_picture.SizeMode = PictureBoxSizeMode.CenterImage;
            tail_picture.TabIndex = 1;
            tail_picture.TabStop = false;
            tail_picture.Visible = false;
            // 
            // head_button
            // 
            head_button.AutoSize = true;
            head_button.Location = new Point(163, 358);
            head_button.Name = "head_button";
            head_button.Size = new Size(84, 25);
            head_button.TabIndex = 2;
            head_button.Text = "Show Heads";
            head_button.UseVisualStyleBackColor = true;
            head_button.Click += head_button_Click;
            // 
            // tail_button
            // 
            tail_button.AutoSize = true;
            tail_button.Location = new Point(372, 358);
            tail_button.Name = "tail_button";
            tail_button.Size = new Size(75, 25);
            tail_button.TabIndex = 3;
            tail_button.Text = "Show Tails";
            tail_button.UseVisualStyleBackColor = true;
            tail_button.Click += tail_button_Click;
            // 
            // exit
            // 
            exit.Location = new Point(583, 358);
            exit.Name = "exit";
            exit.Size = new Size(75, 23);
            exit.TabIndex = 4;
            exit.Text = "Exit";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(exit);
            Controls.Add(tail_button);
            Controls.Add(head_button);
            Controls.Add(tail_picture);
            Controls.Add(head_picture);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)head_picture).EndInit();
            ((System.ComponentModel.ISupportInitialize)tail_picture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox head_picture;
        private PictureBox tail_picture;
        private Button head_button;
        private Button tail_button;
        private Button exit;
    }
}