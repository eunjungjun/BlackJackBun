namespace BlackJackFinal
{
    partial class BlackJack
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
            this.playerLabel = new System.Windows.Forms.Label();
            this.bankLabel = new System.Windows.Forms.Label();
            this.bankTextbox = new System.Windows.Forms.TextBox();
            this.betLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.betTextbox = new System.Windows.Forms.TextBox();
            this.playAgain = new System.Windows.Forms.Button();
            this.playerCard1 = new System.Windows.Forms.PictureBox();
            this.playerCard2 = new System.Windows.Forms.PictureBox();
            this.playerCard3 = new System.Windows.Forms.PictureBox();
            this.playerCard4 = new System.Windows.Forms.PictureBox();
            this.playerCard5 = new System.Windows.Forms.PictureBox();
            this.houseCard1 = new System.Windows.Forms.PictureBox();
            this.houseCard2 = new System.Windows.Forms.PictureBox();
            this.houseCard3 = new System.Windows.Forms.PictureBox();
            this.houseCard4 = new System.Windows.Forms.PictureBox();
            this.houseCard5 = new System.Windows.Forms.PictureBox();
            this.dealButton = new System.Windows.Forms.Button();
            this.hitButton = new System.Windows.Forms.Button();
            this.stayButton = new System.Windows.Forms.Button();
            this.houseLabel = new System.Windows.Forms.Label();
            this.playerScoreLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.houseScoreLabel = new System.Windows.Forms.Label();
            this.playerScore = new System.Windows.Forms.TextBox();
            this.resultTextbox = new System.Windows.Forms.TextBox();
            this.houseScore = new System.Windows.Forms.TextBox();
            this.pauseButton = new System.Windows.Forms.Button();
            this.bunnyPicture = new System.Windows.Forms.PictureBox();
            this.textCloud = new System.Windows.Forms.PictureBox();
            this.bunnyChat = new System.Windows.Forms.TextBox();
            this.goodBye = new System.Windows.Forms.Button();
            this.bunnyPictureFinal = new System.Windows.Forms.PictureBox();
            this.endingPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseCard5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunnyPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCloud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunnyPictureFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endingPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // playerLabel
            // 
            this.playerLabel.AutoSize = true;
            this.playerLabel.BackColor = System.Drawing.Color.Transparent;
            this.playerLabel.ForeColor = System.Drawing.Color.Snow;
            this.playerLabel.Location = new System.Drawing.Point(34, 14);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(36, 13);
            this.playerLabel.TabIndex = 0;
            this.playerLabel.Text = "Player";
            // 
            // bankLabel
            // 
            this.bankLabel.AutoSize = true;
            this.bankLabel.BackColor = System.Drawing.Color.Transparent;
            this.bankLabel.ForeColor = System.Drawing.Color.Snow;
            this.bankLabel.Location = new System.Drawing.Point(142, 14);
            this.bankLabel.Name = "bankLabel";
            this.bankLabel.Size = new System.Drawing.Size(35, 13);
            this.bankLabel.TabIndex = 1;
            this.bankLabel.Text = "Bank:";
            // 
            // bankTextbox
            // 
            this.bankTextbox.Location = new System.Drawing.Point(183, 11);
            this.bankTextbox.Name = "bankTextbox";
            this.bankTextbox.ReadOnly = true;
            this.bankTextbox.Size = new System.Drawing.Size(100, 20);
            this.bankTextbox.TabIndex = 2;
            // 
            // betLabel
            // 
            this.betLabel.AutoSize = true;
            this.betLabel.BackColor = System.Drawing.Color.Transparent;
            this.betLabel.ForeColor = System.Drawing.Color.Snow;
            this.betLabel.Location = new System.Drawing.Point(307, 14);
            this.betLabel.Name = "betLabel";
            this.betLabel.Size = new System.Drawing.Size(26, 13);
            this.betLabel.TabIndex = 3;
            this.betLabel.Text = "Bet:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(378, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(0, 20);
            this.textBox1.TabIndex = 4;
            // 
            // betTextbox
            // 
            this.betTextbox.Location = new System.Drawing.Point(339, 11);
            this.betTextbox.Name = "betTextbox";
            this.betTextbox.Size = new System.Drawing.Size(100, 20);
            this.betTextbox.TabIndex = 5;
            // 
            // playAgain
            // 
            this.playAgain.ForeColor = System.Drawing.Color.Black;
            this.playAgain.Location = new System.Drawing.Point(532, 12);
            this.playAgain.Name = "playAgain";
            this.playAgain.Size = new System.Drawing.Size(75, 23);
            this.playAgain.TabIndex = 6;
            this.playAgain.Text = "Play Again?";
            this.playAgain.UseVisualStyleBackColor = true;
            this.playAgain.Visible = false;
            this.playAgain.Click += new System.EventHandler(this.playAgain_Click);
            // 
            // playerCard1
            // 
            this.playerCard1.BackColor = System.Drawing.Color.Transparent;
            this.playerCard1.Location = new System.Drawing.Point(12, 49);
            this.playerCard1.Name = "playerCard1";
            this.playerCard1.Size = new System.Drawing.Size(80, 100);
            this.playerCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerCard1.TabIndex = 7;
            this.playerCard1.TabStop = false;
            this.playerCard1.Visible = false;
            // 
            // playerCard2
            // 
            this.playerCard2.BackColor = System.Drawing.Color.Transparent;
            this.playerCard2.Location = new System.Drawing.Point(137, 49);
            this.playerCard2.Name = "playerCard2";
            this.playerCard2.Size = new System.Drawing.Size(80, 100);
            this.playerCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerCard2.TabIndex = 8;
            this.playerCard2.TabStop = false;
            this.playerCard2.Visible = false;
            // 
            // playerCard3
            // 
            this.playerCard3.BackColor = System.Drawing.Color.Transparent;
            this.playerCard3.Location = new System.Drawing.Point(262, 49);
            this.playerCard3.Name = "playerCard3";
            this.playerCard3.Size = new System.Drawing.Size(80, 100);
            this.playerCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerCard3.TabIndex = 9;
            this.playerCard3.TabStop = false;
            this.playerCard3.Visible = false;
            // 
            // playerCard4
            // 
            this.playerCard4.BackColor = System.Drawing.Color.Transparent;
            this.playerCard4.Location = new System.Drawing.Point(387, 49);
            this.playerCard4.Name = "playerCard4";
            this.playerCard4.Size = new System.Drawing.Size(80, 100);
            this.playerCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerCard4.TabIndex = 10;
            this.playerCard4.TabStop = false;
            this.playerCard4.Visible = false;
            // 
            // playerCard5
            // 
            this.playerCard5.BackColor = System.Drawing.Color.Transparent;
            this.playerCard5.Location = new System.Drawing.Point(512, 49);
            this.playerCard5.Name = "playerCard5";
            this.playerCard5.Size = new System.Drawing.Size(80, 100);
            this.playerCard5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerCard5.TabIndex = 11;
            this.playerCard5.TabStop = false;
            this.playerCard5.Visible = false;
            // 
            // houseCard1
            // 
            this.houseCard1.BackColor = System.Drawing.Color.Transparent;
            this.houseCard1.Location = new System.Drawing.Point(12, 350);
            this.houseCard1.Name = "houseCard1";
            this.houseCard1.Size = new System.Drawing.Size(80, 100);
            this.houseCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.houseCard1.TabIndex = 12;
            this.houseCard1.TabStop = false;
            this.houseCard1.Visible = false;
            // 
            // houseCard2
            // 
            this.houseCard2.BackColor = System.Drawing.Color.Transparent;
            this.houseCard2.Location = new System.Drawing.Point(137, 350);
            this.houseCard2.Name = "houseCard2";
            this.houseCard2.Size = new System.Drawing.Size(80, 100);
            this.houseCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.houseCard2.TabIndex = 13;
            this.houseCard2.TabStop = false;
            this.houseCard2.Visible = false;
            // 
            // houseCard3
            // 
            this.houseCard3.BackColor = System.Drawing.Color.Transparent;
            this.houseCard3.Location = new System.Drawing.Point(262, 350);
            this.houseCard3.Name = "houseCard3";
            this.houseCard3.Size = new System.Drawing.Size(80, 100);
            this.houseCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.houseCard3.TabIndex = 14;
            this.houseCard3.TabStop = false;
            this.houseCard3.Visible = false;
            // 
            // houseCard4
            // 
            this.houseCard4.BackColor = System.Drawing.Color.Transparent;
            this.houseCard4.Location = new System.Drawing.Point(387, 350);
            this.houseCard4.Name = "houseCard4";
            this.houseCard4.Size = new System.Drawing.Size(80, 100);
            this.houseCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.houseCard4.TabIndex = 15;
            this.houseCard4.TabStop = false;
            this.houseCard4.Visible = false;
            // 
            // houseCard5
            // 
            this.houseCard5.BackColor = System.Drawing.Color.Transparent;
            this.houseCard5.Location = new System.Drawing.Point(512, 350);
            this.houseCard5.Name = "houseCard5";
            this.houseCard5.Size = new System.Drawing.Size(80, 100);
            this.houseCard5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.houseCard5.TabIndex = 16;
            this.houseCard5.TabStop = false;
            this.houseCard5.Visible = false;
            // 
            // dealButton
            // 
            this.dealButton.ForeColor = System.Drawing.Color.Black;
            this.dealButton.Location = new System.Drawing.Point(15, 169);
            this.dealButton.Name = "dealButton";
            this.dealButton.Size = new System.Drawing.Size(75, 23);
            this.dealButton.TabIndex = 17;
            this.dealButton.Text = "Deal";
            this.dealButton.UseVisualStyleBackColor = true;
            this.dealButton.Click += new System.EventHandler(this.dealButton_Click);
            // 
            // hitButton
            // 
            this.hitButton.Enabled = false;
            this.hitButton.ForeColor = System.Drawing.Color.Black;
            this.hitButton.Location = new System.Drawing.Point(15, 220);
            this.hitButton.Name = "hitButton";
            this.hitButton.Size = new System.Drawing.Size(75, 23);
            this.hitButton.TabIndex = 18;
            this.hitButton.Text = "Hit";
            this.hitButton.UseVisualStyleBackColor = true;
            this.hitButton.Click += new System.EventHandler(this.hitButton_Click);
            // 
            // stayButton
            // 
            this.stayButton.Enabled = false;
            this.stayButton.ForeColor = System.Drawing.Color.Black;
            this.stayButton.Location = new System.Drawing.Point(15, 271);
            this.stayButton.Name = "stayButton";
            this.stayButton.Size = new System.Drawing.Size(75, 23);
            this.stayButton.TabIndex = 19;
            this.stayButton.Text = "Stay";
            this.stayButton.UseVisualStyleBackColor = true;
            this.stayButton.Click += new System.EventHandler(this.stayButton_Click);
            // 
            // houseLabel
            // 
            this.houseLabel.AutoSize = true;
            this.houseLabel.BackColor = System.Drawing.Color.Transparent;
            this.houseLabel.ForeColor = System.Drawing.Color.Snow;
            this.houseLabel.Location = new System.Drawing.Point(33, 315);
            this.houseLabel.Name = "houseLabel";
            this.houseLabel.Size = new System.Drawing.Size(37, 13);
            this.houseLabel.TabIndex = 20;
            this.houseLabel.Text = "Bunny";
            // 
            // playerScoreLabel
            // 
            this.playerScoreLabel.AutoSize = true;
            this.playerScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.playerScoreLabel.ForeColor = System.Drawing.Color.Snow;
            this.playerScoreLabel.Location = new System.Drawing.Point(107, 174);
            this.playerScoreLabel.Name = "playerScoreLabel";
            this.playerScoreLabel.Size = new System.Drawing.Size(70, 13);
            this.playerScoreLabel.TabIndex = 21;
            this.playerScoreLabel.Text = "Player Score:";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.BackColor = System.Drawing.Color.Transparent;
            this.resultLabel.ForeColor = System.Drawing.Color.Snow;
            this.resultLabel.Location = new System.Drawing.Point(137, 225);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(40, 13);
            this.resultLabel.TabIndex = 22;
            this.resultLabel.Text = "Result:";
            // 
            // houseScoreLabel
            // 
            this.houseScoreLabel.AutoSize = true;
            this.houseScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.houseScoreLabel.ForeColor = System.Drawing.Color.Snow;
            this.houseScoreLabel.Location = new System.Drawing.Point(107, 315);
            this.houseScoreLabel.Name = "houseScoreLabel";
            this.houseScoreLabel.Size = new System.Drawing.Size(71, 13);
            this.houseScoreLabel.TabIndex = 23;
            this.houseScoreLabel.Text = "Bunny Score:";
            // 
            // playerScore
            // 
            this.playerScore.Location = new System.Drawing.Point(183, 171);
            this.playerScore.Name = "playerScore";
            this.playerScore.ReadOnly = true;
            this.playerScore.Size = new System.Drawing.Size(100, 20);
            this.playerScore.TabIndex = 24;
            // 
            // resultTextbox
            // 
            this.resultTextbox.Location = new System.Drawing.Point(183, 222);
            this.resultTextbox.Name = "resultTextbox";
            this.resultTextbox.ReadOnly = true;
            this.resultTextbox.Size = new System.Drawing.Size(100, 20);
            this.resultTextbox.TabIndex = 25;
            // 
            // houseScore
            // 
            this.houseScore.Location = new System.Drawing.Point(183, 312);
            this.houseScore.Name = "houseScore";
            this.houseScore.ReadOnly = true;
            this.houseScore.Size = new System.Drawing.Size(100, 20);
            this.houseScore.TabIndex = 26;
            // 
            // pauseButton
            // 
            this.pauseButton.ForeColor = System.Drawing.Color.Black;
            this.pauseButton.Location = new System.Drawing.Point(517, 164);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(90, 23);
            this.pauseButton.TabIndex = 27;
            this.pauseButton.Text = "Pause Music";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // bunnyPicture
            // 
            this.bunnyPicture.BackColor = System.Drawing.Color.Transparent;
            this.bunnyPicture.BackgroundImage = global::BlackJackFinal.Properties.Resources.Bunny;
            this.bunnyPicture.Location = new System.Drawing.Point(289, 182);
            this.bunnyPicture.Name = "bunnyPicture";
            this.bunnyPicture.Size = new System.Drawing.Size(125, 150);
            this.bunnyPicture.TabIndex = 28;
            this.bunnyPicture.TabStop = false;
            this.bunnyPicture.Click += new System.EventHandler(this.bunnyPicture_Click);
            // 
            // textCloud
            // 
            this.textCloud.BackColor = System.Drawing.Color.Transparent;
            this.textCloud.BackgroundImage = global::BlackJackFinal.Properties.Resources.Textbox;
            this.textCloud.Location = new System.Drawing.Point(410, 193);
            this.textCloud.Name = "textCloud";
            this.textCloud.Size = new System.Drawing.Size(170, 85);
            this.textCloud.TabIndex = 30;
            this.textCloud.TabStop = false;
            // 
            // bunnyChat
            // 
            this.bunnyChat.BackColor = System.Drawing.Color.White;
            this.bunnyChat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunnyChat.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunnyChat.Location = new System.Drawing.Point(423, 203);
            this.bunnyChat.Multiline = true;
            this.bunnyChat.Name = "bunnyChat";
            this.bunnyChat.ReadOnly = true;
            this.bunnyChat.Size = new System.Drawing.Size(150, 65);
            this.bunnyChat.TabIndex = 31;
            this.bunnyChat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // goodBye
            // 
            this.goodBye.ForeColor = System.Drawing.Color.Black;
            this.goodBye.Location = new System.Drawing.Point(517, 305);
            this.goodBye.Name = "goodBye";
            this.goodBye.Size = new System.Drawing.Size(90, 23);
            this.goodBye.TabIndex = 32;
            this.goodBye.Text = "Say Goodbye";
            this.goodBye.UseVisualStyleBackColor = true;
            this.goodBye.Visible = false;
            this.goodBye.Click += new System.EventHandler(this.goodBye_Click);
            // 
            // bunnyPictureFinal
            // 
            this.bunnyPictureFinal.BackColor = System.Drawing.Color.Transparent;
            this.bunnyPictureFinal.BackgroundImage = global::BlackJackFinal.Properties.Resources.SadBunny4;
            this.bunnyPictureFinal.Location = new System.Drawing.Point(289, 182);
            this.bunnyPictureFinal.Name = "bunnyPictureFinal";
            this.bunnyPictureFinal.Size = new System.Drawing.Size(125, 150);
            this.bunnyPictureFinal.TabIndex = 33;
            this.bunnyPictureFinal.TabStop = false;
            this.bunnyPictureFinal.Visible = false;
            // 
            // endingPicture
            // 
            this.endingPicture.BackColor = System.Drawing.Color.Transparent;
            this.endingPicture.BackgroundImage = global::BlackJackFinal.Properties.Resources.BunnyEnding;
            this.endingPicture.Location = new System.Drawing.Point(496, 423);
            this.endingPicture.Name = "endingPicture";
            this.endingPicture.Size = new System.Drawing.Size(635, 506);
            this.endingPicture.TabIndex = 34;
            this.endingPicture.TabStop = false;
            this.endingPicture.Visible = false;
            // 
            // BlackJack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BlackJackFinal.Properties.Resources.SkyBackgroundFinal;
            this.ClientSize = new System.Drawing.Size(619, 468);
            this.Controls.Add(this.endingPicture);
            this.Controls.Add(this.bunnyPictureFinal);
            this.Controls.Add(this.goodBye);
            this.Controls.Add(this.bunnyChat);
            this.Controls.Add(this.textCloud);
            this.Controls.Add(this.bunnyPicture);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.houseScore);
            this.Controls.Add(this.resultTextbox);
            this.Controls.Add(this.playerScore);
            this.Controls.Add(this.houseScoreLabel);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.playerScoreLabel);
            this.Controls.Add(this.houseLabel);
            this.Controls.Add(this.stayButton);
            this.Controls.Add(this.hitButton);
            this.Controls.Add(this.dealButton);
            this.Controls.Add(this.houseCard5);
            this.Controls.Add(this.houseCard4);
            this.Controls.Add(this.houseCard3);
            this.Controls.Add(this.houseCard2);
            this.Controls.Add(this.houseCard1);
            this.Controls.Add(this.playerCard5);
            this.Controls.Add(this.playerCard4);
            this.Controls.Add(this.playerCard3);
            this.Controls.Add(this.playerCard2);
            this.Controls.Add(this.playerCard1);
            this.Controls.Add(this.playAgain);
            this.Controls.Add(this.betTextbox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.betLabel);
            this.Controls.Add(this.bankTextbox);
            this.Controls.Add(this.bankLabel);
            this.Controls.Add(this.playerLabel);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BlackJack";
            this.Text = "BlackJack";
            this.Load += new System.EventHandler(this.BlackJack_Load);
            ((System.ComponentModel.ISupportInitialize)(this.playerCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseCard5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunnyPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCloud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunnyPictureFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endingPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.Label bankLabel;
        private System.Windows.Forms.TextBox bankTextbox;
        private System.Windows.Forms.Label betLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox betTextbox;
        private System.Windows.Forms.Button playAgain;
        private System.Windows.Forms.PictureBox playerCard1;
        private System.Windows.Forms.PictureBox playerCard2;
        private System.Windows.Forms.PictureBox playerCard3;
        private System.Windows.Forms.PictureBox playerCard4;
        private System.Windows.Forms.PictureBox playerCard5;
        private System.Windows.Forms.PictureBox houseCard1;
        private System.Windows.Forms.PictureBox houseCard2;
        private System.Windows.Forms.PictureBox houseCard3;
        private System.Windows.Forms.PictureBox houseCard4;
        private System.Windows.Forms.PictureBox houseCard5;
        private System.Windows.Forms.Button dealButton;
        private System.Windows.Forms.Button hitButton;
        private System.Windows.Forms.Button stayButton;
        private System.Windows.Forms.Label houseLabel;
        private System.Windows.Forms.Label playerScoreLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label houseScoreLabel;
        private System.Windows.Forms.TextBox playerScore;
        private System.Windows.Forms.TextBox resultTextbox;
        private System.Windows.Forms.TextBox houseScore;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.PictureBox bunnyPicture;
        private System.Windows.Forms.PictureBox textCloud;
        private System.Windows.Forms.TextBox bunnyChat;
        private System.Windows.Forms.Button goodBye;
        private System.Windows.Forms.PictureBox bunnyPictureFinal;
        private System.Windows.Forms.PictureBox endingPicture;
    }
}

