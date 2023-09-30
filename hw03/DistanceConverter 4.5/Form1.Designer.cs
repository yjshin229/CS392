namespace DistanceConverter
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
            fromList = new ListBox();
            groupBox2 = new GroupBox();
            toList = new ListBox();
            label1 = new Label();
            label2 = new Label();
            inputDis = new TextBox();
            result = new TextBox();
            button1 = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(fromList);
            groupBox1.Location = new Point(53, 93);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 136);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "From";
            // 
            // fromList
            // 
            fromList.FormattingEnabled = true;
            fromList.ItemHeight = 15;
            fromList.Items.AddRange(new object[] { "Inches", "Feet", "Yards" });
            fromList.Location = new Point(23, 22);
            fromList.Name = "fromList";
            fromList.Size = new Size(148, 94);
            fromList.TabIndex = 8;
            fromList.SelectedIndexChanged += fromList_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(toList);
            groupBox2.Location = new Point(284, 93);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 136);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "To";
            // 
            // toList
            // 
            toList.FormattingEnabled = true;
            toList.ItemHeight = 15;
            toList.Items.AddRange(new object[] { "Inches", "Feet", "Yards" });
            toList.Location = new Point(30, 22);
            toList.Name = "toList";
            toList.Size = new Size(148, 94);
            toList.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(113, 41);
            label1.Name = "label1";
            label1.Size = new Size(154, 15);
            label1.TabIndex = 2;
            label1.Text = "Enter a distance to convert:\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(154, 258);
            label2.Name = "label2";
            label2.Size = new Size(113, 15);
            label2.TabIndex = 3;
            label2.Text = "Distance converted:";
            // 
            // inputDis
            // 
            inputDis.Location = new Point(273, 38);
            inputDis.Name = "inputDis";
            inputDis.Size = new Size(100, 23);
            inputDis.TabIndex = 4;
            // 
            // result
            // 
            result.Location = new Point(273, 255);
            result.Name = "result";
            result.ReadOnly = true;
            result.Size = new Size(100, 23);
            result.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(192, 299);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Convert";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(273, 299);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 7;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 358);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(result);
            Controls.Add(inputDis);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ListBox fromList;
        private GroupBox groupBox2;
        private ListBox toList;
        private Label label1;
        private Label label2;
        private TextBox inputDis;
        private TextBox result;
        private Button button1;
        private Button button2;
    }
}