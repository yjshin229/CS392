namespace Hangman
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.hangmanPicture = new System.Windows.Forms.PictureBox();
            this.underscoreText = new System.Windows.Forms.Label();
            this.buttonA = new System.Windows.Forms.Button();
            this.buttonB = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonD = new System.Windows.Forms.Button();
            this.buttonE = new System.Windows.Forms.Button();
            this.buttonF = new System.Windows.Forms.Button();
            this.buttonG = new System.Windows.Forms.Button();
            this.buttonN = new System.Windows.Forms.Button();
            this.buttonM = new System.Windows.Forms.Button();
            this.buttonL = new System.Windows.Forms.Button();
            this.buttonK = new System.Windows.Forms.Button();
            this.buttonJ = new System.Windows.Forms.Button();
            this.buttonI = new System.Windows.Forms.Button();
            this.buttonH = new System.Windows.Forms.Button();
            this.buttonU = new System.Windows.Forms.Button();
            this.buttonT = new System.Windows.Forms.Button();
            this.buttonS = new System.Windows.Forms.Button();
            this.buttonR = new System.Windows.Forms.Button();
            this.buttonQ = new System.Windows.Forms.Button();
            this.buttonP = new System.Windows.Forms.Button();
            this.buttonO = new System.Windows.Forms.Button();
            this.buttonZ = new System.Windows.Forms.Button();
            this.buttonY = new System.Windows.Forms.Button();
            this.buttonX = new System.Windows.Forms.Button();
            this.buttonW = new System.Windows.Forms.Button();
            this.buttonV = new System.Windows.Forms.Button();
            this.label_2 = new System.Windows.Forms.Label();
            this.hintText = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.lost = new System.Windows.Forms.Label();
            this.won = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hangmanPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // hangmanPicture
            // 
            this.hangmanPicture.Image = global::Hangman.Properties.Resources.hang0;
            this.hangmanPicture.Location = new System.Drawing.Point(29, 43);
            this.hangmanPicture.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.hangmanPicture.Name = "hangmanPicture";
            this.hangmanPicture.Size = new System.Drawing.Size(265, 234);
            this.hangmanPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hangmanPicture.TabIndex = 0;
            this.hangmanPicture.TabStop = false;
            // 
            // underscoreText
            // 
            this.underscoreText.AutoSize = true;
            this.underscoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.underscoreText.Location = new System.Drawing.Point(99, 306);
            this.underscoreText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.underscoreText.Name = "underscoreText";
            this.underscoreText.Size = new System.Drawing.Size(0, 31);
            this.underscoreText.TabIndex = 1;
            // 
            // buttonA
            // 
            this.buttonA.Location = new System.Drawing.Point(346, 44);
            this.buttonA.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(35, 35);
            this.buttonA.TabIndex = 2;
            this.buttonA.Text = "A";
            this.buttonA.UseVisualStyleBackColor = true;
            this.buttonA.Visible = false;
            this.buttonA.Click += new System.EventHandler(this.Alphabet);
            // 
            // buttonB
            // 
            this.buttonB.Location = new System.Drawing.Point(387, 44);
            this.buttonB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(35, 35);
            this.buttonB.TabIndex = 3;
            this.buttonB.Text = "B";
            this.buttonB.UseVisualStyleBackColor = true;
            this.buttonB.Visible = false;
            this.buttonB.Click += new System.EventHandler(this.Alphabet);
            // 
            // buttonC
            // 
            this.buttonC.Location = new System.Drawing.Point(428, 44);
            this.buttonC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(35, 35);
            this.buttonC.TabIndex = 4;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Visible = false;
            this.buttonC.Click += new System.EventHandler(this.Alphabet);
            // 
            // buttonD
            // 
            this.buttonD.Location = new System.Drawing.Point(470, 44);
            this.buttonD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonD.Name = "buttonD";
            this.buttonD.Size = new System.Drawing.Size(35, 35);
            this.buttonD.TabIndex = 5;
            this.buttonD.Text = "D";
            this.buttonD.UseVisualStyleBackColor = true;
            this.buttonD.Visible = false;
            this.buttonD.Click += new System.EventHandler(this.Alphabet);
            // 
            // buttonE
            // 
            this.buttonE.Location = new System.Drawing.Point(511, 44);
            this.buttonE.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonE.Name = "buttonE";
            this.buttonE.Size = new System.Drawing.Size(35, 35);
            this.buttonE.TabIndex = 6;
            this.buttonE.Text = "E";
            this.buttonE.UseVisualStyleBackColor = true;
            this.buttonE.Visible = false;
            this.buttonE.Click += new System.EventHandler(this.Alphabet);
            // 
            // buttonF
            // 
            this.buttonF.Location = new System.Drawing.Point(552, 44);
            this.buttonF.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonF.Name = "buttonF";
            this.buttonF.Size = new System.Drawing.Size(35, 35);
            this.buttonF.TabIndex = 7;
            this.buttonF.Text = "F";
            this.buttonF.UseVisualStyleBackColor = true;
            this.buttonF.Visible = false;
            this.buttonF.Click += new System.EventHandler(this.Alphabet);
            // 
            // buttonG
            // 
            this.buttonG.Location = new System.Drawing.Point(593, 44);
            this.buttonG.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonG.Name = "buttonG";
            this.buttonG.Size = new System.Drawing.Size(35, 35);
            this.buttonG.TabIndex = 8;
            this.buttonG.Text = "G";
            this.buttonG.UseVisualStyleBackColor = true;
            this.buttonG.Visible = false;
            this.buttonG.Click += new System.EventHandler(this.Alphabet);
            // 
            // buttonN
            // 
            this.buttonN.Location = new System.Drawing.Point(593, 85);
            this.buttonN.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonN.Name = "buttonN";
            this.buttonN.Size = new System.Drawing.Size(35, 35);
            this.buttonN.TabIndex = 15;
            this.buttonN.Text = "N";
            this.buttonN.UseVisualStyleBackColor = true;
            this.buttonN.Visible = false;
            this.buttonN.Click += new System.EventHandler(this.Alphabet);
            // 
            // buttonM
            // 
            this.buttonM.Location = new System.Drawing.Point(552, 85);
            this.buttonM.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonM.Name = "buttonM";
            this.buttonM.Size = new System.Drawing.Size(35, 35);
            this.buttonM.TabIndex = 14;
            this.buttonM.Text = "M";
            this.buttonM.UseVisualStyleBackColor = true;
            this.buttonM.Visible = false;
            this.buttonM.Click += new System.EventHandler(this.Alphabet);
            // 
            // buttonL
            // 
            this.buttonL.Location = new System.Drawing.Point(511, 85);
            this.buttonL.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonL.Name = "buttonL";
            this.buttonL.Size = new System.Drawing.Size(35, 35);
            this.buttonL.TabIndex = 13;
            this.buttonL.Text = "L";
            this.buttonL.UseVisualStyleBackColor = true;
            this.buttonL.Visible = false;
            this.buttonL.Click += new System.EventHandler(this.Alphabet);
            // 
            // buttonK
            // 
            this.buttonK.Location = new System.Drawing.Point(470, 85);
            this.buttonK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonK.Name = "buttonK";
            this.buttonK.Size = new System.Drawing.Size(35, 35);
            this.buttonK.TabIndex = 12;
            this.buttonK.Text = "K";
            this.buttonK.UseVisualStyleBackColor = true;
            this.buttonK.Visible = false;
            this.buttonK.Click += new System.EventHandler(this.Alphabet);
            // 
            // buttonJ
            // 
            this.buttonJ.Location = new System.Drawing.Point(428, 85);
            this.buttonJ.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonJ.Name = "buttonJ";
            this.buttonJ.Size = new System.Drawing.Size(35, 35);
            this.buttonJ.TabIndex = 11;
            this.buttonJ.Text = "J";
            this.buttonJ.UseVisualStyleBackColor = true;
            this.buttonJ.Visible = false;
            this.buttonJ.Click += new System.EventHandler(this.Alphabet);
            // 
            // buttonI
            // 
            this.buttonI.Location = new System.Drawing.Point(387, 85);
            this.buttonI.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonI.Name = "buttonI";
            this.buttonI.Size = new System.Drawing.Size(35, 35);
            this.buttonI.TabIndex = 10;
            this.buttonI.Text = "I";
            this.buttonI.UseVisualStyleBackColor = true;
            this.buttonI.Visible = false;
            this.buttonI.Click += new System.EventHandler(this.Alphabet);
            // 
            // buttonH
            // 
            this.buttonH.Location = new System.Drawing.Point(346, 85);
            this.buttonH.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonH.Name = "buttonH";
            this.buttonH.Size = new System.Drawing.Size(35, 35);
            this.buttonH.TabIndex = 9;
            this.buttonH.Text = "H";
            this.buttonH.UseVisualStyleBackColor = true;
            this.buttonH.Visible = false;
            this.buttonH.Click += new System.EventHandler(this.Alphabet);
            // 
            // buttonU
            // 
            this.buttonU.Location = new System.Drawing.Point(593, 126);
            this.buttonU.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonU.Name = "buttonU";
            this.buttonU.Size = new System.Drawing.Size(35, 35);
            this.buttonU.TabIndex = 22;
            this.buttonU.Text = "U";
            this.buttonU.UseVisualStyleBackColor = true;
            this.buttonU.Visible = false;
            this.buttonU.Click += new System.EventHandler(this.Alphabet);
            // 
            // buttonT
            // 
            this.buttonT.Location = new System.Drawing.Point(552, 126);
            this.buttonT.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonT.Name = "buttonT";
            this.buttonT.Size = new System.Drawing.Size(35, 35);
            this.buttonT.TabIndex = 21;
            this.buttonT.Text = "T";
            this.buttonT.UseVisualStyleBackColor = true;
            this.buttonT.Visible = false;
            this.buttonT.Click += new System.EventHandler(this.Alphabet);
            // 
            // buttonS
            // 
            this.buttonS.Location = new System.Drawing.Point(511, 126);
            this.buttonS.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonS.Name = "buttonS";
            this.buttonS.Size = new System.Drawing.Size(35, 35);
            this.buttonS.TabIndex = 20;
            this.buttonS.Text = "S";
            this.buttonS.UseVisualStyleBackColor = true;
            this.buttonS.Visible = false;
            this.buttonS.Click += new System.EventHandler(this.Alphabet);
            // 
            // buttonR
            // 
            this.buttonR.Location = new System.Drawing.Point(470, 126);
            this.buttonR.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonR.Name = "buttonR";
            this.buttonR.Size = new System.Drawing.Size(35, 35);
            this.buttonR.TabIndex = 19;
            this.buttonR.Text = "R";
            this.buttonR.UseVisualStyleBackColor = true;
            this.buttonR.Visible = false;
            this.buttonR.Click += new System.EventHandler(this.Alphabet);
            // 
            // buttonQ
            // 
            this.buttonQ.Location = new System.Drawing.Point(428, 126);
            this.buttonQ.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonQ.Name = "buttonQ";
            this.buttonQ.Size = new System.Drawing.Size(35, 35);
            this.buttonQ.TabIndex = 18;
            this.buttonQ.Text = "Q";
            this.buttonQ.UseVisualStyleBackColor = true;
            this.buttonQ.Visible = false;
            this.buttonQ.Click += new System.EventHandler(this.Alphabet);
            // 
            // buttonP
            // 
            this.buttonP.Location = new System.Drawing.Point(387, 126);
            this.buttonP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonP.Name = "buttonP";
            this.buttonP.Size = new System.Drawing.Size(35, 35);
            this.buttonP.TabIndex = 17;
            this.buttonP.Text = "P";
            this.buttonP.UseVisualStyleBackColor = true;
            this.buttonP.Visible = false;
            this.buttonP.Click += new System.EventHandler(this.Alphabet);
            // 
            // buttonO
            // 
            this.buttonO.Location = new System.Drawing.Point(346, 126);
            this.buttonO.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonO.Name = "buttonO";
            this.buttonO.Size = new System.Drawing.Size(35, 35);
            this.buttonO.TabIndex = 16;
            this.buttonO.Text = "O";
            this.buttonO.UseVisualStyleBackColor = true;
            this.buttonO.Visible = false;
            this.buttonO.Click += new System.EventHandler(this.Alphabet);
            // 
            // buttonZ
            // 
            this.buttonZ.Location = new System.Drawing.Point(511, 167);
            this.buttonZ.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonZ.Name = "buttonZ";
            this.buttonZ.Size = new System.Drawing.Size(35, 35);
            this.buttonZ.TabIndex = 27;
            this.buttonZ.Text = "Z";
            this.buttonZ.UseVisualStyleBackColor = true;
            this.buttonZ.Visible = false;
            this.buttonZ.Click += new System.EventHandler(this.Alphabet);
            // 
            // buttonY
            // 
            this.buttonY.Location = new System.Drawing.Point(470, 167);
            this.buttonY.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonY.Name = "buttonY";
            this.buttonY.Size = new System.Drawing.Size(35, 35);
            this.buttonY.TabIndex = 26;
            this.buttonY.Text = "Y";
            this.buttonY.UseVisualStyleBackColor = true;
            this.buttonY.Visible = false;
            this.buttonY.Click += new System.EventHandler(this.Alphabet);
            // 
            // buttonX
            // 
            this.buttonX.Location = new System.Drawing.Point(428, 167);
            this.buttonX.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonX.Name = "buttonX";
            this.buttonX.Size = new System.Drawing.Size(35, 35);
            this.buttonX.TabIndex = 25;
            this.buttonX.Text = "X";
            this.buttonX.UseVisualStyleBackColor = true;
            this.buttonX.Visible = false;
            this.buttonX.Click += new System.EventHandler(this.Alphabet);
            // 
            // buttonW
            // 
            this.buttonW.Location = new System.Drawing.Point(387, 167);
            this.buttonW.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonW.Name = "buttonW";
            this.buttonW.Size = new System.Drawing.Size(35, 35);
            this.buttonW.TabIndex = 24;
            this.buttonW.Text = "W";
            this.buttonW.UseVisualStyleBackColor = true;
            this.buttonW.Visible = false;
            this.buttonW.Click += new System.EventHandler(this.Alphabet);
            // 
            // buttonV
            // 
            this.buttonV.Location = new System.Drawing.Point(346, 167);
            this.buttonV.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonV.Name = "buttonV";
            this.buttonV.Size = new System.Drawing.Size(35, 35);
            this.buttonV.TabIndex = 23;
            this.buttonV.Text = "V";
            this.buttonV.UseVisualStyleBackColor = true;
            this.buttonV.Visible = false;
            this.buttonV.Click += new System.EventHandler(this.Alphabet);
            // 
            // label_2
            // 
            this.label_2.AutoSize = true;
            this.label_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_2.Location = new System.Drawing.Point(356, 257);
            this.label_2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_2.Name = "label_2";
            this.label_2.Size = new System.Drawing.Size(76, 31);
            this.label_2.TabIndex = 28;
            this.label_2.Text = "Hint:";
            // 
            // hintText
            // 
            this.hintText.AutoSize = true;
            this.hintText.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hintText.Location = new System.Drawing.Point(451, 249);
            this.hintText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hintText.Name = "hintText";
            this.hintText.Size = new System.Drawing.Size(0, 47);
            this.hintText.TabIndex = 29;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(569, 314);
            this.startButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(88, 21);
            this.startButton.TabIndex = 30;
            this.startButton.Text = "Start Game";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // lost
            // 
            this.lost.AutoSize = true;
            this.lost.Font = new System.Drawing.Font("Bradley Hand ITC", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lost.ForeColor = System.Drawing.Color.Red;
            this.lost.Location = new System.Drawing.Point(225, 123);
            this.lost.Name = "lost";
            this.lost.Size = new System.Drawing.Size(226, 60);
            this.lost.TabIndex = 31;
            this.lost.Text = "You Lost!";
            this.lost.Visible = false;
            // 
            // won
            // 
            this.won.AutoSize = true;
            this.won.Font = new System.Drawing.Font("Bradley Hand ITC", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.won.ForeColor = System.Drawing.Color.LimeGreen;
            this.won.Location = new System.Drawing.Point(225, 123);
            this.won.Name = "won";
            this.won.Size = new System.Drawing.Size(234, 60);
            this.won.TabIndex = 32;
            this.won.Text = "You Won!";
            this.won.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 397);
            this.Controls.Add(this.won);
            this.Controls.Add(this.lost);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.hintText);
            this.Controls.Add(this.label_2);
            this.Controls.Add(this.buttonZ);
            this.Controls.Add(this.buttonY);
            this.Controls.Add(this.buttonX);
            this.Controls.Add(this.buttonW);
            this.Controls.Add(this.buttonV);
            this.Controls.Add(this.buttonU);
            this.Controls.Add(this.buttonT);
            this.Controls.Add(this.buttonS);
            this.Controls.Add(this.buttonR);
            this.Controls.Add(this.buttonQ);
            this.Controls.Add(this.buttonP);
            this.Controls.Add(this.buttonO);
            this.Controls.Add(this.buttonN);
            this.Controls.Add(this.buttonM);
            this.Controls.Add(this.buttonL);
            this.Controls.Add(this.buttonK);
            this.Controls.Add(this.buttonJ);
            this.Controls.Add(this.buttonI);
            this.Controls.Add(this.buttonH);
            this.Controls.Add(this.buttonG);
            this.Controls.Add(this.buttonF);
            this.Controls.Add(this.buttonE);
            this.Controls.Add(this.buttonD);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonB);
            this.Controls.Add(this.buttonA);
            this.Controls.Add(this.underscoreText);
            this.Controls.Add(this.hangmanPicture);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Hangman";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hangmanPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox hangmanPicture;
        private System.Windows.Forms.Label underscoreText;
        private System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.Button buttonB;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonD;
        private System.Windows.Forms.Button buttonE;
        private System.Windows.Forms.Button buttonF;
        private System.Windows.Forms.Button buttonG;
        private System.Windows.Forms.Button buttonN;
        private System.Windows.Forms.Button buttonM;
        private System.Windows.Forms.Button buttonL;
        private System.Windows.Forms.Button buttonK;
        private System.Windows.Forms.Button buttonJ;
        private System.Windows.Forms.Button buttonI;
        private System.Windows.Forms.Button buttonH;
        private System.Windows.Forms.Button buttonU;
        private System.Windows.Forms.Button buttonT;
        private System.Windows.Forms.Button buttonS;
        private System.Windows.Forms.Button buttonR;
        private System.Windows.Forms.Button buttonQ;
        private System.Windows.Forms.Button buttonP;
        private System.Windows.Forms.Button buttonO;
        private System.Windows.Forms.Button buttonZ;
        private System.Windows.Forms.Button buttonY;
        private System.Windows.Forms.Button buttonX;
        private System.Windows.Forms.Button buttonW;
        private System.Windows.Forms.Button buttonV;
        private System.Windows.Forms.Label label_2;
        private System.Windows.Forms.Label hintText;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label lost;
        private System.Windows.Forms.Label won;
    }
}

