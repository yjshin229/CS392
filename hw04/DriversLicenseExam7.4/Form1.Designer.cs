namespace DriversLicenseExam7._4
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
            upload_button = new Button();
            result_button = new Button();
            exit_button = new Button();
            result_text = new Label();
            correct = new Label();
            incorrect = new Label();
            incorrect_questions = new Label();
            incorrect_answers = new Label();
            incorrect_count = new Label();
            correct_count = new Label();
            file_name = new Label();
            path_text = new Label();
            SuspendLayout();
            // 
            // upload_button
            // 
            upload_button.Location = new Point(168, 306);
            upload_button.Name = "upload_button";
            upload_button.Size = new Size(89, 45);
            upload_button.TabIndex = 0;
            upload_button.Text = "Upload";
            upload_button.UseVisualStyleBackColor = true;
            upload_button.Click += upload_button_Click;
            // 
            // result_button
            // 
            result_button.Location = new Point(348, 306);
            result_button.Name = "result_button";
            result_button.Size = new Size(89, 45);
            result_button.TabIndex = 1;
            result_button.Text = "Result";
            result_button.UseVisualStyleBackColor = true;
            result_button.Click += result_button_Click;
            // 
            // exit_button
            // 
            exit_button.Location = new Point(528, 306);
            exit_button.Name = "exit_button";
            exit_button.Size = new Size(89, 45);
            exit_button.TabIndex = 2;
            exit_button.Text = "Exit";
            exit_button.UseVisualStyleBackColor = true;
            exit_button.Click += exit_button_Click;
            // 
            // result_text
            // 
            result_text.Font = new Font("Malgun Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            result_text.Location = new Point(242, 74);
            result_text.Name = "result_text";
            result_text.Size = new Size(301, 43);
            result_text.TabIndex = 3;
            result_text.Text = "Upload A Text File Please.";
            result_text.TextAlign = ContentAlignment.MiddleCenter;
            result_text.Click += label1_Click;
            // 
            // correct
            // 
            correct.AutoSize = true;
            correct.Location = new Point(242, 173);
            correct.Name = "correct";
            correct.Size = new Size(49, 15);
            correct.TabIndex = 4;
            correct.Text = "Correct:";
            // 
            // incorrect
            // 
            incorrect.AutoSize = true;
            incorrect.Location = new Point(234, 212);
            incorrect.Name = "incorrect";
            incorrect.Size = new Size(57, 15);
            incorrect.TabIndex = 5;
            incorrect.Text = "Incorrect:";
            // 
            // incorrect_questions
            // 
            incorrect_questions.AutoSize = true;
            incorrect_questions.Location = new Point(179, 251);
            incorrect_questions.Name = "incorrect_questions";
            incorrect_questions.Size = new Size(112, 15);
            incorrect_questions.TabIndex = 6;
            incorrect_questions.Text = "Incorrect questions:";
            incorrect_questions.Visible = false;
            // 
            // incorrect_answers
            // 
            incorrect_answers.AutoSize = true;
            incorrect_answers.Location = new Point(297, 251);
            incorrect_answers.Name = "incorrect_answers";
            incorrect_answers.Size = new Size(0, 15);
            incorrect_answers.TabIndex = 7;
            incorrect_answers.Visible = false;
            incorrect_answers.Click += incorrect_answers_Click;
            // 
            // incorrect_count
            // 
            incorrect_count.AutoSize = true;
            incorrect_count.Location = new Point(297, 212);
            incorrect_count.Name = "incorrect_count";
            incorrect_count.Size = new Size(39, 15);
            incorrect_count.TabIndex = 8;
            incorrect_count.Text = "label2";
            incorrect_count.Visible = false;
            // 
            // correct_count
            // 
            correct_count.AutoSize = true;
            correct_count.Location = new Point(297, 173);
            correct_count.Name = "correct_count";
            correct_count.Size = new Size(39, 15);
            correct_count.TabIndex = 9;
            correct_count.Text = "label3";
            correct_count.Visible = false;
            // 
            // file_name
            // 
            file_name.AutoSize = true;
            file_name.Location = new Point(227, 134);
            file_name.Name = "file_name";
            file_name.Size = new Size(64, 15);
            file_name.TabIndex = 10;
            file_name.Text = "File Name:";
            // 
            // path_text
            // 
            path_text.AutoSize = true;
            path_text.Location = new Point(297, 134);
            path_text.Name = "path_text";
            path_text.Size = new Size(0, 15);
            path_text.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(path_text);
            Controls.Add(file_name);
            Controls.Add(correct_count);
            Controls.Add(incorrect_count);
            Controls.Add(incorrect_answers);
            Controls.Add(incorrect_questions);
            Controls.Add(incorrect);
            Controls.Add(correct);
            Controls.Add(result_text);
            Controls.Add(exit_button);
            Controls.Add(result_button);
            Controls.Add(upload_button);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button upload_button;
        private Button result_button;
        private Button exit_button;
        private Label result_text;
        private Label correct;
        private Label incorrect;
        private Label incorrect_questions;
        private Label incorrect_answers;
        private Label incorrect_count;
        private Label correct_count;
        private Label file_name;
        private Label path_text;
    }
}