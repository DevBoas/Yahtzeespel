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
        int rolls = 3;
        int gameRound = 1;
        int yahtzeeRound = 0;
        Label HasToPick = null;
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

        private void ResetGame()
        {
            rolls = 3;
            gameRound = 1;
            HasToPick = null;
            Btn_RollDice.Text = "Roll dice";
            UserRollsDisplay.Text = "Rolls left " + rolls.ToString();
            Round.Text = "Round " + gameRound.ToString();
            Score.Text = Score.Text.Substring(0, getSubstringPosNumber(Score) + 2) + "0";

            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(Label))
                {
                    Label lab = (Label)c;
                    if (lab.ForeColor == Color.Red)
                    {
                        if (lab.Name.Substring(0, lab.Name.Length - 1) == "Score")
                            lab.Tag = lab.Name[lab.Name.Length - 1].ToString();
                        else
                            lab.Tag = "";
                        lab.ForeColor = SystemColors.ControlText;
                    }
                }
            }

            ResetScoreBoard();
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
                Fullhouse.Text = Fullhouse.Text.Substring(0, getSubstringPosNumber(Fullhouse) + 2) + "25";
            if ((SmallStraight.Tag.ToString() != "X") && (steps > 3))
                SmallStraight.Text = SmallStraight.Text.Substring(0, getSubstringPosNumber(SmallStraight) + 2) + "30";
            if ((LargeStraight.Tag.ToString() != "X") && (steps > 4))
                LargeStraight.Text = LargeStraight.Text.Substring(0, getSubstringPosNumber(LargeStraight) + 2) + "40";
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
                Carre.Text = Carre.Text.Substring(0, getSubstringPosNumber(Carre) + 2) + total.ToString();
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
                ThreeOfAKind.Text = ThreeOfAKind.Text.Substring(0, getSubstringPosNumber(ThreeOfAKind) + 2) + total.ToString();
        }

        private Label CheckForForcePick(int num)
        {
            Label lab = null;

            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(Label))
                {
                    Label lab2 = (Label)c;
                    if (lab2.Tag != null)
                    {
                        string TagNumber = lab2.Tag.ToString();
                        //MessageBox.Show("Tag = " + TagNumber);
                        if (TagNumber == num.ToString())
                        {
                            lab = lab2;
                            break;
                        }
                    }
                }
            }
            return lab;
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
                int toAdd = 50;
                if (yahtzeeRound == 0)
                    yahtzeeRound = gameRound;
                if (Yahtzee.Tag.ToString() != "X")
                    Yahtzee.Text = Yahtzee.Text.Substring(0, getSubstringPosNumber(Yahtzee) + 2) + toAdd.ToString();
                else if (yahtzeeRound != gameRound)
                {
                    //joker
                    int yahtzeeNumber = System.Convert.ToInt32(Yahtzee.Text.Substring(getSubstringPosNumber(Yahtzee) + 1));
                    if (yahtzeeNumber > 0)
                    {
                        //ToAdd to conform to the rules force the user to pick eg 5-5-5-5-5 FIVES if thats filled it becomes a joker
                        int scoreNumber = System.Convert.ToInt32(Score.Text.Substring(getSubstringPosNumber(Score) + 1));
                        int totalScore = 100 + scoreNumber;
                        Label lab = CheckForForcePick(dices[0]);
                        if (lab != null)
                        {
                            //force user to pick
                            HasToPick = lab;
                        }
                        else
                        {
                            Fullhouse.Text = Fullhouse.Text.Substring(0, getSubstringPosNumber(Fullhouse) + 2) + "25";
                            SmallStraight.Text = SmallStraight.Text.Substring(0, getSubstringPosNumber(SmallStraight) + 2) + "30";
                            LargeStraight.Text = LargeStraight.Text.Substring(0, getSubstringPosNumber(LargeStraight) + 2) + "40";
                        }
                        Yahtzee.Text = Yahtzee.Text.Substring(0, getSubstringPosNumber(Yahtzee) + 2) + (yahtzeeNumber+100).ToString();
                        Score.Text = Score.Text.Substring(0, getSubstringPosNumber(Score) + 2) + totalScore.ToString();
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
                Chance.Text = Chance.Text.Substring(0, getSubstringPosNumber(Chance) + 2) + total.ToString();
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
                                    lab.Text = lab.Text.Substring(0, getSubstringPosNumber(lab) + 2) + (number + diceNumber);
                                }
                            }
                        }
                    }
                }
            }
            CheckForThreeOfAKind();
            CheckForCarrre();
            CheckForStraight();
            CheckForChance();
            CheckForYahtzee();
        }
        
        private void RollDice(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            if (btn.Text == "Roll dice")
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
                        if (rolls == 0)
                            Btn_RollDice.Enabled = false;
                        UserRollsDisplay.Text = "Rolls left " + rolls.ToString();
                    }
                }
            }
            else
            {
                ResetGame();
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

            // clear dice selections;
            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(PictureBox))
                {
                    PictureBox pic = (PictureBox)c;
                    pic.BackColor = SystemColors.Control;
                }
            }

            //re-enable button
            Btn_RollDice.Enabled = true;

            if (gameRound < 13)
            {
                rolls = 3;
                gameRound++;
            }
            else
            {
                Btn_RollDice.Text = "New game";
                rolls = 0;
            }

            Round.Text = "Round " + gameRound.ToString();
            UserRollsDisplay.Text = "Rolls left " + rolls.ToString();
        }

        private void Addscore(object sender, EventArgs e)
        {
            if (rolls != 3)
            {
                Label lab = (sender as Label);
                if (lab.Tag.ToString() != "X" && (HasToPick == null) || (HasToPick == lab))
                {
                    if (HasToPick != null)
                        HasToPick = null;
                    lab.ForeColor = Color.Red;
                    lab.Tag = "X";
                    int number = System.Convert.ToInt32(lab.Text.Substring(getSubstringPosNumber(lab) + 1));
                    int scoreNumber = System.Convert.ToInt32(Score.Text.Substring(getSubstringPosNumber(Score) + 1));
                    int totalScore = number + scoreNumber;
                    Score.Text = Score.Text.Substring(0, getSubstringPosNumber(Score) + 2) + totalScore.ToString();
                    nextRound();
                }
                else if (HasToPick != null)
                {
                    MessageBox.Show("You must put your score in " + HasToPick.Text.Substring(0, getSubstringPosNumber(HasToPick)) + ".");
                }
            }
        }

    }
}
