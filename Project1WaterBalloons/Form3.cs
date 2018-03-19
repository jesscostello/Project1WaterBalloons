using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1WaterBalloons
{
    public partial class Form3 : Form
    {
        private int RdmNum;
        private int Counter = 6;
        private bool dodgeButton = false;
        private int Dodges = 2;
        private int Wins = 0;
        private int Losses = 0;

        public Form3()
        {
            InitializeComponent();
        }
        // generate random number - complete
        // line up balloons button enabled
        // wins / losses
        private void btnFill_Click(object sender, EventArgs e)
        {
            // generate random number
            RdmNum = GetRandom();
            // DELETE THIS
            lblDelete.Text = RdmNum.ToString();
            // enable 'line up balloons' button
            btnLine.Enabled = true;
        }

        private int GetRandom()
        {
            Random myRandomNumber = new Random();
            int rnd = myRandomNumber.Next(1, 7);
            return rnd;
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            // show all balloons remaining
            ResetBalloonImages();
            picOne.Visible = true;
            picTwo.Visible = true;
            picThree.Visible = true;
            picFour.Visible = true;
            picFive.Visible = true;
            picSix.Visible = true;
            
            // enable 'throw' button
            btnThrow.Enabled = true;
        }

        private void ResetBalloonImages()
        {
            picOne.BackgroundImage = Resources.Balloon;
            picTwo.BackgroundImage = Resources.Balloon;
            picThree.BackgroundImage = Resources.Balloon;
            picFour.BackgroundImage = Resources.Balloon;
            picFive.BackgroundImage = Resources.Balloon;
            picSix.BackgroundImage = Resources.Balloon;
        }

        // check random number against counter
        // add sound effect
        // decide if win or loss
        // decide if game is over
        private void btnThrow_Click(object sender, EventArgs e)
        {
            CheckDodge();
            CheckBalloon();

            // decrease counter
            Counter--;
            dodgeButton = false;
        }

        private void CheckDodge()
        {
            // check if dodge is selected
            if (ckbDodge.Checked == true)
            {
                Dodges--;
                dodgeButton = true;
                if (Dodges  == 1)
                {
                    picDodge2.Visible = false;
                }
                if (Dodges == 0)
                {
                    picDodge.Visible = false;
                    ckbDodge.Enabled = false;
                }
                ckbDodge.Checked = false;

            }
        }

        private void CheckBalloon()
        {
            // if the balloon has the paint
            if (RdmNum == Counter)
            {
                DetermineResult();
            }

            // if the balloon does NOT have the paint
            else 
            {
                // play splash sound
                SoundPlayer mySoundPlayer = new SoundPlayer(@"C:\Users\Jess\Dropbox\C# Projects\Project1WaterBalloons\Project1WaterBalloons\Resources\Splash.wav");
                mySoundPlayer.Play();

                // Call the next function
                ShowBalloonUsed();                
            }
        }

        private void DetermineResult()
        {
            // PLAYER WINS - paint shot misses
            if (dodgeButton == true)
            {
                // win counter ++
                Wins++;
                // start new game
                EndGame();
                // play whoosh (dodge) sound
                SoundPlayer mySoundPlayer = new SoundPlayer(@"C:\Users\Jess\Dropbox\C# Projects\Project1WaterBalloons\Project1WaterBalloons\Resources\Whoosh.wav");
                mySoundPlayer.Play();
                ShowWinningScreen();
            }
            // PLAYER LOSES - paint shot hits
            else 
            {
                // losses counter ++
                Losses++;
                // start new game
                EndGame();
                // play splatter sound
                SoundPlayer mySoundPlayer = new SoundPlayer(@"C:\Users\Jess\Dropbox\C# Projects\Project1WaterBalloons\Project1WaterBalloons\Resources\Splatter.wav");
                mySoundPlayer.Play();
                ShowLosingScreen();
            }
        }

        private void ShowLosingScreen()
        {
            picLoser.Visible = true;
            btnStartAgain.Visible = true;
            lblLoser.Visible = true;
            btnStartAgain.BringToFront();
            lblLoser.BringToFront();
        }

        private void ShowWinningScreen()
        {
            picWin.Visible = true;
            btnStartAgain.Visible = true;
            lblWinner.Visible = true;
            btnStartAgain.BringToFront();
            lblWinner.BringToFront();
        }

        private void EndGame()
        {
            // display wins / losses totals
            lblWin.Text = "Wins: " + Wins;
            lblLose.Text = "Losses: " + Losses;
            // reset images
            picOne.Visible = false;
            picTwo.Visible = false;
            picThree.Visible = false;
            picFour.Visible = false;
            picFive.Visible = false;
            picSix.Visible = false;
            // reset buttons
            btnLine.Enabled = false;
            btnThrow.Enabled = false;
            ckbDodge.Enabled = true;
            ckbDodge.Checked = false;
            dodgeButton = false;
            // reset counter and dodges
            Counter = 7;
            Dodges = 2;
            // show dodges images
            picDodge.Visible = true;
            picDodge2.Visible = true;
        }

        private void ShowBalloonUsed()
        {
            // allow the player to have another turn
            if (Counter == 6)
            {
                picSix.BackgroundImage = Resources.Splash;
            }
            else if (Counter == 5)
            {
                picFive.BackgroundImage = Resources.Splash;
            }
            else if (Counter == 4)
            {
                picFour.BackgroundImage = Resources.Splash;
            }
            else if (Counter == 3)
            {
                picThree.BackgroundImage = Resources.Splash;
            }
            else if (Counter == 2)
            {
                picTwo.BackgroundImage = Resources.Splash;
            }
            else
            {
                picOne.BackgroundImage = Resources.Splash;
            }
        }

        private void btnStartAgain_Click(object sender, EventArgs e)
        {
            picWin.Visible = false;
            picLoser.Visible = false;
            btnStartAgain.Visible = false;
            lblWinner.Visible = false;
            lblLoser.Visible = false;
        }
    }
}
