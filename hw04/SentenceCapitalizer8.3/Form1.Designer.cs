namespace SentenceCapitalizer8._3
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
            labelEnter = new Label();
            label2 = new Label();
            textBoxInput = new TextBox();
            buttonCapitalize = new Button();
            buttonClear = new Button();
            SuspendLayout();
            // 
            // labelEnter
            // 
            labelEnter.AutoSize = true;
            labelEnter.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelEnter.Location = new Point(283, 62);
            labelEnter.Name = "labelEnter";
            labelEnter.Size = new Size(201, 32);
            labelEnter.TabIndex = 0;
            labelEnter.Text = "Enter a sentence:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 8);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 1;
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(133, 142);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(496, 31);
            textBoxInput.TabIndex = 2;
            // 
            // buttonCapitalize
            // 
            buttonCapitalize.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCapitalize.Location = new Point(297, 255);
            buttonCapitalize.Name = "buttonCapitalize";
            buttonCapitalize.Size = new Size(173, 77);
            buttonCapitalize.TabIndex = 3;
            buttonCapitalize.Text = "Capitalize";
            buttonCapitalize.UseVisualStyleBackColor = true;
            buttonCapitalize.Click += buttonCapitalize_Click;
            // 
            // buttonClear
            // 
            buttonClear.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonClear.Location = new Point(603, 344);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(145, 73);
            buttonClear.TabIndex = 4;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonClear);
            Controls.Add(buttonCapitalize);
            Controls.Add(textBoxInput);
            Controls.Add(label2);
            Controls.Add(labelEnter);
            Name = "Form1";
            Text = "Sentence Capitalizer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelEnter;
        private Label label2;
        private TextBox textBoxInput;
        private Button buttonCapitalize;
        private Button buttonClear;
    }
}