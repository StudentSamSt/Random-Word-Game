namespace Word_Game
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Word = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Letter1 = new System.Windows.Forms.Label();
            this.Letter2 = new System.Windows.Forms.Label();
            this.Letter3 = new System.Windows.Forms.Label();
            this.Letter4 = new System.Windows.Forms.Label();
            this.state = new System.Windows.Forms.PictureBox();
            this.buttonA = new System.Windows.Forms.Button();
            this.buttonB = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonD = new System.Windows.Forms.Button();
            this.buttonE = new System.Windows.Forms.Button();
            this.buttonF = new System.Windows.Forms.Button();
            this.buttonG = new System.Windows.Forms.Button();
            this.buttonH = new System.Windows.Forms.Button();
            this.buttonI = new System.Windows.Forms.Button();
            this.buttonJ = new System.Windows.Forms.Button();
            this.buttonK = new System.Windows.Forms.Button();
            this.buttonL = new System.Windows.Forms.Button();
            this.buttonM = new System.Windows.Forms.Button();
            this.buttonN = new System.Windows.Forms.Button();
            this.buttonO = new System.Windows.Forms.Button();
            this.buttonQ = new System.Windows.Forms.Button();
            this.buttonP = new System.Windows.Forms.Button();
            this.buttonR = new System.Windows.Forms.Button();
            this.buttonS = new System.Windows.Forms.Button();
            this.buttonT = new System.Windows.Forms.Button();
            this.buttonU = new System.Windows.Forms.Button();
            this.buttonV = new System.Windows.Forms.Button();
            this.buttonW = new System.Windows.Forms.Button();
            this.buttonX = new System.Windows.Forms.Button();
            this.buttonY = new System.Windows.Forms.Button();
            this.buttonZ = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.state)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Location = new System.Drawing.Point(67, 273);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.DoubleClick += new System.EventHandler(this.button1_Click);
            // 
            // Word
            // 
            this.Word.BackColor = System.Drawing.Color.IndianRed;
            this.Word.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Word.Location = new System.Drawing.Point(67, 304);
            this.Word.Name = "Word";
            this.Word.Size = new System.Drawing.Size(154, 52);
            this.Word.TabIndex = 30;
            this.Word.Text = "Guess A Word";
            this.Word.UseVisualStyleBackColor = false;
            this.Word.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(142, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Not in word list!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            // 
            // Letter1
            // 
            this.Letter1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Letter1.BackColor = System.Drawing.Color.Transparent;
            this.Letter1.Font = new System.Drawing.Font("Papyrus", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Letter1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Letter1.Location = new System.Drawing.Point(374, 47);
            this.Letter1.Name = "Letter1";
            this.Letter1.Size = new System.Drawing.Size(56, 52);
            this.Letter1.TabIndex = 40;
            this.Letter1.Text = "-";
            // 
            // Letter2
            // 
            this.Letter2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Letter2.BackColor = System.Drawing.Color.Transparent;
            this.Letter2.Font = new System.Drawing.Font("Papyrus", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Letter2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Letter2.Location = new System.Drawing.Point(414, 47);
            this.Letter2.Name = "Letter2";
            this.Letter2.Size = new System.Drawing.Size(56, 52);
            this.Letter2.TabIndex = 41;
            this.Letter2.Text = "-";
            // 
            // Letter3
            // 
            this.Letter3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Letter3.BackColor = System.Drawing.Color.Transparent;
            this.Letter3.Font = new System.Drawing.Font("Papyrus", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Letter3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Letter3.Location = new System.Drawing.Point(451, 47);
            this.Letter3.Name = "Letter3";
            this.Letter3.Size = new System.Drawing.Size(56, 52);
            this.Letter3.TabIndex = 42;
            this.Letter3.Text = "-";
            // 
            // Letter4
            // 
            this.Letter4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Letter4.BackColor = System.Drawing.Color.Transparent;
            this.Letter4.Font = new System.Drawing.Font("Papyrus", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Letter4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Letter4.Location = new System.Drawing.Point(487, 47);
            this.Letter4.Name = "Letter4";
            this.Letter4.Size = new System.Drawing.Size(56, 52);
            this.Letter4.TabIndex = 43;
            this.Letter4.Text = "-";
            // 
            // state
            // 
            this.state.BackColor = System.Drawing.Color.Transparent;
            this.state.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.state.Location = new System.Drawing.Point(268, 12);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(456, 467);
            this.state.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.state.TabIndex = 44;
            this.state.TabStop = false;
            this.state.Visible = false;
            // 
            // buttonA
            // 
            this.buttonA.Location = new System.Drawing.Point(27, 65);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(34, 34);
            this.buttonA.TabIndex = 46;
            this.buttonA.Text = "A";
            this.buttonA.UseVisualStyleBackColor = true;
            this.buttonA.Click += new System.EventHandler(this.buttonA_Click);
            // 
            // buttonB
            // 
            this.buttonB.Location = new System.Drawing.Point(67, 65);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(34, 34);
            this.buttonB.TabIndex = 47;
            this.buttonB.Text = "B";
            this.buttonB.UseVisualStyleBackColor = true;
            this.buttonB.Click += new System.EventHandler(this.buttonB_Click);
            // 
            // buttonC
            // 
            this.buttonC.Location = new System.Drawing.Point(107, 65);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(34, 34);
            this.buttonC.TabIndex = 48;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // buttonD
            // 
            this.buttonD.Location = new System.Drawing.Point(147, 65);
            this.buttonD.Name = "buttonD";
            this.buttonD.Size = new System.Drawing.Size(34, 34);
            this.buttonD.TabIndex = 49;
            this.buttonD.Text = "D";
            this.buttonD.UseVisualStyleBackColor = true;
            this.buttonD.Click += new System.EventHandler(this.buttonD_Click);
            // 
            // buttonE
            // 
            this.buttonE.Location = new System.Drawing.Point(187, 65);
            this.buttonE.Name = "buttonE";
            this.buttonE.Size = new System.Drawing.Size(34, 34);
            this.buttonE.TabIndex = 50;
            this.buttonE.Text = "E";
            this.buttonE.UseVisualStyleBackColor = true;
            this.buttonE.Click += new System.EventHandler(this.buttonE_Click);
            // 
            // buttonF
            // 
            this.buttonF.Location = new System.Drawing.Point(27, 105);
            this.buttonF.Name = "buttonF";
            this.buttonF.Size = new System.Drawing.Size(34, 34);
            this.buttonF.TabIndex = 51;
            this.buttonF.Text = "F";
            this.buttonF.UseVisualStyleBackColor = true;
            this.buttonF.Click += new System.EventHandler(this.buttonF_Click);
            // 
            // buttonG
            // 
            this.buttonG.Location = new System.Drawing.Point(67, 105);
            this.buttonG.Name = "buttonG";
            this.buttonG.Size = new System.Drawing.Size(34, 34);
            this.buttonG.TabIndex = 52;
            this.buttonG.Text = "G";
            this.buttonG.UseVisualStyleBackColor = true;
            this.buttonG.Click += new System.EventHandler(this.buttonG_Click);
            // 
            // buttonH
            // 
            this.buttonH.Location = new System.Drawing.Point(107, 105);
            this.buttonH.Name = "buttonH";
            this.buttonH.Size = new System.Drawing.Size(34, 34);
            this.buttonH.TabIndex = 53;
            this.buttonH.Text = "H";
            this.buttonH.UseVisualStyleBackColor = true;
            this.buttonH.Click += new System.EventHandler(this.buttonH_Click);
            // 
            // buttonI
            // 
            this.buttonI.Location = new System.Drawing.Point(147, 105);
            this.buttonI.Name = "buttonI";
            this.buttonI.Size = new System.Drawing.Size(34, 34);
            this.buttonI.TabIndex = 54;
            this.buttonI.Text = "I";
            this.buttonI.UseVisualStyleBackColor = true;
            this.buttonI.Click += new System.EventHandler(this.buttonI_Click);
            // 
            // buttonJ
            // 
            this.buttonJ.Location = new System.Drawing.Point(187, 105);
            this.buttonJ.Name = "buttonJ";
            this.buttonJ.Size = new System.Drawing.Size(34, 34);
            this.buttonJ.TabIndex = 55;
            this.buttonJ.Text = "J";
            this.buttonJ.UseVisualStyleBackColor = true;
            this.buttonJ.Click += new System.EventHandler(this.buttonJ_Click);
            // 
            // buttonK
            // 
            this.buttonK.Location = new System.Drawing.Point(27, 145);
            this.buttonK.Name = "buttonK";
            this.buttonK.Size = new System.Drawing.Size(34, 34);
            this.buttonK.TabIndex = 56;
            this.buttonK.Text = "K";
            this.buttonK.UseVisualStyleBackColor = true;
            this.buttonK.Click += new System.EventHandler(this.buttonK_Click);
            // 
            // buttonL
            // 
            this.buttonL.Location = new System.Drawing.Point(67, 145);
            this.buttonL.Name = "buttonL";
            this.buttonL.Size = new System.Drawing.Size(34, 34);
            this.buttonL.TabIndex = 57;
            this.buttonL.Text = "L";
            this.buttonL.UseVisualStyleBackColor = true;
            this.buttonL.Click += new System.EventHandler(this.buttonL_Click);
            // 
            // buttonM
            // 
            this.buttonM.Location = new System.Drawing.Point(107, 145);
            this.buttonM.Name = "buttonM";
            this.buttonM.Size = new System.Drawing.Size(34, 34);
            this.buttonM.TabIndex = 58;
            this.buttonM.Text = "M";
            this.buttonM.UseVisualStyleBackColor = true;
            this.buttonM.Click += new System.EventHandler(this.buttonM_Click);
            // 
            // buttonN
            // 
            this.buttonN.Location = new System.Drawing.Point(147, 145);
            this.buttonN.Name = "buttonN";
            this.buttonN.Size = new System.Drawing.Size(34, 34);
            this.buttonN.TabIndex = 59;
            this.buttonN.Text = "N";
            this.buttonN.UseVisualStyleBackColor = true;
            this.buttonN.Click += new System.EventHandler(this.buttonN_Click);
            // 
            // buttonO
            // 
            this.buttonO.Location = new System.Drawing.Point(187, 145);
            this.buttonO.Name = "buttonO";
            this.buttonO.Size = new System.Drawing.Size(34, 34);
            this.buttonO.TabIndex = 60;
            this.buttonO.Text = "O";
            this.buttonO.UseVisualStyleBackColor = true;
            this.buttonO.Click += new System.EventHandler(this.buttonO_Click);
            // 
            // buttonQ
            // 
            this.buttonQ.Location = new System.Drawing.Point(67, 185);
            this.buttonQ.Name = "buttonQ";
            this.buttonQ.Size = new System.Drawing.Size(34, 34);
            this.buttonQ.TabIndex = 61;
            this.buttonQ.Text = "Q";
            this.buttonQ.UseVisualStyleBackColor = true;
            this.buttonQ.Click += new System.EventHandler(this.buttonQ_Click);
            // 
            // buttonP
            // 
            this.buttonP.Location = new System.Drawing.Point(27, 185);
            this.buttonP.Name = "buttonP";
            this.buttonP.Size = new System.Drawing.Size(34, 34);
            this.buttonP.TabIndex = 62;
            this.buttonP.Text = "P";
            this.buttonP.UseVisualStyleBackColor = true;
            this.buttonP.Click += new System.EventHandler(this.buttonP_Click);
            // 
            // buttonR
            // 
            this.buttonR.Location = new System.Drawing.Point(107, 185);
            this.buttonR.Name = "buttonR";
            this.buttonR.Size = new System.Drawing.Size(34, 34);
            this.buttonR.TabIndex = 63;
            this.buttonR.Text = "R";
            this.buttonR.UseVisualStyleBackColor = true;
            this.buttonR.Click += new System.EventHandler(this.buttonR_Click);
            // 
            // buttonS
            // 
            this.buttonS.Location = new System.Drawing.Point(147, 185);
            this.buttonS.Name = "buttonS";
            this.buttonS.Size = new System.Drawing.Size(34, 34);
            this.buttonS.TabIndex = 64;
            this.buttonS.Text = "S";
            this.buttonS.UseVisualStyleBackColor = true;
            this.buttonS.Click += new System.EventHandler(this.buttonS_Click);
            // 
            // buttonT
            // 
            this.buttonT.Location = new System.Drawing.Point(187, 185);
            this.buttonT.Name = "buttonT";
            this.buttonT.Size = new System.Drawing.Size(34, 34);
            this.buttonT.TabIndex = 65;
            this.buttonT.Text = "T";
            this.buttonT.UseVisualStyleBackColor = true;
            this.buttonT.Click += new System.EventHandler(this.buttonT_Click);
            // 
            // buttonU
            // 
            this.buttonU.Location = new System.Drawing.Point(27, 225);
            this.buttonU.Name = "buttonU";
            this.buttonU.Size = new System.Drawing.Size(34, 34);
            this.buttonU.TabIndex = 66;
            this.buttonU.Text = "U";
            this.buttonU.UseVisualStyleBackColor = true;
            this.buttonU.Click += new System.EventHandler(this.buttonU_Click);
            // 
            // buttonV
            // 
            this.buttonV.Location = new System.Drawing.Point(67, 225);
            this.buttonV.Name = "buttonV";
            this.buttonV.Size = new System.Drawing.Size(34, 34);
            this.buttonV.TabIndex = 67;
            this.buttonV.Text = "V";
            this.buttonV.UseVisualStyleBackColor = true;
            this.buttonV.Click += new System.EventHandler(this.buttonV_Click);
            // 
            // buttonW
            // 
            this.buttonW.Location = new System.Drawing.Point(107, 225);
            this.buttonW.Name = "buttonW";
            this.buttonW.Size = new System.Drawing.Size(34, 34);
            this.buttonW.TabIndex = 68;
            this.buttonW.Text = "W";
            this.buttonW.UseVisualStyleBackColor = true;
            this.buttonW.Click += new System.EventHandler(this.buttonW_Click);
            // 
            // buttonX
            // 
            this.buttonX.Location = new System.Drawing.Point(147, 225);
            this.buttonX.Name = "buttonX";
            this.buttonX.Size = new System.Drawing.Size(34, 34);
            this.buttonX.TabIndex = 69;
            this.buttonX.Text = "X";
            this.buttonX.UseVisualStyleBackColor = true;
            this.buttonX.Click += new System.EventHandler(this.buttonX_Click);
            // 
            // buttonY
            // 
            this.buttonY.Location = new System.Drawing.Point(187, 225);
            this.buttonY.Name = "buttonY";
            this.buttonY.Size = new System.Drawing.Size(34, 34);
            this.buttonY.TabIndex = 70;
            this.buttonY.Text = "Y";
            this.buttonY.UseVisualStyleBackColor = true;
            this.buttonY.Click += new System.EventHandler(this.buttonY_Click);
            // 
            // buttonZ
            // 
            this.buttonZ.Location = new System.Drawing.Point(27, 265);
            this.buttonZ.Name = "buttonZ";
            this.buttonZ.Size = new System.Drawing.Size(34, 34);
            this.buttonZ.TabIndex = 71;
            this.buttonZ.Text = "Z";
            this.buttonZ.UseVisualStyleBackColor = true;
            this.buttonZ.Click += new System.EventHandler(this.buttonZ_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 53);
            this.label2.TabIndex = 73;
            this.label2.Text = "Answer display";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Papyrus", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(354, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(370, 342);
            this.label3.TabIndex = 74;
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.Chocolate;
            this.reset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reset.Location = new System.Drawing.Point(67, 415);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(154, 40);
            this.reset.TabIndex = 75;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Visible = false;
            this.reset.Click += new System.EventHandler(this.reset_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::Word_Game.Resource1.chalk_board;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(736, 491);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.state);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonZ);
            this.Controls.Add(this.buttonY);
            this.Controls.Add(this.buttonX);
            this.Controls.Add(this.buttonW);
            this.Controls.Add(this.buttonV);
            this.Controls.Add(this.buttonU);
            this.Controls.Add(this.buttonT);
            this.Controls.Add(this.buttonS);
            this.Controls.Add(this.buttonR);
            this.Controls.Add(this.buttonP);
            this.Controls.Add(this.buttonQ);
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
            this.Controls.Add(this.Letter4);
            this.Controls.Add(this.Letter3);
            this.Controls.Add(this.Letter2);
            this.Controls.Add(this.Letter1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Word);
            this.Controls.Add(this.textBox1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.state)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Word;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Letter1;
        private System.Windows.Forms.Label Letter2;
        private System.Windows.Forms.Label Letter3;
        private System.Windows.Forms.Label Letter4;
        private System.Windows.Forms.PictureBox state;
        private System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.Button buttonB;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonD;
        private System.Windows.Forms.Button buttonE;
        private System.Windows.Forms.Button buttonF;
        private System.Windows.Forms.Button buttonG;
        private System.Windows.Forms.Button buttonH;
        private System.Windows.Forms.Button buttonI;
        private System.Windows.Forms.Button buttonJ;
        private System.Windows.Forms.Button buttonK;
        private System.Windows.Forms.Button buttonL;
        private System.Windows.Forms.Button buttonM;
        private System.Windows.Forms.Button buttonN;
        private System.Windows.Forms.Button buttonO;
        private System.Windows.Forms.Button buttonQ;
        private System.Windows.Forms.Button buttonP;
        private System.Windows.Forms.Button buttonR;
        private System.Windows.Forms.Button buttonS;
        private System.Windows.Forms.Button buttonT;
        private System.Windows.Forms.Button buttonU;
        private System.Windows.Forms.Button buttonV;
        private System.Windows.Forms.Button buttonW;
        private System.Windows.Forms.Button buttonX;
        private System.Windows.Forms.Button buttonY;
        private System.Windows.Forms.Button buttonZ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button reset;
    }
}

