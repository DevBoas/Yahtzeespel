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
            this.Stoppen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
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
            this.UserRollsDisplay.Location = new System.Drawing.Point(93, 115);
            this.UserRollsDisplay.Name = "UserRollsDisplay";
            this.UserRollsDisplay.Size = new System.Drawing.Size(59, 13);
            this.UserRollsDisplay.TabIndex = 7;
            this.UserRollsDisplay.Text = "Rolls left: 3";
            // 
            // Stoppen
            // 
            this.Stoppen.Location = new System.Drawing.Point(211, 110);
            this.Stoppen.Name = "Stoppen";
            this.Stoppen.Size = new System.Drawing.Size(75, 23);
            this.Stoppen.TabIndex = 8;
            this.Stoppen.Text = "Stoppen";
            this.Stoppen.UseVisualStyleBackColor = true;
            this.Stoppen.Click += new System.EventHandler(this.Stoppen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(373, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ones: 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Twos: 0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(365, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Threes: 0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(373, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Sixes: 0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(373, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Fives: 0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(372, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Fours: 0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(365, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "ScoreBoard";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Stoppen);
            this.Controls.Add(this.UserRollsDisplay);
            this.Controls.Add(this.Btn_RollDice);
            this.Controls.Add(this.Dice1);
            this.Controls.Add(this.Dice5);
            this.Controls.Add(this.Dice4);
            this.Controls.Add(this.Dice3);
            this.Controls.Add(this.Dice2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.Button Stoppen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

