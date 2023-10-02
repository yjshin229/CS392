namespace _6._4JoesAutomative
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
            gbOilLube = new GroupBox();
            cbLubeJob = new CheckBox();
            cbOilChange = new CheckBox();
            gbFlushes = new GroupBox();
            cbTransFlush = new CheckBox();
            cbRadFlush = new CheckBox();
            gbPartsAndLabor = new GroupBox();
            tbLabor = new TextBox();
            tbParts = new TextBox();
            lblLabor = new Label();
            lblParts = new Label();
            gbMisc = new GroupBox();
            cbTireRot = new CheckBox();
            cbRepMuff = new CheckBox();
            cbInspection = new CheckBox();
            gbSummary = new GroupBox();
            tbTotal = new TextBox();
            tbTax = new TextBox();
            tbPartsSum = new TextBox();
            tbServSum = new TextBox();
            lblTotal = new Label();
            lblTax = new Label();
            lblPartsSum = new Label();
            lblServ = new Label();
            btnCalc = new Button();
            btnClear = new Button();
            btnExit = new Button();
            gbOilLube.SuspendLayout();
            gbFlushes.SuspendLayout();
            gbPartsAndLabor.SuspendLayout();
            gbMisc.SuspendLayout();
            gbSummary.SuspendLayout();
            SuspendLayout();
            // 
            // gbOilLube
            // 
            gbOilLube.Controls.Add(cbLubeJob);
            gbOilLube.Controls.Add(cbOilChange);
            gbOilLube.Location = new Point(60, 40);
            gbOilLube.Name = "gbOilLube";
            gbOilLube.Size = new Size(400, 200);
            gbOilLube.TabIndex = 0;
            gbOilLube.TabStop = false;
            gbOilLube.Text = "Oil and Lube";
            // 
            // cbLubeJob
            // 
            cbLubeJob.AutoSize = true;
            cbLubeJob.Location = new Point(42, 117);
            cbLubeJob.Name = "cbLubeJob";
            cbLubeJob.Size = new Size(202, 36);
            cbLubeJob.TabIndex = 1;
            cbLubeJob.Text = "Lube Job ($40)";
            cbLubeJob.UseVisualStyleBackColor = true;
            // 
            // cbOilChange
            // 
            cbOilChange.AutoSize = true;
            cbOilChange.Location = new Point(42, 55);
            cbOilChange.Name = "cbOilChange";
            cbOilChange.Size = new Size(225, 36);
            cbOilChange.TabIndex = 0;
            cbOilChange.Text = "Oil Change ($50)";
            cbOilChange.UseVisualStyleBackColor = true;
            // 
            // gbFlushes
            // 
            gbFlushes.Controls.Add(cbTransFlush);
            gbFlushes.Controls.Add(cbRadFlush);
            gbFlushes.Location = new Point(545, 40);
            gbFlushes.Name = "gbFlushes";
            gbFlushes.Size = new Size(407, 200);
            gbFlushes.TabIndex = 1;
            gbFlushes.TabStop = false;
            gbFlushes.Text = "Flushes";
            // 
            // cbTransFlush
            // 
            cbTransFlush.AutoSize = true;
            cbTransFlush.Location = new Point(40, 117);
            cbTransFlush.Name = "cbTransFlush";
            cbTransFlush.Size = new Size(318, 36);
            cbTransFlush.TabIndex = 3;
            cbTransFlush.Text = "Transmission Flush ($120)";
            cbTransFlush.UseVisualStyleBackColor = true;
            // 
            // cbRadFlush
            // 
            cbRadFlush.AutoSize = true;
            cbRadFlush.Location = new Point(40, 55);
            cbRadFlush.Name = "cbRadFlush";
            cbRadFlush.Size = new Size(270, 36);
            cbRadFlush.TabIndex = 2;
            cbRadFlush.Text = "Radiator Flush ($100)";
            cbRadFlush.UseVisualStyleBackColor = true;
            // 
            // gbPartsAndLabor
            // 
            gbPartsAndLabor.Controls.Add(tbLabor);
            gbPartsAndLabor.Controls.Add(tbParts);
            gbPartsAndLabor.Controls.Add(lblLabor);
            gbPartsAndLabor.Controls.Add(lblParts);
            gbPartsAndLabor.Location = new Point(545, 301);
            gbPartsAndLabor.Name = "gbPartsAndLabor";
            gbPartsAndLabor.Size = new Size(407, 245);
            gbPartsAndLabor.TabIndex = 3;
            gbPartsAndLabor.TabStop = false;
            gbPartsAndLabor.Text = "Parts and Labor";
            // 
            // tbLabor
            // 
            tbLabor.Location = new Point(194, 127);
            tbLabor.Name = "tbLabor";
            tbLabor.Size = new Size(200, 39);
            tbLabor.TabIndex = 3;
            // 
            // tbParts
            // 
            tbParts.Location = new Point(194, 68);
            tbParts.Name = "tbParts";
            tbParts.Size = new Size(200, 39);
            tbParts.TabIndex = 2;
            // 
            // lblLabor
            // 
            lblLabor.AutoSize = true;
            lblLabor.Location = new Point(26, 127);
            lblLabor.Name = "lblLabor";
            lblLabor.Size = new Size(162, 32);
            lblLabor.TabIndex = 1;
            lblLabor.Text = "Labor (Hours):";
            // 
            // lblParts
            // 
            lblParts.AutoSize = true;
            lblParts.Location = new Point(119, 75);
            lblParts.Name = "lblParts";
            lblParts.Size = new Size(69, 32);
            lblParts.TabIndex = 0;
            lblParts.Text = "Parts:";
            // 
            // gbMisc
            // 
            gbMisc.Controls.Add(cbTireRot);
            gbMisc.Controls.Add(cbRepMuff);
            gbMisc.Controls.Add(cbInspection);
            gbMisc.Location = new Point(60, 301);
            gbMisc.Name = "gbMisc";
            gbMisc.Size = new Size(400, 245);
            gbMisc.TabIndex = 2;
            gbMisc.TabStop = false;
            gbMisc.Text = "Misc";
            // 
            // cbTireRot
            // 
            cbTireRot.AutoSize = true;
            cbTireRot.Location = new Point(42, 171);
            cbTireRot.Name = "cbTireRot";
            cbTireRot.Size = new Size(242, 36);
            cbTireRot.TabIndex = 4;
            cbTireRot.Text = "Tire Rotation ($25)";
            cbTireRot.UseVisualStyleBackColor = true;
            // 
            // cbRepMuff
            // 
            cbRepMuff.AutoSize = true;
            cbRepMuff.Location = new Point(42, 110);
            cbRepMuff.Name = "cbRepMuff";
            cbRepMuff.Size = new Size(287, 36);
            cbRepMuff.TabIndex = 3;
            cbRepMuff.Text = "Replace Muffler ($150)";
            cbRepMuff.UseVisualStyleBackColor = true;
            // 
            // cbInspection
            // 
            cbInspection.AutoSize = true;
            cbInspection.Location = new Point(42, 48);
            cbInspection.Name = "cbInspection";
            cbInspection.Size = new Size(216, 36);
            cbInspection.TabIndex = 2;
            cbInspection.Text = "Inspection ($35)";
            cbInspection.UseVisualStyleBackColor = true;
            // 
            // gbSummary
            // 
            gbSummary.Controls.Add(tbTotal);
            gbSummary.Controls.Add(tbTax);
            gbSummary.Controls.Add(tbPartsSum);
            gbSummary.Controls.Add(tbServSum);
            gbSummary.Controls.Add(lblTotal);
            gbSummary.Controls.Add(lblTax);
            gbSummary.Controls.Add(lblPartsSum);
            gbSummary.Controls.Add(lblServ);
            gbSummary.Location = new Point(60, 567);
            gbSummary.Name = "gbSummary";
            gbSummary.Size = new Size(892, 297);
            gbSummary.TabIndex = 4;
            gbSummary.TabStop = false;
            gbSummary.Text = "Summary";
            // 
            // tbTotal
            // 
            tbTotal.Location = new Point(415, 229);
            tbTotal.Name = "tbTotal";
            tbTotal.Size = new Size(200, 39);
            tbTotal.TabIndex = 9;
            // 
            // tbTax
            // 
            tbTax.Location = new Point(415, 170);
            tbTax.Name = "tbTax";
            tbTax.Size = new Size(200, 39);
            tbTax.TabIndex = 8;
            // 
            // tbPartsSum
            // 
            tbPartsSum.Location = new Point(415, 111);
            tbPartsSum.Name = "tbPartsSum";
            tbPartsSum.Size = new Size(200, 39);
            tbPartsSum.TabIndex = 7;
            // 
            // tbServSum
            // 
            tbServSum.Location = new Point(415, 52);
            tbServSum.Name = "tbServSum";
            tbServSum.Size = new Size(200, 39);
            tbServSum.TabIndex = 6;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(267, 229);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(125, 32);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "Total Fees:";
            // 
            // lblTax
            // 
            lblTax.AutoSize = true;
            lblTax.Location = new Point(242, 170);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(160, 32);
            lblTax.TabIndex = 4;
            lblTax.Text = "Tax (on parts):";
            // 
            // lblPartsSum
            // 
            lblPartsSum.AutoSize = true;
            lblPartsSum.Location = new Point(331, 111);
            lblPartsSum.Name = "lblPartsSum";
            lblPartsSum.Size = new Size(69, 32);
            lblPartsSum.TabIndex = 3;
            lblPartsSum.Text = "Parts:";
            // 
            // lblServ
            // 
            lblServ.AutoSize = true;
            lblServ.Location = new Point(197, 52);
            lblServ.Name = "lblServ";
            lblServ.Size = new Size(208, 32);
            lblServ.TabIndex = 2;
            lblServ.Text = "Service and Labor:";
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(199, 962);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(150, 46);
            btnCalc.TabIndex = 5;
            btnCalc.Text = "Calculate";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(402, 962);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(150, 46);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(594, 962);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(150, 46);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1003, 1140);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCalc);
            Controls.Add(gbSummary);
            Controls.Add(gbPartsAndLabor);
            Controls.Add(gbMisc);
            Controls.Add(gbFlushes);
            Controls.Add(gbOilLube);
            Name = "Form1";
            Text = "Joe's Automative";
            Load += Form1_Load;
            gbOilLube.ResumeLayout(false);
            gbOilLube.PerformLayout();
            gbFlushes.ResumeLayout(false);
            gbFlushes.PerformLayout();
            gbPartsAndLabor.ResumeLayout(false);
            gbPartsAndLabor.PerformLayout();
            gbMisc.ResumeLayout(false);
            gbMisc.PerformLayout();
            gbSummary.ResumeLayout(false);
            gbSummary.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbOilLube;
        private CheckBox cbLubeJob;
        private CheckBox cbOilChange;
        private GroupBox gbFlushes;
        private CheckBox cbTransFlush;
        private CheckBox cbRadFlush;
        private GroupBox gbPartsAndLabor;
        private GroupBox gbMisc;
        private CheckBox cbRepMuff;
        private CheckBox cbInspection;
        private GroupBox gbSummary;
        private TextBox tbLabor;
        private TextBox tbParts;
        private Label lblLabor;
        private Label lblParts;
        private CheckBox cbTireRot;
        private TextBox tbTotal;
        private TextBox tbTax;
        private TextBox tbPartsSum;
        private TextBox tbServSum;
        private Label lblTotal;
        private Label lblTax;
        private Label lblPartsSum;
        private Label lblServ;
        private Button btnCalc;
        private Button btnClear;
        private Button btnExit;
    }
}