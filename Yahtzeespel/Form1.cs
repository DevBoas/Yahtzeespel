using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yahtzeespel.Properties;

namespace Yahtzeespel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            RandomizeDice();
        }

        private void RandomizeDice()
        {
            Random rnd = new Random();
            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(PictureBox))
                {
                    PictureBox pic = (PictureBox)c;
                    if (pic.BackColor == SystemColors.Control)
                    {
                        int dice = rnd.Next(1, 7);
                        object O = Resources.ResourceManager.GetObject("Dice" + dice.ToString());
                        pic.Image = (Image)O;
                        pic.Image.Tag = dice.ToString();
                    }
                }
            }
        }

        int rolls = 3;
        int gameRound = 1;
        Boolean newGame = false;
        Boolean scored = false;
        private void DiceClick(object sender, EventArgs e)
        {
            if (rolls < 3)
            {
                PictureBox pic = (PictureBox)sender;
                if (pic.BackColor == Color.Red)
                    pic.BackColor = SystemColors.Control;
                else
                    pic.BackColor = Color.Red;
            }
        }

        private void EndOfGame()
        {
            if (!newGame)
            {
                newGame = true;
                UpdateScoreBoard();
            }
        }

        private void CheckForStraight()
        {
            int count = 0;
            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(Label))
                {
                    Label lab = (Label)c;
                    if (lab.Tag != null && lab.Tag.ToString() != String.Empty)
                    {
                        String tag = lab.Tag.ToString();
                        int number = System.Convert.ToInt32(lab.Text.Substring(lab.Text.Length - 1));
                        if (number > 0)
                            count++;
                        else
                            count = 0;
                        if (count == 4)
                            SmallStraight.Text = SmallStraight.Text.Substring(0, SmallStraight.Text.Length - 1) + "30";
                        else if(count == 5)
                            LargeStraight.Text = LargeStraight.Text.Substring(0, LargeStraight.Text.Length - 1) + "40";
                        //MessageBox.Show("Tag = " + tag);
                    }
                }
            }
        }
        private void CheckForCarrre()
        {
            Boolean found = false;
            int total = 0;
            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(Label))
                {
                    Label lab = (Label)c;
                    if (lab.Tag != null && lab.Tag.ToString() != String.Empty)
                    {
                        String tag = lab.Tag.ToString();
                        int number = System.Convert.ToInt32(lab.Text.Substring(lab.Text.Length - 1));
                        total += number * System.Convert.ToInt32(tag);
                        if (number == 4)
                            found = true;
                    }
                }
            }
            if (found)
                Carre.Text = Carre.Text.Substring(0, Carre.Text.Length - 1) + total.ToString();
        }

        private void CheckForThreeOfAKind()
        {
            Boolean found = false;
            int total = 0;
            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(Label))
                {
                    Label lab = (Label)c;
                    if (lab.Tag != null && lab.Tag.ToString() != String.Empty)
                    {
                        String tag = lab.Tag.ToString();
                        int number = System.Convert.ToInt32(lab.Text.Substring(lab.Text.Length - 1));
                        total += number * System.Convert.ToInt32(tag);
                        if (number == 3)
                            found = true;
                    }
                }
            }
            if (found)
                ThreeOfAKind.Text = ThreeOfAKind.Text.Substring(0, ThreeOfAKind.Text.Length - 1) + total.ToString();
        }

        private void CheckForYahtzee()
        {
            foreach (Control c2 in Controls)
            {
                if (c2.GetType() == typeof(Label))
                {
                    Label lab = (Label)c2;
                    if (lab.Tag != null && lab.Tag.ToString() != String.Empty)
                    {
                        String tag = lab.Tag.ToString();
                        int number = System.Convert.ToInt32(lab.Text.Substring(lab.Text.Length - 1));
                        if (number == 5)
                            Yahtzee.Text = Yahtzee.Text.Substring(0, Yahtzee.Text.Length - 1) + "50";
                    }
                }
            }
        }
        private void CheckForChance()
        {
            int total = 0;
            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(Label))
                {
                    Label lab = (Label)c;
                    if (lab.Tag != null && lab.Tag.ToString() != String.Empty)
                    {
                        String tag = lab.Tag.ToString();
                        int number = System.Convert.ToInt32(lab.Text.Substring(lab.Text.Length - 1));
                        total += number * System.Convert.ToInt32(tag);
                    }
                }
            }
            Chance.Text = Chance.Text.Substring(0, Chance.Text.Length - 1) + total.ToString();
        }
        private void UpdateScoreBoard()
        {

            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(PictureBox))
                {
                    PictureBox pic = (PictureBox)c;
                    String tag = pic.Image.Tag.ToString();
                    //MessageBox.Show("Tag1 = " + tag);
                    foreach (Control c2 in Controls)
                    {
                        if (c2.GetType() == typeof(Label))
                        {
                            Label lab = (Label)c2;
                            if (lab.Tag != null)
                            {
                                String tag2 = lab.Tag.ToString();
                                if (tag2 == tag)
                                {
                                    int number = System.Convert.ToInt32(lab.Text.Substring(lab.Text.Length-1));
                                    //MessageBox.Show("Number = " + number.ToString());
                                    number++;
                                    lab.Text = lab.Text.Substring(0, lab.Text.Length - 1) + number.ToString();
                                }
                            }
                        }
                    }
                }
            }
            CheckForThreeOfAKind();
            CheckForCarrre();
            CheckForStraight();
            CheckForYahtzee();
            CheckForChance();
        }
        
        private void RollDice(object sender, EventArgs e)
        {
            if (rolls > 0)
            {
                int gooit = 0; 
                Random rnd = new Random();
                foreach (Control c in Controls)
                {
                    if (c.GetType() == typeof(PictureBox))
                    {
                        PictureBox pic = (PictureBox)c;
                        if (pic.BackColor == SystemColors.Control)
                        {
                            int dice = rnd.Next(1, 7);
                            object O = Resources.ResourceManager.GetObject("Dice" + dice.ToString());
                            pic.Image = (Image)O;
                            pic.Image.Tag = dice.ToString();
                            gooit++;
                        }
                    }
                }
                if (gooit > 0)
                {
                    rolls--;
                    UserRollsDisplay.Text = "Rolls left " + rolls.ToString();
                }
            }
            if (rolls == 0)
                EndOfGame();
        }

        private void Stoppen_Click(object sender, EventArgs e)
        {
            if (rolls < 3)
            {
                rolls = 0;
                UserRollsDisplay.Text = "Rolls left: " + rolls.ToString();
                EndOfGame();
            }
        }
        private int getSubstringPosNumber(Label lab)
        {
            int loc = 0;
            for (int i = 0; i < lab.Text.Length; i++)
            {
                if (lab.Text[i].ToString() == ":")
                {
                    loc = i;
                    break;
                }
            }
            return loc;
        }

        private void nextRound()
        {
            if (gameRound < 13)
            {
                gameRound++;
                // reset scoreboard to default
                foreach (Control c in Controls)
                {
                    if (c.GetType() == typeof(Label))
                    {
                        Label lab = (Label)c;
                        if (lab.Tag != null)
                        {
                            if ((getSubstringPosNumber(lab) != 0) && (lab.Name != "Score"))
                            {
                                lab.Text = lab.Text.Substring(0, getSubstringPosNumber(lab) + 2) + "0";
                            }
                        }
                    }
                }
                // clear dice;
                foreach (Control c in Controls)
                {
                    if (c.GetType() == typeof(PictureBox))
                    {
                        PictureBox pic = (PictureBox)c;
                        pic.BackColor = SystemColors.Control;
                    }
                }
                Round.Text = "Round " + gameRound.ToString();
                rolls = 3;
                UserRollsDisplay.Text = "Rolls left: " + rolls.ToString();
                newGame = false;
                scored = false;
            }
        }

        private void Addscore(object sender, EventArgs e)
        {
            if (!scored)
            {
                scored = true;
                Label lab = (sender as Label);
                int number = System.Convert.ToInt32(lab.Text.Substring(getSubstringPosNumber(lab) + 1));
                int scoreNumber = System.Convert.ToInt32(Score.Text.Substring(getSubstringPosNumber(Score) + 1));
                int totalScore = number + scoreNumber;
                Score.Text = Score.Text.Substring(0, getSubstringPosNumber(Score) + 2) + totalScore.ToString();
                nextRound();
            }
        }
    }
}
