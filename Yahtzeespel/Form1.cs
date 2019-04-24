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
        Boolean YahtzeeBonus = false;
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
                ResetScoreBoard();
                UpdateScoreBoard();
            }
        }

        private void CheckForStraight()
        {
            int[] dices = new int[5];
            int index = 0;
            int steps = 1;
            int biggestStep = 1;
            int same = 1;
            for (int i = 1; i < 7; i++)
            {
                foreach (Control c in Controls)
                {
                    if (c.GetType() == typeof(PictureBox))
                    {
                        PictureBox pic = (PictureBox)c;
                        int DiceNumber = System.Convert.ToInt32(pic.Image.Tag);
                        if (DiceNumber == i)
                        {
                            dices[index] = DiceNumber;
                            index++;
                        }
                    }
                }
            }
            
            for (int i = 0; i < dices.Length; i++)
            {
                if (i > 0)
                {
                    int thisStep = dices[i] - dices[i - 1];
                    if (thisStep == 1)
                        steps++;
                    else if (thisStep == 0)
                        same++;
                    else
                        steps = 1;
                    if (steps > biggestStep)
                        biggestStep = steps;
                }
            }
            //MessageBox.Show("Same = " + same.ToString());
            //MessageBox.Show("Steps = " + biggestStep.ToString());
            //MessageBox.Show(SmallStraight.Text.Substring(0, SmallStraight.Text.Length - 1));
            if ((Fullhouse.Tag.ToString() != "X") && (same == 4))
                Fullhouse.Text = Fullhouse.Text.Substring(0, Fullhouse.Text.Length - 1) + "25";
            if ((SmallStraight.Tag.ToString() != "X") && (steps > 3))
                SmallStraight.Text = SmallStraight.Text.Substring(0, SmallStraight.Text.Length - 1) + "30";
            if ((LargeStraight.Tag.ToString() != "X") && (steps > 4))
                LargeStraight.Text = LargeStraight.Text.Substring(0, LargeStraight.Text.Length - 1) + "40";
            //MessageBox.Show(i + " place is = " + dices[i].ToString());
        }

        private void CheckForCarrre()
        {
            int[] dices = new int[5];
            int index = 0;
            int highestCount = 0;
            int count = 0;
            int total = 0;
            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(PictureBox))
                {
                    PictureBox pic = (PictureBox)c;
                    int DiceNumber = System.Convert.ToInt32(pic.Image.Tag);
                    dices[index] = DiceNumber;
                    index++;
                }
            }
            for (int i = 1; i < 7; i++)
            {
                for (int y = 0; y < dices.Length; y++)
                {
                    if (dices[y] == i)
                        count++;
                }
                if (count > highestCount)
                    highestCount = count;
                count = 0;
            }
            //MessageBox.Show("Highest int = " + highestCountNum.ToString());
            //MessageBox.Show("Highest amount = " + highestCount.ToString());
            for (int y = 0; y < dices.Length; y++)
            {
                total += dices[y];
            }
            //MessageBox.Show("Total amount = " + total.ToString());
            if ((Carre.Tag.ToString() != "X") && (highestCount >= 4))
                Carre.Text = Carre.Text.Substring(0, Carre.Text.Length - 1) + total.ToString();
        }

        private void CheckForThreeOfAKind()
        {
            int[] dices = new int[5];
            int index = 0;
            int highestCount = 0;
            int count = 0;
            int total = 0;
            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(PictureBox))
                {
                    PictureBox pic = (PictureBox)c;
                    int DiceNumber = System.Convert.ToInt32(pic.Image.Tag);
                    dices[index] = DiceNumber;
                    index++;
                }
            }
            for (int i = 1; i < 7; i++)
            {
                for (int y = 0; y < dices.Length; y++)
                {
                    if (dices[y] == i)
                        count++;
                }
                if (count > highestCount)
                    highestCount = count;
                count = 0;
            }
            //MessageBox.Show("Highest int = " + highestCountNum.ToString());
            //MessageBox.Show("Highest amount = " + highestCount.ToString());
            for (int y = 0; y < dices.Length; y++)
            {
                total += dices[y];
            }
            //MessageBox.Show("Total amount = " + total.ToString());
            if ((ThreeOfAKind.Tag.ToString() != "X") && (highestCount >= 3))
                ThreeOfAKind.Text = ThreeOfAKind.Text.Substring(0, ThreeOfAKind.Text.Length - 1) + total.ToString();
        }

        private void CheckForYahtzee()
        {
            int[] dices = new int[5];
            int index = 0;
            int count = 1;
            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(PictureBox))
                {
                    PictureBox pic = (PictureBox)c;
                    int DiceNumber = System.Convert.ToInt32(pic.Image.Tag);
                    dices[index] = DiceNumber;
                    index++;
                }
            }
            for (int i = 0; i < dices.Length; i++)
            {
               if (i > 0)
                if (dices[i] == dices[i - 1])
                    count++;
            }
            if (count == 5)
            {
                if (Yahtzee.Tag.ToString() != "X")
                {
                    if (YahtzeeBonus)
                    {
                        Yahtzee.Text = Yahtzee.Text.Substring(0, Yahtzee.Text.Length - 1) + "100 ";
                    }
                    else
                    {
                        Yahtzee.Text = Yahtzee.Text.Substring(0, Yahtzee.Text.Length - 1) + "50";
                        YahtzeeBonus = true;
                    }
                }
            }
            //MessageBox.Show("Count = " + count.ToString());
        }
        private void CheckForChance()
        {
            int total = 0;
            //int[] dices = new int[5];
            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(PictureBox))
                {
                    PictureBox pic = (PictureBox)c;
                    int DiceNumber = System.Convert.ToInt32(pic.Image.Tag);
                    total += DiceNumber;
                }
            }
            if (Chance.Tag.ToString() != "X")
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
                                    int number = System.Convert.ToInt32(lab.Text.Substring(getSubstringPosNumber(lab) + 1));
                                    //MessageBox.Show("NowNumber = " + number.ToString());
                                    int diceNumber = System.Convert.ToInt32(tag.ToString());
                                    //MessageBox.Show("to add dicenumb = " + diceNumber.ToString());
                                    lab.Text = lab.Text.Substring(0, lab.Text.Length - 1) + (number + diceNumber);
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
                    ResetScoreBoard();
                    UpdateScoreBoard();
                    rolls--;
                    UserRollsDisplay.Text = "Rolls left " + rolls.ToString();
                }
            }
            if (rolls == 0)
                EndOfGame();
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
        private void ResetScoreBoard()
        {
            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(Label))
                {
                    Label lab = (Label)c;
                    if (lab.Tag != null)
                    {
                        if ((getSubstringPosNumber(lab) != 0) && (lab.Name != "Score") && lab.Tag.ToString() != "X")
                        {
                            lab.Text = lab.Text.Substring(0, getSubstringPosNumber(lab) + 2) + "0";
                        }
                    }
                }
            }
        }
        private void nextRound()
        {

            // reset scoreboard to default
            ResetScoreBoard();
            // clear dice;
            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(PictureBox))
                {
                    PictureBox pic = (PictureBox)c;
                    pic.BackColor = SystemColors.Control;
                }
            }
            gameRound++;
            if (gameRound < 13)
                rolls = 3;
            else
                rolls = 0;
            Round.Text = "Round " + gameRound.ToString();
            if (gameRound < 13)
            {
                newGame = false;
                scored = false;
            }
            else if (gameRound == 13)
            {
                scored = false;
                Btn_RollDice.Text = "New game";
            }
            UserRollsDisplay.Text = "Rolls left " + rolls.ToString();
        }

        private void Addscore(object sender, EventArgs e)
        {
            if (!scored)
            {
                Label lab = (sender as Label);
                if (lab.Tag.ToString() != "X")
                {
                    scored = true;
                    lab.ForeColor = Color.Red;
                    lab.Tag = "X";
                    int number = System.Convert.ToInt32(lab.Text.Substring(getSubstringPosNumber(lab) + 1));
                    int scoreNumber = System.Convert.ToInt32(Score.Text.Substring(getSubstringPosNumber(Score) + 1));
                    int totalScore = number + scoreNumber;
                    Score.Text = Score.Text.Substring(0, getSubstringPosNumber(Score) + 2) + totalScore.ToString();
                    nextRound();
                }
            }
        }
    }
}
