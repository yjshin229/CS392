namespace SecondGradeFlashCard
{
    partial class addition
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
            Second_Number = new Label();
            First_Number = new Label();
            label3 = new Label();
            Operator = new Label();
            button1 = new Button();
            Addition_Radio = new RadioButton();
            Subtraction_Radio = new RadioButton();
            Answer_Text = new Label();
            Submit_Button = new Button();
            label1 = new Label();
            Answer_Textbox = new TextBox();
            Question_Number_label = new Label();
            label4 = new Label();
            label5 = new Label();
            Next_Button = new Button();
            label2 = new Label();
            Previous_Button = new Button();
            SuspendLayout();
            // 
            // Second_Number
            // 
            Second_Number.BackColor = SystemColors.ControlLight;
            Second_Number.Font = new Font("Arial", 54F, FontStyle.Regular, GraphicsUnit.Point);
            Second_Number.Location = new Point(115, 209);
            Second_Number.Name = "Second_Number";
            Second_Number.Size = new Size(100, 100);
            Second_Number.TabIndex = 0;
            Second_Number.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // First_Number
            // 
            First_Number.BackColor = SystemColors.ControlLight;
            First_Number.Font = new Font("Arial", 54F, FontStyle.Regular, GraphicsUnit.Point);
            First_Number.Location = new Point(115, 51);
            First_Number.Name = "First_Number";
            First_Number.Size = new Size(100, 100);
            First_Number.TabIndex = 1;
            First_Number.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Location = new Point(3, 176);
            label3.Name = "label3";
            label3.Size = new Size(275, 2);
            label3.TabIndex = 2;
            label3.Text = "label3";
            // 
            // Operator
            // 
            Operator.BackColor = SystemColors.ControlLight;
            Operator.Font = new Font("Arial", 40F, FontStyle.Regular, GraphicsUnit.Point);
            Operator.Location = new Point(29, 244);
            Operator.Name = "Operator";
            Operator.Size = new Size(55, 65);
            Operator.TabIndex = 3;
            Operator.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(12, 348);
            button1.Name = "button1";
            button1.Size = new Size(255, 23);
            button1.TabIndex = 5;
            button1.Text = "Generate 10 Random problems";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Addition_Radio
            // 
            Addition_Radio.AutoSize = true;
            Addition_Radio.Checked = true;
            Addition_Radio.Location = new Point(56, 377);
            Addition_Radio.Name = "Addition_Radio";
            Addition_Radio.Size = new Size(71, 19);
            Addition_Radio.TabIndex = 6;
            Addition_Radio.TabStop = true;
            Addition_Radio.Text = "Addition";
            Addition_Radio.UseVisualStyleBackColor = true;
            // 
            // Subtraction_Radio
            // 
            Subtraction_Radio.AutoSize = true;
            Subtraction_Radio.Location = new Point(149, 377);
            Subtraction_Radio.Name = "Subtraction_Radio";
            Subtraction_Radio.Size = new Size(87, 19);
            Subtraction_Radio.TabIndex = 7;
            Subtraction_Radio.TabStop = true;
            Subtraction_Radio.Text = "Subtraction";
            Subtraction_Radio.UseVisualStyleBackColor = true;
            // 
            // Answer_Text
            // 
            Answer_Text.AutoSize = true;
            Answer_Text.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Answer_Text.Location = new Point(12, 404);
            Answer_Text.Name = "Answer_Text";
            Answer_Text.Size = new Size(100, 18);
            Answer_Text.TabIndex = 8;
            Answer_Text.Text = "Your Answer:";
            // 
            // Submit_Button
            // 
            Submit_Button.Location = new Point(200, 402);
            Submit_Button.Name = "Submit_Button";
            Submit_Button.Size = new Size(67, 23);
            Submit_Button.TabIndex = 9;
            Submit_Button.Text = "Submit";
            Submit_Button.UseVisualStyleBackColor = true;
            Submit_Button.Click += Submit_Button_Click;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(3, 336);
            label1.Name = "label1";
            label1.Size = new Size(275, 2);
            label1.TabIndex = 10;
            label1.Text = "label1";
            // 
            // Answer_Textbox
            // 
            Answer_Textbox.Location = new Point(115, 402);
            Answer_Textbox.Name = "Answer_Textbox";
            Answer_Textbox.Size = new Size(79, 23);
            Answer_Textbox.TabIndex = 11;
            // 
            // Question_Number_label
            // 
            Question_Number_label.AutoSize = true;
            Question_Number_label.Location = new Point(108, 9);
            Question_Number_label.Name = "Question_Number_label";
            Question_Number_label.Size = new Size(14, 15);
            Question_Number_label.TabIndex = 12;
            Question_Number_label.Text = "1";
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Location = new Point(3, 32);
            label4.Name = "label4";
            label4.Size = new Size(275, 2);
            label4.TabIndex = 13;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(128, 9);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 14;
            label5.Text = "/    10";
            // 
            // Next_Button
            // 
            Next_Button.Location = new Point(200, 452);
            Next_Button.Name = "Next_Button";
            Next_Button.Size = new Size(67, 23);
            Next_Button.TabIndex = 16;
            Next_Button.Text = "Next";
            Next_Button.UseVisualStyleBackColor = true;
            Next_Button.Visible = false;
            Next_Button.Click += Next_Button_Click;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(3, 439);
            label2.Name = "label2";
            label2.Size = new Size(275, 2);
            label2.TabIndex = 17;
            label2.Text = "label2";
            // 
            // Previous_Button
            // 
            Previous_Button.Location = new Point(12, 452);
            Previous_Button.Name = "Previous_Button";
            Previous_Button.Size = new Size(67, 23);
            Previous_Button.TabIndex = 18;
            Previous_Button.Text = "Previous";
            Previous_Button.UseVisualStyleBackColor = true;
            Previous_Button.Visible = false;
            Previous_Button.Click += Previous_Button_Click;
            // 
            // addition
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(279, 487);
            Controls.Add(Previous_Button);
            Controls.Add(label2);
            Controls.Add(Next_Button);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(Question_Number_label);
            Controls.Add(Answer_Textbox);
            Controls.Add(label1);
            Controls.Add(Submit_Button);
            Controls.Add(Answer_Text);
            Controls.Add(Subtraction_Radio);
            Controls.Add(Addition_Radio);
            Controls.Add(button1);
            Controls.Add(Operator);
            Controls.Add(label3);
            Controls.Add(First_Number);
            Controls.Add(Second_Number);
            Name = "addition";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Second_Number;
        private Label First_Number;
        private Label label3;
        private Label Operator;
        private Button button1;
        private RadioButton Addition_Radio;
        private RadioButton Subtraction_Radio;
        private Label Answer_Text;
        private Button Submit_Button;
        private Label label1;
        private TextBox Answer_Textbox;
        private Label Question_Number_label;
        private Label label4;
        private Label label5;
        private Button Next_Button;
        private Label label2;
        private Button Previous_Button;
    }
}