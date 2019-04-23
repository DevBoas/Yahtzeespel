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
        }
        int rolls = 3;
        private void DiceClick(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            if (pic.BackColor == Color.Red)
                pic.BackColor = SystemColors.Control;
            else
                pic.BackColor = Color.Red;
        }

        private void EndOfGame()
        {
            MessageBox.Show("Truly is the end");
            UpdateScoreBoard();
        }

        private void UpdateScoreBoard()
        {
            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(PictureBox))
                {
                    PictureBox pic = (PictureBox)c;
                    String tag = pic.Image.Tag.ToString();
                    MessageBox.Show("Tag1 = " + tag);
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
                    UserRollsDisplay.Text = "Rolls left: " + rolls.ToString();
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
    }
}