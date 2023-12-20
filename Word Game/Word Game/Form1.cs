using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace Word_Game
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        char[] AnsCharacters;
        char[] GueCharacters;
        string guess = null;
        int wrongtimes = 0;

        List<string> wordList = new List<string>();
        public Form1()
        {
            InitializeComponent();

            StreamReader file = new StreamReader("../../resources/ukenglish.txt");
            {
                string In;
                while ((In = file.ReadLine()) != null)
                {
                    if (In.Length > 3 && In.Length < 5)
                    { wordList.Add(In); }
                }
            }
            file.Close();
            int chosen = rnd.Next(1, wordList.Count);
            string answer = wordList[chosen];
            AnsCharacters = answer.ToCharArray();
        }

        //checking for chars in the string inputted
        private void Check(char[] AnsCharacters, char[] GueCharacters, ref int wrongtimes)
        {

            for (int i = 0; i < GueCharacters.Length; i++)
            {
                char letter = GueCharacters[i];
                if (AnsCharacters.Contains(letter))
                { Correct(letter, AnsCharacters); }
                else
                {
                    wrongtimes++;
                    Incorrect(letter, AnsCharacters, wrongtimes); 
                }
            }
            string answer = new string(AnsCharacters);
            if (Letter1.Text != "-" && Letter2.Text != "-" && Letter3.Text != "-" && Letter4.Text != "-")
            {
                state.Image = Properties.Resources.win; state.Visible = true;
                label2.BackColor = Color.Green;
                label2.Visible = true; label2.Text = "The answer was: \n\n" + answer;
                reset.Visible = true;
            }
            if ( wrongtimes == 11)
            { 
                state.Image = Properties.Resources.lose; state.Visible = true;
                label2.BackColor = Color.Red;
                label2.Visible = true; label2.Text = "The answer was: \n\n" + answer;
                reset.Visible = true;
            }
            Hangman_character(wrongtimes);
        }
        //checkers
        private void Correct(char letter, char[] AnsCharacters) 
        {
            if (letter == AnsCharacters[0] || letter == AnsCharacters[1] || letter == AnsCharacters[2] || letter == AnsCharacters[3])
            {
                string L = letter.ToString();
                L = L.ToUpper();
                if (L == "A") { buttonA.BackColor = Color.Green; }
                else if (L == "B") { buttonB.BackColor = Color.Green; }
                else if (L == "C") { buttonC.BackColor = Color.Green; }
                else if (L == "D") { buttonD.BackColor = Color.Green; }
                else if (L == "E") { buttonE.BackColor = Color.Green; }
                else if (L == "F") { buttonF.BackColor = Color.Green; }
                else if (L == "G") { buttonG.BackColor = Color.Green; }
                else if (L == "H") { buttonH.BackColor = Color.Green; }
                else if (L == "I") { buttonI.BackColor = Color.Green; }
                else if (L == "J") { buttonJ.BackColor = Color.Green; }
                else if (L == "K") { buttonK.BackColor = Color.Green; }
                else if (L == "L") { buttonL.BackColor = Color.Green; }
                else if (L == "M") { buttonM.BackColor = Color.Green; }
                else if (L == "N") { buttonN.BackColor = Color.Green; }
                else if (L == "O") { buttonO.BackColor = Color.Green; }
                else if (L == "P") { buttonP.BackColor = Color.Green; }
                else if (L == "Q") { buttonQ.BackColor = Color.Green; }
                else if (L == "R") { buttonR.BackColor = Color.Green; }
                else if (L == "S") { buttonS.BackColor = Color.Green; }
                else if (L == "T") { buttonT.BackColor = Color.Green; }
                else if (L == "U") { buttonU.BackColor = Color.Green; }
                else if (L == "V") { buttonV.BackColor = Color.Green; }
                else if (L == "W") { buttonW.BackColor = Color.Green; }
                else if (L == "X") { buttonX.BackColor = Color.Green; }
                else if (L == "Y") { buttonY.BackColor = Color.Green; }
                else if (L == "Z") { buttonZ.BackColor = Color.Green; }
                Reveal(letter, AnsCharacters);
            }
        }
        private void Incorrect(char letter, char[] AnsCharacters, int wrongtimes) 
        {
            if (letter != AnsCharacters[0] && letter != AnsCharacters[1] && letter != AnsCharacters[2] && letter != AnsCharacters[3])
            {
                string L = letter.ToString();
                L = L.ToUpper();
                if (L == "A") { buttonA.BackColor = Color.Red; }
                else if (L == "B") { buttonB.BackColor = Color.Red; }
                else if (L == "C") { buttonC.BackColor = Color.Red; }
                else if (L == "D") { buttonD.BackColor = Color.Red; }
                else if (L == "E") { buttonE.BackColor = Color.Red; }
                else if (L == "F") { buttonF.BackColor = Color.Red; }
                else if (L == "G") { buttonG.BackColor = Color.Red; }
                else if (L == "H") { buttonH.BackColor = Color.Red; }
                else if (L == "I") { buttonI.BackColor = Color.Red; }
                else if (L == "J") { buttonJ.BackColor = Color.Red; }
                else if (L == "K") { buttonK.BackColor = Color.Red; }
                else if (L == "L") { buttonL.BackColor = Color.Red; }
                else if (L == "M") { buttonM.BackColor = Color.Red; }
                else if (L == "N") { buttonN.BackColor = Color.Red; }
                else if (L == "O") { buttonO.BackColor = Color.Red; }
                else if (L == "P") { buttonP.BackColor = Color.Red; }
                else if (L == "Q") { buttonQ.BackColor = Color.Red; }
                else if (L == "R") { buttonR.BackColor = Color.Red; }
                else if (L == "S") { buttonS.BackColor = Color.Red; }
                else if (L == "T") { buttonT.BackColor = Color.Red; }
                else if (L == "U") { buttonU.BackColor = Color.Red; }
                else if (L == "V") { buttonV.BackColor = Color.Red; }
                else if (L == "W") { buttonW.BackColor = Color.Red; }
                else if (L == "X") { buttonX.BackColor = Color.Red; }
                else if (L == "Y") { buttonY.BackColor = Color.Red; }
                else if (L == "Z") { buttonZ.BackColor = Color.Red; }
            }
        }

        //conditions and letter reveals
        private void Reveal(char letter, char[] AnsCharacters)
        {
            if (letter == AnsCharacters[0]) { Letter1.Text = letter.ToString(); }
            if (letter == AnsCharacters[1]) { Letter2.Text = letter.ToString(); }
            if (letter == AnsCharacters[2]) { Letter3.Text = letter.ToString(); }
            if (letter == AnsCharacters[3]) { Letter4.Text = letter.ToString(); }
        }
        private void Hangman_character(int wrongtimes) 
        {
            string[] stages = {
                                "     \n     \n     \n     \n_____", //1
                                "|    \n|    \n|    \n|    \n|____", //2
                                "|-----\n|    \n|    \n|    \n|____", //3
                                "|----|-\n|    \n|    \n|    \n|____", //4
                                "|----|-\n|/   \n|    \n|    \n|____", //5
                                "|----|-\n|/  O \n|    \n|    \n|____", //6
                                "|----|-\n|/  O \n|      | \n|    \n|____", //7
                                "|----|-\n|/  O \n|      |--\n|    \n|____", //8
                                "|----|-\n|/  O \n|   --|--\n|    \n|____", //9
                                "|----|-\n|/  O \n|   --|--\n|     /  \n|____", //10
                                "|----|-\n|/  O \n|   --|--\n|     / |\n|____", //11
            };

            if (wrongtimes == 1) { label3.Text = stages[0]; }
            else if (wrongtimes == 2) { label3.Text = stages[1]; }
            else if (wrongtimes == 3) { label3.Text = stages[2]; }
            else if (wrongtimes == 4) { label3.Text = stages[3]; }
            else if (wrongtimes == 5) { label3.Text = stages[4]; }
            else if (wrongtimes == 6) { label3.Text = stages[5]; }
            else if (wrongtimes == 7) { label3.Text = stages[6]; }
            else if (wrongtimes == 8) { label3.Text = stages[7]; }
            else if (wrongtimes == 9) { label3.Text = stages[8]; }
            else if (wrongtimes == 10) { label3.Text = stages[9]; }
            else if (wrongtimes == 11) { label3.Text = stages[10]; }
        }

        //reset
        private void reset_Click_1(object sender, EventArgs e)
        {
            Application.Restart();
        }

        //word guess
        private void button1_Click(object sender, EventArgs e)
        {
            guess = textBox1.Text;
            guess = guess.ToLower();
            textBox1.Text = null;
            if (wordList.Contains(guess))
            {
                label1.Visible = false;
                GueCharacters = guess.ToCharArray();
                Check(AnsCharacters, GueCharacters, ref wrongtimes);
            }
            else { label1.Visible = true; }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        { label1.Visible = false; }
        
        //char guess
        private void char_click(string text)
        {
            guess = text;
            guess = guess.ToLower();
            GueCharacters = guess.ToCharArray();
            Check(AnsCharacters, GueCharacters, ref wrongtimes);
        }
        //Not optimised, don't judge ;-;
        private void buttonA_Click(object sender, EventArgs e)
        {
            string text = buttonA.Text;
            if (buttonA.BackColor != Color.Red) { char_click(text); }
        }
        private void buttonB_Click(object sender, EventArgs e)
        {
            string text = buttonB.Text;
            if (buttonB.BackColor != Color.Red) { char_click(text); }
        }
        private void buttonC_Click(object sender, EventArgs e)
        {
            string text = buttonC.Text;
            if (buttonC.BackColor != Color.Red) { char_click(text); }
        }
        private void buttonD_Click(object sender, EventArgs e)
        {
            string text = buttonD.Text;
            if (buttonD.BackColor != Color.Red) { char_click(text); }
        }
        private void buttonE_Click(object sender, EventArgs e)
        {
            string text = buttonE.Text;
            if (buttonE.BackColor != Color.Red) { char_click(text); }
        }
        private void buttonF_Click(object sender, EventArgs e)
        {
            string text = buttonF.Text;
            if (buttonF.BackColor != Color.Red) { char_click(text); }
        }
        private void buttonG_Click(object sender, EventArgs e)
        {
            string text = buttonG.Text;
            if (buttonG.BackColor != Color.Red) { char_click(text); }
        }
        private void buttonH_Click(object sender, EventArgs e)
        {
            string text = buttonH.Text;
            if (buttonH.BackColor != Color.Red) { char_click(text); }
        }
        private void buttonI_Click(object sender, EventArgs e)
        {
            string text = buttonI.Text;
            if (buttonI.BackColor != Color.Red) { char_click(text); }
        }
        private void buttonJ_Click(object sender, EventArgs e)
        {
            string text = buttonJ.Text;
            if (buttonJ.BackColor != Color.Red) { char_click(text); }
        }
        private void buttonK_Click(object sender, EventArgs e)
        {
            string text = buttonK.Text;
            if (buttonK.BackColor != Color.Red) { char_click(text); }
        }
        private void buttonL_Click(object sender, EventArgs e)
        {
            string text = buttonL.Text;
            if (buttonL.BackColor != Color.Red) { char_click(text); }
        }
        private void buttonM_Click(object sender, EventArgs e)
        {
            string text = buttonM.Text;
            if (buttonM.BackColor != Color.Red) { char_click(text); }
        }
        private void buttonN_Click(object sender, EventArgs e)
        {
            string text = buttonN.Text;
            if (buttonN.BackColor != Color.Red) { char_click(text); }
        }
        private void buttonO_Click(object sender, EventArgs e)
        {
            string text = buttonO.Text;
            if (buttonO.BackColor != Color.Red) { char_click(text); }
        }
        private void buttonP_Click(object sender, EventArgs e)
        {
            string text = buttonP.Text;
            if (buttonP.BackColor != Color.Red) { char_click(text); }
        }
        private void buttonQ_Click(object sender, EventArgs e)
        {
            string text = buttonQ.Text;
            if (buttonQ.BackColor != Color.Red) { char_click(text); }
        }
        private void buttonR_Click(object sender, EventArgs e)
        {
            string text = buttonR.Text;
            if (buttonR.BackColor != Color.Red) { char_click(text); }
        }
        private void buttonS_Click(object sender, EventArgs e)
        {
            string text = buttonS.Text;
            if (buttonS.BackColor != Color.Red) { char_click(text); }
        }
        private void buttonT_Click(object sender, EventArgs e)
        {
            string text = buttonT.Text;
            if (buttonT.BackColor != Color.Red) { char_click(text); }
        }
        private void buttonU_Click(object sender, EventArgs e)
        {
            string text = buttonU.Text;
            if (buttonU.BackColor != Color.Red) { char_click(text); }
        }
        private void buttonV_Click(object sender, EventArgs e)
        {
            string text = buttonV.Text;
            if (buttonV.BackColor != Color.Red) { char_click(text); }
        }
        private void buttonW_Click(object sender, EventArgs e)
        {
            string text = buttonW.Text;
            if (buttonW.BackColor != Color.Red) { char_click(text); }
        }
        private void buttonX_Click(object sender, EventArgs e)
        {
            string text = buttonX.Text;
            if (buttonX.BackColor != Color.Red) { char_click(text); }
        }
        private void buttonY_Click(object sender, EventArgs e)
        {
            string text = buttonY.Text;
            if (buttonY.BackColor != Color.Red) { char_click(text); }
        }
        private void buttonZ_Click(object sender, EventArgs e)
        {
            string text = buttonZ.Text;
            if(buttonZ.BackColor != Color.Red) { char_click(text); }
        }
    }
}