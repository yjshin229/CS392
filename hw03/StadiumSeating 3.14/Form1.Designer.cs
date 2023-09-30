namespace StadiumSeating
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
            groupBox1 = new GroupBox();
            inputC = new TextBox();
            inputA = new TextBox();
            inputB = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            total = new TextBox();
            label10 = new Label();
            revC = new TextBox();
            label2 = new Label();
            revA = new TextBox();
            revB = new TextBox();
            label9 = new Label();
            label7 = new Label();
            label8 = new Label();
            calculate = new Button();
            clear = new Button();
            exit = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label3 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(inputC);
            groupBox1.Controls.Add(inputA);
            groupBox1.Controls.Add(inputB);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(34, 52);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(242, 192);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tickets Sold";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // inputC
            // 
            inputC.Location = new Point(71, 149);
            inputC.Name = "inputC";
            inputC.Size = new Size(119, 23);
            inputC.TabIndex = 6;
            inputC.TextChanged += inputC_TextChanged;
            inputC.KeyPress += inputC_KeyPress;
            // 
            // inputA
            // 
            inputA.Location = new Point(72, 76);
            inputA.Name = "inputA";
            inputA.Size = new Size(119, 23);
            inputA.TabIndex = 5;
            inputA.TextChanged += inputA_TextChanged;
            inputA.KeyPress += inputA_KeyPress;
            // 
            // inputB
            // 
            inputB.Location = new Point(71, 115);
            inputB.Name = "inputB";
            inputB.Size = new Size(119, 23);
            inputB.TabIndex = 4;
            inputB.TextChanged += inputB_TextChanged;
            inputB.KeyPress += inputB_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 152);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 3;
            label6.Text = "Class C:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 118);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 2;
            label5.Text = "Class B:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 84);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 1;
            label4.Text = "Class A:";
            // 
            // label1
            // 
            label1.Location = new Point(17, 31);
            label1.Name = "label1";
            label1.Size = new Size(195, 39);
            label1.TabIndex = 0;
            label1.Text = "Enter the number of tickets sold for each class of seats.";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(total);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(revC);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(revA);
            groupBox2.Controls.Add(revB);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(331, 52);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(230, 192);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Revenue Generated";
            // 
            // total
            // 
            total.Location = new Point(76, 147);
            total.Name = "total";
            total.ReadOnly = true;
            total.Size = new Size(119, 23);
            total.TabIndex = 14;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(33, 152);
            label10.Name = "label10";
            label10.Size = new Size(36, 15);
            label10.TabIndex = 13;
            label10.Text = "Total:";
            // 
            // revC
            // 
            revC.Location = new Point(76, 109);
            revC.Name = "revC";
            revC.ReadOnly = true;
            revC.Size = new Size(119, 23);
            revC.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 31);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 1;
            label2.Click += label2_Click;
            // 
            // revA
            // 
            revA.Location = new Point(76, 33);
            revA.Name = "revA";
            revA.ReadOnly = true;
            revA.Size = new Size(119, 23);
            revA.TabIndex = 11;
            // 
            // revB
            // 
            revB.Location = new Point(76, 71);
            revB.Name = "revB";
            revB.ReadOnly = true;
            revB.Size = new Size(119, 23);
            revB.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(21, 36);
            label9.Name = "label9";
            label9.Size = new Size(49, 15);
            label9.TabIndex = 7;
            label9.Text = "Class A:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 112);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 9;
            label7.Text = "Class C:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 74);
            label8.Name = "label8";
            label8.Size = new Size(48, 15);
            label8.TabIndex = 8;
            label8.Text = "Class B:";
            // 
            // calculate
            // 
            calculate.Location = new Point(126, 297);
            calculate.Name = "calculate";
            calculate.Size = new Size(98, 64);
            calculate.TabIndex = 2;
            calculate.Text = "Calculate Revenue";
            calculate.UseVisualStyleBackColor = true;
            calculate.Click += calculate_Click;
            // 
            // clear
            // 
            clear.Location = new Point(257, 297);
            clear.Name = "clear";
            clear.Size = new Size(98, 64);
            clear.TabIndex = 3;
            clear.Text = "Clear";
            clear.UseVisualStyleBackColor = true;
            clear.Click += clear_Click;
            // 
            // exit
            // 
            exit.Location = new Point(388, 297);
            exit.Name = "exit";
            exit.Size = new Size(98, 64);
            exit.TabIndex = 4;
            exit.Text = "Exit";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 5;
            label3.Text = "label3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 388);
            Controls.Add(label3);
            Controls.Add(exit);
            Controls.Add(clear);
            Controls.Add(calculate);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Stadium Seating";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button calculate;
        private Button clear;
        private Button exit;
        private Label label1;
        private Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox inputC;
        private TextBox inputA;
        private TextBox inputB;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox total;
        private Label label10;
        private TextBox revC;
        private TextBox revA;
        private TextBox revB;
        private Label label9;
        private Label label7;
        private Label label8;
        private Label label3;
    }
}