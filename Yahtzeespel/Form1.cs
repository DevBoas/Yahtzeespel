using System;
using System.Drawing;
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

        private void CheckForChance(int[] DiceNumberArr)
        {
            int total = 0;
            for (int i = 0; i < DiceNumberArr.Length; i++)
                total += DiceNumberArr[i] * i + 1;
            if (Chance.Tag.ToString() != "X")
                Chance.Text = Chance.Text.Substring(0, getSubstringPosNumber(Chance) + 2) + total.ToString();
        }

        private void CheckForThreeOfAKind(int[] DiceNumberArr)
        {
            Boolean found = false;
            int total = 0;
            for (int i = 0; i < DiceNumberArr.Length; i++)
            {
                total += DiceNumberArr[i] * i + 1;
                if (DiceNumberArr[i] >= 3)
                    found = true;
            }
            if (found && (ThreeOfAKind.Tag.ToString() != "X"))
                ThreeOfAKind.Text = ThreeOfAKind.Text.Substring(0, getSubstringPosNumber(ThreeOfAKind) + 2) + total.ToString();
        }

        private void CheckForCarrre(int[] DiceNumberArr)
        {
            Boolean found = false;
            int total = 0;
            for (int i = 0; i < DiceNumberArr.Length; i++)
            {
                total += DiceNumberArr[i] * i + 1;
                if (DiceNumberArr[i] >= 4)
                    found = true;
            }
            if (found && (Carre.Tag.ToString() != "X"))
                Carre.Text = Carre.Text.Substring(0, getSubstringPosNumber(Carre) + 2) + total.ToString();
        }
        private void CheckForStraight(int[] DiceNumberArr)
        {
            int count = 0;
            int steps = 0;
            int biggestStep = 1;
            Boolean fullhouse = false;

            for (int i = 0; i < DiceNumberArr.Length; i++)
            {
                if (DiceNumberArr[i] > 0)
                {
                    if (DiceNumberArr[i] > 1)
                    {
                        if ((DiceNumberArr[i] == 2) && (count == 3) || (DiceNumberArr[i] == 3) && (count == 2))
                            fullhouse = true;
                        count = DiceNumberArr[i];
                    }
                    steps++;
                    if (steps > biggestStep)
                        biggestStep = steps;
                }
                else
                    steps = 0;
            }
            if ((fullhouse) && (Fullhouse.Tag.ToString() != "X"))
                Fullhouse.Text = Fullhouse.Text.Substring(0, getSubstringPosNumber(Fullhouse) + 2) + "25";
            if ((biggestStep > 3) && (SmallStraight.Tag.ToString() != "X"))
                SmallStraight.Text = SmallStraight.Text.Substring(0, getSubstringPosNumber(SmallStraight) + 2) + "30";
            if ((biggestStep == 5) && (LargeStraight.Tag.ToString() != "X"))
                LargeStraight.Text = LargeStraight.Text.Substring(0, getSubstringPosNumber(LargeStraight) + 2) + "40";
        }

        private void CheckForYahtzee(int[] DiceNumberArr)
        {
            int yahtzee = 0;

            for (int i = 0; i < DiceNumberArr.Length; i++)
                if (DiceNumberArr[i] == 5)
                    yahtzee = i + 1;

            if (yahtzee > 0)
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
                        Label lab = CheckForForcePick(yahtzee);
                        if (lab != null)
                            HasToPick = lab;
                        else
                        {
                            Fullhouse.Text = Fullhouse.Text.Substring(0, getSubstringPosNumber(Fullhouse) + 2) + "25";
                            SmallStraight.Text = SmallStraight.Text.Substring(0, getSubstringPosNumber(SmallStraight) + 2) + "30";
                            LargeStraight.Text = LargeStraight.Text.Substring(0, getSubstringPosNumber(LargeStraight) + 2) + "40";
                        }
                        Yahtzee.Text = Yahtzee.Text.Substring(0, getSubstringPosNumber(Yahtzee) + 2) + (yahtzeeNumber + 100).ToString();
                        Score.Text = Score.Text.Substring(0, getSubstringPosNumber(Score) + 2) + totalScore.ToString();
                    }
                }
            }
            //MessageBox.Show("Count = " + count.ToString());
        }

        private void UpdateSingles(int[] DiceNumberArr)
        {
            for (int i = 0; i < DiceNumberArr.Length; i++)
            {
                foreach (Control c in Controls)
                {
                    if (c.GetType() == typeof(Label))
                    {
                        Label lab = (Label)c;
                        if (lab.Tag != null && (lab.Tag.ToString() != String.Empty) && (lab.Tag.ToString() != "X"))
                        {
                            int ScoreTagNum = System.Convert.ToInt32(lab.Tag);
                            if ((i + 1) == ScoreTagNum)
                            {
                                lab.Text = lab.Text.Substring(0, getSubstringPosNumber(lab) + 2) + (DiceNumberArr[i] * (i + 1) ).ToString();
                                break;
                            }
                        }
                    }
                }
            }
        }
        private void UpdateScoreBoard(int [] DiceNumberArr)
        {
            UpdateSingles(DiceNumberArr);
            CheckForThreeOfAKind(DiceNumberArr);
            CheckForCarrre(DiceNumberArr);
            CheckForStraight(DiceNumberArr);
            CheckForChance(DiceNumberArr);
            CheckForYahtzee(DiceNumberArr);
        }
        
        private void RollDice(object sender, EventArgs e)
        {
            int[] DiceNumberArr = new int[6] { 0, 0, 0, 0, 0, 0 };
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
                                DiceNumberArr[dice-1]++;
                                pic.Image = (Image)Resources.ResourceManager.GetObject("Dice" + dice.ToString());
                                pic.Image.Tag = dice.ToString();
                                gooit++;
                            }
                        }
                    }
                    if (gooit > 0)
                    {
                        ResetScoreBoard();
                        UpdateScoreBoard(DiceNumberArr);
                        rolls--;
                        if (rolls == 0)
                            Btn_RollDice.Enabled = false;
                        UserRollsDisplay.Text = "Rolls left " + rolls.ToString();
                    }
                }
            }
            else
                ResetGame();
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
                        if ((getSubstringPosNumber(lab) != 0) && (lab.Name != "Score") && lab.Tag.ToString() != "X")
                            lab.Text = lab.Text.Substring(0, getSubstringPosNumber(lab) + 2) + "0";
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
                rolls = 0;
                Btn_RollDice.Text = "New game";
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
                    MessageBox.Show("You must put your score in " + HasToPick.Text.Substring(0, getSubstringPosNumber(HasToPick)) + ".");
            }
        }
    }
}
