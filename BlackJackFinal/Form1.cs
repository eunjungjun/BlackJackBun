using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJackFinal
{
    public partial class BlackJack : Form
    {
        // Initialization of variables, booleans
        int[] deckAsInts = new int[52];
        int[] deckValues = { 999, 1,1,1,1, 10,10,10,10, 10,10,10,10, 10,10,10,10 ,10,10,10,10,
                           9,9,9,9, 8,8,8,8, 7,7,7,7 ,6,6,6,6, 5,5,5,5, 4,4,4,4, 3,3,3,3, 2,2,2,2};

        //List of possible Bunny chats
        string[] bunnyChats = {"It gets kind of lonely up here...", "Where did everyone go?", "Stars are pretty but also wistful...", "I've never seen the sun...",
            "Will morning come soon?", "You'll keep playing with me, right?", "Huh? What's my name? ...I don't have one...", "...", "Sorry, did you say something?", 
            "Before you came here, it was so quiet...", "Every game has to end...", "My ear? What about it?", "You...are real, right?", "You don't have to leave yet, right?", 

            "Aren't the stars pretty?", "Before I go to sleep, I always admire the moon.", "I'm having so much fun with you!", "Huh? How are we floating in the sky? No clue!", 
            "Isn't this fun?", "Hey, hey! Tell me more about where you came from!", "Where's the music coming from? What're you talking about?",
            "I'm pretty good at shuffling, right?", "♪La~la~la♫♩Tee hee!", "Sing with me!", "Thank you for being here with me!", "Don't worry about me! Just have fun!", 
            "If you tell me a secret, I'll tell you one of mine!", "I'm so glad to have made a new friend!", 

            "No, I don't eat carrots! Who told you that?!", "I'll definitely be the king of Blackjack!", "Here we go!!", "Don't blame me if you lose all your money!",
            "Hey! My tail is off limits!", 
            };

        static Random _random = new Random();

        int nextCard = 0;
        int nextChat = 0;

        int playerCardCount = 0;
        int playerHandValue = 0;

        int houseCardCount = 0;
        int houseHandValue = 0;
        int houseHiddenCard = 0;

        int bank = 500;
        int bet = 10;

        int byeCount = 0;

        Boolean playerAce = false;
        Boolean houseAce = false;
        Boolean paused = false;

        public BlackJack()
        {
            InitializeComponent();

            bankTextbox.Text = bank.ToString();
            betTextbox.Text = bet.ToString();
            bunnyChat.Text = "Hi there! Have you come to play some BlackJack with me?";

            //Set up deck
            for (int i = 0; i < 52; i++)
            {
                deckAsInts[i] = i + 1;
            }

            Shuffle(deckAsInts);
        }
        public static void Shuffle<T>(T[] array)
        {
            var random = _random;
            for (int i = array.Length; i > 1; i--)
            {
                int j = random.Next(i);

                T tmp = array[j];
                array[j] = array[i - 1];
                array[i - 1] = tmp;
            }
        }

        private void dealButton_Click(object sender, EventArgs e)
        {
            bunnyConvo();

            //Clear results & cards
            resultTextbox.Text = "";
            betTextbox.ReadOnly = true;

            playerCard1.Hide();
            playerCard2.Hide();
            playerCard3.Hide();
            playerCard4.Hide();
            playerCard5.Hide();

            houseCard1.Hide();
            houseCard2.Hide();
            houseCard3.Hide();
            houseCard4.Hide();
            houseCard5.Hide();

            //Catching errors regarding bank & bet
            try
            {
                bet = Convert.ToInt32(betTextbox.Text);
            }
            catch
            {
                bunnyChat.Text = "I can't do math with that!";
                bunnyPicture.Image = BlackJackFinal.Properties.Resources.AngryBunny;
                return;
            }

            if (bet > bank)
            {
                bunnyChat.Text = "You don't have that much, silly!";
                bunnyPicture.Image = BlackJackFinal.Properties.Resources.Bunny;
                return;
            }

            if (nextCard > 45)
            {
                nextCard = 0; // reset the point to the next card in the deck
                Shuffle(deckAsInts); // reshuffle the deck
            }

            // Player Card 1
            int nextCardIndex = deckAsInts[nextCard];
            playerCard1.Show();
            playerCard1.Load("classic-cards\\" + nextCardIndex + ".png");

            playerHandValue += deckValues[nextCardIndex];
            playerCardCount++;
            nextCard++;

            if (deckValues[nextCardIndex] == 1)
            {
                playerAce = true;
            }

            //Player Card 2
            nextCardIndex = deckAsInts[nextCard];
            playerCard2.Show();
            playerCard2.Load("classic-cards\\" + nextCardIndex + ".png");

            playerHandValue += deckValues[nextCardIndex];
            playerCardCount++;
            nextCard++;


            if (deckValues[nextCardIndex] == 1)
            {
                playerAce = true;
            }

            //House Card 1
            nextCardIndex = deckAsInts[nextCard];
            houseCard1.Show();
            houseCard1.Load("classic-cards\\" + nextCardIndex + ".png");

            houseHandValue += deckValues[nextCardIndex];
            houseCardCount++;
            nextCard++;
            houseScore.Text = houseHandValue.ToString();

            if (deckValues[nextCardIndex] == 1)
            {
                houseAce = true;
            }

            //Hidden House Card 2
            nextCardIndex = deckAsInts[nextCard];
            houseHiddenCard = nextCardIndex;
            houseCard2.Show();
            houseCard2.Load("classic-cards\\b1fv.png");

            houseCardCount++;
            nextCard++;

            if (deckValues[nextCardIndex] == 1)
            {
                houseAce = true;
            }

            //Enabling, disabling of buttons
            dealButton.Enabled = false;
            hitButton.Enabled = true;
            stayButton.Enabled = true;

            //Calls method for Aces, updates score in score textbox for player
            int tempPlayerHandValue = updateForAce(playerHandValue, playerAce);

            if (playerAce == false)
            {
                playerScore.Text = playerHandValue.ToString();
            }

            if (playerAce == true)
            {
                playerScore.Text = tempPlayerHandValue.ToString();
            }

            //Calls method for Aces, updates score in score textbox for house
            int tempHouseHandValue = updateForAce(houseHandValue, houseAce);

            if (houseAce == false)
            {
                houseScore.Text = houseHandValue.ToString();
            }

            if (houseAce == true)
            {
                houseScore.Text = tempHouseHandValue.ToString();
            }

            // Possible win for player here
            if (tempPlayerHandValue == 21)
            {
                playerCardCount = 0;
                playerHandValue = 0;

                houseCardCount = 0;
                houseHandValue = 0;
                houseHiddenCard = 0;

                playerAce = false;
                houseAce = false;

                bank += bet;
                bankTextbox.Text = bank.ToString();
                resultTextbox.Text = "You win!";

                betTextbox.ReadOnly = false;
                dealButton.Enabled = true;
                hitButton.Enabled = false;
                stayButton.Enabled = false;

                if (bank >= 490)
                {
                    goodBye.Visible = true;
                }
            }
        }

        private void hitButton_Click(object sender, EventArgs e)
        {
            bunnyConvo();

            int nextCardIndex = deckAsInts[nextCard];

            playerHandValue += deckValues[nextCardIndex];
            playerCardCount++;
            nextCard++;

            //Disables hit once player reaches 5 cards
            if (playerCardCount == 5)
            {
                hitButton.Enabled = false;
            }

            if (deckValues[nextCardIndex] == 1)
            {
                playerAce = true;
            }

            //Calls method for Aces, updates score in score textbox for player
            int tempPlayerHandValue = updateForAce(playerHandValue, playerAce);

            switch (playerCardCount)
            {
                case 3:
                    playerCard3.Show();
                    playerCard3.Load("classic-cards\\" + nextCardIndex + ".png");
                    break;
                case 4:
                    playerCard4.Show();
                    playerCard4.Load("classic-cards\\" + nextCardIndex + ".png");
                    break;
                case 5:
                    playerCard5.Show();
                    playerCard5.Load("classic-cards\\" + nextCardIndex + ".png");
                    break;
            }

            if (playerAce == false)
            {
                playerScore.Text = playerHandValue.ToString();
            }

            if (playerAce == true)
            {
                playerScore.Text = tempPlayerHandValue.ToString();
            }

            //Possible win or loss for player here
            if (tempPlayerHandValue == 21)
            {
                playerCardCount = 0;
                playerHandValue = 0;

                houseCardCount = 0;
                houseHandValue = 0;
                houseHiddenCard = 0;

                playerAce = false;
                houseAce = false;

                bank += bet;
                bankTextbox.Text = bank.ToString();
                resultTextbox.Text = "You win!";

                betTextbox.ReadOnly = false;
                dealButton.Enabled = true;
                hitButton.Enabled = false;
                stayButton.Enabled = false;

                if (bank >= 490)
                {
                    goodBye.Visible = true;
                }
            }

            if (tempPlayerHandValue > 21)
            {
                playerCardCount = 0;
                playerHandValue = 0;

                houseCardCount = 0;
                houseHandValue = 0;
                houseHiddenCard = 0;

                playerAce = false;
                houseAce = false;

                bank = bank - bet;
                bankTextbox.Text = bank.ToString();
                resultTextbox.Text = "You lose!";

                betTextbox.ReadOnly = false;
                dealButton.Enabled = true;
                hitButton.Enabled = false;
                stayButton.Enabled = false;

                if (bank >= 490)
                {
                    goodBye.Visible = true;
                }
            }
        }

        private void stayButton_Click(object sender, EventArgs e)
        {
            bunnyConvo();

            // Show hidden house card
            houseHandValue = houseHandValue + deckValues[houseHiddenCard];
            houseCard2.Load("classic-cards\\" + houseHiddenCard + ".png");

            int tempHouseHandValue = updateForAce(houseHandValue, houseAce);

            hitButton.Enabled = false;
            stayButton.Enabled = false;

            if (tempHouseHandValue == 21)
            {
                houseScore.Text = tempHouseHandValue.ToString();
                playerCardCount = 0;
                playerHandValue = 0;

                houseCardCount = 0;
                houseHandValue = 0;
                houseHiddenCard = 0;

                playerAce = false;
                houseAce = false;

                bank = bank - bet;
                bankTextbox.Text = bank.ToString();
                resultTextbox.Text = "You lose!";

                betTextbox.ReadOnly = false;
                dealButton.Enabled = true;
                hitButton.Enabled = false;
                stayButton.Enabled = false;
                return;
            }

            //Determines if house gets more cards or not
            while (houseHandValue < 17 || tempHouseHandValue < 17)
            {
                int nextCardIndex = deckAsInts[nextCard];
                houseCardCount++;

                if (deckValues[nextCardIndex] == 1)
                {
                    houseAce = true;
                }

                switch (houseCardCount)
                {
                    case 3:
                        houseCard3.Show();
                        houseCard3.Load("classic-cards\\" + nextCardIndex + ".png");
                        break;

                    case 4:
                        houseCard4.Show();
                        houseCard4.Load("classic-cards\\" + nextCardIndex + ".png");
                        break;

                    case 5:
                        houseCard5.Show();
                        houseCard5.Load("classic-cards\\" + nextCardIndex + ".png");
                        break;
                }

                houseHandValue = houseHandValue + deckValues[nextCardIndex];
                tempHouseHandValue = updateForAce(houseHandValue, houseAce);
                nextCard++;
            }

            if (houseAce == false)
            {
                houseScore.Text = houseHandValue.ToString();
            }

            if (houseAce == true)
            {
                houseScore.Text = tempHouseHandValue.ToString();
            }

            //Determines who wins between player and house
            int finalplayerScore = Convert.ToInt32(playerScore.Text);
            int finalhouseScore = Convert.ToInt32(houseScore.Text);

            if (finalplayerScore <= 21 && finalplayerScore > finalhouseScore)
            {
                playerCardCount = 0;
                playerHandValue = 0;

                houseCardCount = 0;
                houseHandValue = 0;
                houseHiddenCard = 0;

                playerAce = false;
                houseAce = false;

                bank += bet;
                bankTextbox.Text = bank.ToString();
                resultTextbox.Text = "You win!";

                betTextbox.ReadOnly = false;
                dealButton.Enabled = true;
                hitButton.Enabled = false;
                stayButton.Enabled = false;

                if (bank >= 490)
                {
                    goodBye.Visible = true;
                }
            }

            if (finalhouseScore <= 21 && finalplayerScore <= finalhouseScore)
            {
                playerCardCount = 0;
                playerHandValue = 0;

                houseCardCount = 0;
                houseHandValue = 0;
                houseHiddenCard = 0;

                playerAce = false;
                houseAce = false;

                bank = bank - bet;
                bankTextbox.Text = bank.ToString();
                resultTextbox.Text = "You lose!";

                betTextbox.ReadOnly = false;
                dealButton.Enabled = true;
                hitButton.Enabled = false;
                stayButton.Enabled = false;

                if (bank >= 490)
                {
                    goodBye.Visible = true;
                }
            }

            if (finalhouseScore > 21)
            {
                playerCardCount = 0;
                playerHandValue = 0;

                houseCardCount = 0;
                houseHandValue = 0;
                houseHiddenCard = 0;

                playerAce = false;
                houseAce = false;

                bank += bet;
                bankTextbox.Text = bank.ToString();
                resultTextbox.Text = "You win!";

                betTextbox.ReadOnly = false;
                dealButton.Enabled = true;
                hitButton.Enabled = false;
                stayButton.Enabled = false;

                if (bank >= 490)
                {
                    goodBye.Visible = true;
                }
            }
        }
        
        //Restart the game, reset all variables to default
        private void playAgain_Click(object sender, EventArgs e)
        {
            bank = 500;
            bankTextbox.Text = bank.ToString();
            bet = 10;
            betTextbox.Text = bet.ToString();

            nextCard = 0;
            Shuffle(deckAsInts);
            playerCardCount = 0;
            playerHandValue = 0;
            playerScore.Text = "";
            resultTextbox.Text = "";

            houseCardCount = 0;
            houseHandValue = 0;
            houseHiddenCard = 0;
            houseScore.Text = "";

            goodBye.Text = "Say Goodbye";
            byeCount = 0;

            playerAce = false;
            houseAce = false;
            dealButton.Enabled = true;
            betTextbox.ReadOnly = false;

            endingPicture.Visible = false;
            bunnyPicture.Visible = true;
            bunnyPicture.Image = BlackJackFinal.Properties.Resources.Bunny;
            bunnyChat.Text = "Hi there! Have we met somewhere before?";
            bunnyPictureFinal.Visible = false;

            playerCard1.Hide();
            playerCard2.Hide();
            playerCard3.Hide();
            playerCard4.Hide();
            playerCard5.Hide();

            houseCard1.Hide();
            houseCard2.Hide();
            houseCard3.Hide();
            houseCard4.Hide();
            houseCard5.Hide();

            playAgain.Visible = false;
        }
        // Method for determining if Aces should be 1 or 11
        private int updateForAce(int handValue, Boolean hasAce)
        {
            if (hasAce)
            {
                if ((handValue + 10) <= 21)
                    return handValue + 10;
            }
            return handValue;
        }

        //Method for determining Bunny's text
        private void bunnyConvo()
        {
            Random randomGen = new Random();
            nextChat = randomGen.Next(0, 33);
            bunnyChat.Text = bunnyChats[nextChat];

            if (nextChat >= 0 && nextChat <= 13)
            {
                bunnyPicture.Image = BlackJackFinal.Properties.Resources.SadBunny;
            }
            if (nextChat >= 14 && nextChat <= 27)
            {
                bunnyPicture.Image = BlackJackFinal.Properties.Resources.Bunny;
            }
            if (nextChat >= 28 && nextChat <= 32)
            {
                bunnyPicture.Image = BlackJackFinal.Properties.Resources.AngryBunny;
            }
        }

        //For playing music
        private void playaudio()
        {
            System.Media.SoundPlayer contLife = new System.Media.SoundPlayer(BlackJackFinal.Properties.Resources.Continue_Life);
            contLife.PlayLooping();
        }

        private void BlackJack_Load(object sender, EventArgs e)
        {
            playaudio();
        }

        //For stopping and starting music
        private void pauseButton_Click(object sender, EventArgs e)
        {

            if (paused == false)
            {
                System.Media.SoundPlayer contLife = new System.Media.SoundPlayer(BlackJackFinal.Properties.Resources.Continue_Life);
                pauseButton.Text = "Unpause Music";
                contLife.Stop();
                paused = true;
                return;
            }

            if (paused == true)
            {
                System.Media.SoundPlayer contLife = new System.Media.SoundPlayer(BlackJackFinal.Properties.Resources.Continue_Life);
                pauseButton.Text = "Pause Music";
                contLife.PlayLooping();
                paused = false;
                return;
            }
        }

        private void bunnyPicture_Click(object sender, EventArgs e)
        {
            bunnyPicture.Image = BlackJackFinal.Properties.Resources.Bunny;
            bunnyChat.Text = "Hey, that tickles!";
        }

        //How to end the game
        private void goodBye_Click(object sender, EventArgs e)
        {
            dealButton.Enabled = false;
            hitButton.Enabled = false;
            stayButton.Enabled = false;

            switch(byeCount)
            {
                case 0:
                    bunnyPicture.Image = BlackJackFinal.Properties.Resources.SadBunny;
                    bunnyChat.Text = "Wait, are you leaving?";
                    goodBye.Text = "Yes.";
                    byeCount++;
                    return;

                case 1:
                    bunnyPicture.Image = BlackJackFinal.Properties.Resources.SadBunny2;
                    bunnyChat.Text = "But, you're the only one I have to play with...";
                    goodBye.Text = "I'm sorry.";
                    byeCount++;
                    return;

                case 2:
                    bunnyPicture.Image = BlackJackFinal.Properties.Resources.SadBunny3;
                    bunnyChat.Text = "Wh-Who will see the sunrise with me?";
                    goodBye.Text = "...";
                    byeCount++;
                    return;

                case 3:
                    bunnyPicture.Visible = false;
                    bunnyPictureFinal.Visible = true;
                    bunnyChat.Text = "...G-goodbye, friend...";
                    goodBye.Text = "Farewell...";
                    byeCount++;
                    return;

                case 4:
                    bunnyPictureFinal.Visible = false;
                    goodBye.Visible = false;
                    playAgain.Visible = true;
                    playAgain.BringToFront();
                    endingPicture.Location = new Point(0, 0);
                    endingPicture.Visible = true;
                    return;

            }
        }
    }
}
