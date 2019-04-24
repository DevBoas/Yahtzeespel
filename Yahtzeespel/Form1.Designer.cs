namespace Yahtzeespel
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
            this.Dice2 = new System.Windows.Forms.PictureBox();
            this.Dice3 = new System.Windows.Forms.PictureBox();
            this.Dice4 = new System.Windows.Forms.PictureBox();
            this.Dice5 = new System.Windows.Forms.PictureBox();
            this.Dice1 = new System.Windows.Forms.PictureBox();
            this.Btn_RollDice = new System.Windows.Forms.Button();
            this.UserRollsDisplay = new System.Windows.Forms.Label();
            this.Score1 = new System.Windows.Forms.Label();
            this.Score2 = new System.Windows.Forms.Label();
            this.Score3 = new System.Windows.Forms.Label();
            this.Score6 = new System.Windows.Forms.Label();
            this.Score5 = new System.Windows.Forms.Label();
            this.Score4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SmallStraight = new System.Windows.Forms.Label();
            this.LargeStraight = new System.Windows.Forms.Label();
            this.Yahtzee = new System.Windows.Forms.Label();
            this.ThreeOfAKind = new System.Windows.Forms.Label();
            this.Carre = new System.Windows.Forms.Label();
            this.Chance = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Round = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.Label();
            this.Fullhouse = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dice2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dice3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dice4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dice5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dice1)).BeginInit();
            this.SuspendLayout();
            // 
            // Dice2
            // 
            this.Dice2.Image = global::Yahtzeespel.Properties.Resources.Dice1;
            this.Dice2.Location = new System.Drawing.Point(68, 29);
            this.Dice2.Name = "Dice2";
            this.Dice2.Size = new System.Drawing.Size(50, 50);
            this.Dice2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dice2.TabIndex = 1;
            this.Dice2.TabStop = false;
            this.Dice2.Click += new System.EventHandler(this.DiceClick);
            // 
            // Dice3
            // 
            this.Dice3.Image = global::Yahtzeespel.Properties.Resources.Dice1;
            this.Dice3.Location = new System.Drawing.Point(124, 29);
            this.Dice3.Name = "Dice3";
            this.Dice3.Size = new System.Drawing.Size(50, 50);
            this.Dice3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dice3.TabIndex = 2;
            this.Dice3.TabStop = false;
            this.Dice3.Click += new System.EventHandler(this.DiceClick);
            // 
            // Dice4
            // 
            this.Dice4.Image = global::Yahtzeespel.Properties.Resources.Dice1;
            this.Dice4.Location = new System.Drawing.Point(180, 29);
            this.Dice4.Name = "Dice4";
            this.Dice4.Size = new System.Drawing.Size(50, 50);
            this.Dice4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dice4.TabIndex = 3;
            this.Dice4.TabStop = false;
            this.Dice4.Click += new System.EventHandler(this.DiceClick);
            // 
            // Dice5
            // 
            this.Dice5.Image = global::Yahtzeespel.Properties.Resources.Dice1;
            this.Dice5.Location = new System.Drawing.Point(236, 29);
            this.Dice5.Name = "Dice5";
            this.Dice5.Size = new System.Drawing.Size(50, 50);
            this.Dice5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dice5.TabIndex = 4;
            this.Dice5.TabStop = false;
            this.Dice5.Click += new System.EventHandler(this.DiceClick);
            // 
            // Dice1
            // 
            this.Dice1.BackColor = System.Drawing.SystemColors.Control;
            this.Dice1.Image = global::Yahtzeespel.Properties.Resources.Dice1;
            this.Dice1.Location = new System.Drawing.Point(12, 29);
            this.Dice1.Name = "Dice1";
            this.Dice1.Size = new System.Drawing.Size(50, 50);
            this.Dice1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dice1.TabIndex = 5;
            this.Dice1.TabStop = false;
            this.Dice1.Click += new System.EventHandler(this.DiceClick);
            // 
            // Btn_RollDice
            // 
            this.Btn_RollDice.Location = new System.Drawing.Point(12, 110);
            this.Btn_RollDice.Name = "Btn_RollDice";
            this.Btn_RollDice.Size = new System.Drawing.Size(75, 23);
            this.Btn_RollDice.TabIndex = 6;
            this.Btn_RollDice.Text = "Roll dice";
            this.Btn_RollDice.UseVisualStyleBackColor = true;
            this.Btn_RollDice.Click += new System.EventHandler(this.RollDice);
            // 
            // UserRollsDisplay
            // 
            this.UserRollsDisplay.AutoSize = true;
            this.UserRollsDisplay.Location = new System.Drawing.Point(227, 9);
            this.UserRollsDisplay.Name = "UserRollsDisplay";
            this.UserRollsDisplay.Size = new System.Drawing.Size(56, 13);
            this.UserRollsDisplay.TabIndex = 7;
            this.UserRollsDisplay.Text = "Rolls left 3";
            // 
            // Score1
            // 
            this.Score1.AutoSize = true;
            this.Score1.Location = new System.Drawing.Point(330, 29);
            this.Score1.Name = "Score1";
            this.Score1.Size = new System.Drawing.Size(44, 13);
            this.Score1.TabIndex = 9;
            this.Score1.Tag = "1";
            this.Score1.Text = "Ones: 0";
            this.Score1.Click += new System.EventHandler(this.Addscore);
            // 
            // Score2
            // 
            this.Score2.AutoSize = true;
            this.Score2.Location = new System.Drawing.Point(329, 42);
            this.Score2.Name = "Score2";
            this.Score2.Size = new System.Drawing.Size(45, 13);
            this.Score2.TabIndex = 10;
            this.Score2.Tag = "2";
            this.Score2.Text = "Twos: 0";
            this.Score2.Click += new System.EventHandler(this.Addscore);
            // 
            // Score3
            // 
            this.Score3.AutoSize = true;
            this.Score3.Location = new System.Drawing.Point(322, 55);
            this.Score3.Name = "Score3";
            this.Score3.Size = new System.Drawing.Size(52, 13);
            this.Score3.TabIndex = 11;
            this.Score3.Tag = "3";
            this.Score3.Text = "Threes: 0";
            this.Score3.Click += new System.EventHandler(this.Addscore);
            // 
            // Score6
            // 
            this.Score6.AutoSize = true;
            this.Score6.Location = new System.Drawing.Point(330, 94);
            this.Score6.Name = "Score6";
            this.Score6.Size = new System.Drawing.Size(44, 13);
            this.Score6.TabIndex = 14;
            this.Score6.Tag = "6";
            this.Score6.Text = "Sixes: 0";
            this.Score6.Click += new System.EventHandler(this.Addscore);
            // 
            // Score5
            // 
            this.Score5.AutoSize = true;
            this.Score5.Location = new System.Drawing.Point(330, 81);
            this.Score5.Name = "Score5";
            this.Score5.Size = new System.Drawing.Size(44, 13);
            this.Score5.TabIndex = 13;
            this.Score5.Tag = "5";
            this.Score5.Text = "Fives: 0";
            this.Score5.Click += new System.EventHandler(this.Addscore);
            // 
            // Score4
            // 
            this.Score4.AutoSize = true;
            this.Score4.Location = new System.Drawing.Point(329, 68);
            this.Score4.Name = "Score4";
            this.Score4.Size = new System.Drawing.Size(45, 13);
            this.Score4.TabIndex = 12;
            this.Score4.Tag = "4";
            this.Score4.Text = "Fours: 0";
            this.Score4.Click += new System.EventHandler(this.Addscore);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(314, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "ScoreBoard";
            // 
            // SmallStraight
            // 
            this.SmallStraight.AutoSize = true;
            this.SmallStraight.Location = new System.Drawing.Point(412, 66);
            this.SmallStraight.Name = "SmallStraight";
            this.SmallStraight.Size = new System.Drawing.Size(81, 13);
            this.SmallStraight.TabIndex = 16;
            this.SmallStraight.Tag = "";
            this.SmallStraight.Text = "Small straight: 0";
            this.SmallStraight.Click += new System.EventHandler(this.Addscore);
            // 
            // LargeStraight
            // 
            this.LargeStraight.AutoSize = true;
            this.LargeStraight.Location = new System.Drawing.Point(410, 79);
            this.LargeStraight.Name = "LargeStraight";
            this.LargeStraight.Size = new System.Drawing.Size(83, 13);
            this.LargeStraight.TabIndex = 18;
            this.LargeStraight.Tag = "";
            this.LargeStraight.Text = "Large straight: 0";
            this.LargeStraight.Click += new System.EventHandler(this.Addscore);
            // 
            // Yahtzee
            // 
            this.Yahtzee.AutoSize = true;
            this.Yahtzee.Location = new System.Drawing.Point(435, 92);
            this.Yahtzee.Name = "Yahtzee";
            this.Yahtzee.Size = new System.Drawing.Size(58, 13);
            this.Yahtzee.TabIndex = 19;
            this.Yahtzee.Tag = "";
            this.Yahtzee.Text = "Yahtzee: 0";
            this.Yahtzee.Click += new System.EventHandler(this.Addscore);
            // 
            // ThreeOfAKind
            // 
            this.ThreeOfAKind.AutoSize = true;
            this.ThreeOfAKind.Location = new System.Drawing.Point(402, 29);
            this.ThreeOfAKind.Name = "ThreeOfAKind";
            this.ThreeOfAKind.Size = new System.Drawing.Size(91, 13);
            this.ThreeOfAKind.TabIndex = 20;
            this.ThreeOfAKind.Tag = "";
            this.ThreeOfAKind.Text = "Three of a kind: 0";
            this.ThreeOfAKind.Click += new System.EventHandler(this.Addscore);
            // 
            // Carre
            // 
            this.Carre.AutoSize = true;
            this.Carre.Location = new System.Drawing.Point(449, 42);
            this.Carre.Name = "Carre";
            this.Carre.Size = new System.Drawing.Size(44, 13);
            this.Carre.TabIndex = 21;
            this.Carre.Tag = "";
            this.Carre.Text = "Carré: 0";
            this.Carre.Click += new System.EventHandler(this.Addscore);
            // 
            // Chance
            // 
            this.Chance.AutoSize = true;
            this.Chance.Location = new System.Drawing.Point(437, 105);
            this.Chance.Name = "Chance";
            this.Chance.Size = new System.Drawing.Size(56, 13);
            this.Chance.TabIndex = 22;
            this.Chance.Tag = "";
            this.Chance.Text = "Chance: 0";
            this.Chance.Click += new System.EventHandler(this.Addscore);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(428, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Combo";
            // 
            // Round
            // 
            this.Round.AutoSize = true;
            this.Round.Location = new System.Drawing.Point(14, 9);
            this.Round.Name = "Round";
            this.Round.Size = new System.Drawing.Size(48, 13);
            this.Round.TabIndex = 23;
            this.Round.Text = "Round 1";
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.Location = new System.Drawing.Point(374, 132);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(57, 16);
            this.Score.TabIndex = 24;
            this.Score.Text = "Score: 0";
            // 
            // Fullhouse
            // 
            this.Fullhouse.AutoSize = true;
            this.Fullhouse.Location = new System.Drawing.Point(426, 53);
            this.Fullhouse.Name = "Fullhouse";
            this.Fullhouse.Size = new System.Drawing.Size(67, 13);
            this.Fullhouse.TabIndex = 25;
            this.Fullhouse.Tag = "";
            this.Fullhouse.Text = "Full house: 0";
            this.Fullhouse.Click += new System.EventHandler(this.Addscore);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 157);
            this.Controls.Add(this.Fullhouse);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.Round);
            this.Controls.Add(this.Chance);
            this.Controls.Add(this.Carre);
            this.Controls.Add(this.ThreeOfAKind);
            this.Controls.Add(this.Yahtzee);
            this.Controls.Add(this.LargeStraight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SmallStraight);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Score6);
            this.Controls.Add(this.Score5);
            this.Controls.Add(this.Score4);
            this.Controls.Add(this.Score3);
            this.Controls.Add(this.Score2);
            this.Controls.Add(this.Score1);
            this.Controls.Add(this.UserRollsDisplay);
            this.Controls.Add(this.Btn_RollDice);
            this.Controls.Add(this.Dice1);
            this.Controls.Add(this.Dice5);
            this.Controls.Add(this.Dice4);
            this.Controls.Add(this.Dice3);
            this.Controls.Add(this.Dice2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Yahtzee";
            ((System.ComponentModel.ISupportInitialize)(this.Dice2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dice3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dice4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dice5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dice1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Dice2;
        private System.Windows.Forms.PictureBox Dice3;
        private System.Windows.Forms.PictureBox Dice4;
        private System.Windows.Forms.PictureBox Dice5;
        private System.Windows.Forms.PictureBox Dice1;
        private System.Windows.Forms.Button Btn_RollDice;
        private System.Windows.Forms.Label UserRollsDisplay;
        private System.Windows.Forms.Label Score1;
        private System.Windows.Forms.Label Score2;
        private System.Windows.Forms.Label Score3;
        private System.Windows.Forms.Label Score6;
        private System.Windows.Forms.Label Score5;
        private System.Windows.Forms.Label Score4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label SmallStraight;
        private System.Windows.Forms.Label LargeStraight;
        private System.Windows.Forms.Label Yahtzee;
        private System.Windows.Forms.Label ThreeOfAKind;
        private System.Windows.Forms.Label Carre;
        private System.Windows.Forms.Label Chance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Round;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label Fullhouse;
    }
}

