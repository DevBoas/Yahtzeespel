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
