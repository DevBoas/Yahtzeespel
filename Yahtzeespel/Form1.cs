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
                UpdateScoreBoard();
            }
        }

        private void CheckForStraight()
        {
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
            int num = System.Convert.ToInt32(ThreeOfAKind.Text.Substring(getSubstringPosNumber(ThreeOfAKind) + 1));
            if ((num == 0) && (highestCount >= 4))
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
            int num = System.Convert.ToInt32(ThreeOfAKind.Text.Substring(getSubstringPosNumber(ThreeOfAKind) + 1));
            if ((num == 0) && (highestCount >= 3))
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
                int num = System.Convert.ToInt32(Yahtzee.Text.Substring(getSubstringPosNumber(Yahtzee) + 1));
                if (num == 0)
                    Yahtzee.Text = Yahtzee.Text.Substring(0, Yahtzee.Text.Length - 1) + "50";
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
            int num = System.Convert.ToInt32(Chance.Text.Substring(getSubstringPosNumber(Chance) + 1));
            if (num == 0)
            {
                Chance.Text = Chance.Text.Substring(0, Chance.Text.Length - 1) + total.ToString();
            }
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

            // reset scoreboard to default
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
            // clear dice;
            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(PictureBox))
                {
                    PictureBox pic = (PictureBox)c;
                    pic.BackColor = SystemColors.Control;
                }
            }
            if (gameRound < 13)
            {
                gameRound++;
                Round.Text = "Round " + gameRound.ToString();
                rolls = 3;
                UserRollsDisplay.Text = "Rolls left: " + rolls.ToString();
                newGame = false;
                scored = false;
            }
            else if (gameRound == 13)
            {
                scored = false;
                Btn_RollDice.Text = "New game";
            }
        }

        private void Addscore(object sender, EventArgs e)
        {
            if (!scored)
            {
                scored = true;
                Label lab = (sender as Label);
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
