﻿using System;
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
        // TODO make into properties inside classes
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
            // generate a random number from 1-6
            Random myRandomNumber = new Random();
            int rnd = myRandomNumber.Next(1, 7);
            // return the random number
            return rnd;
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            // reset images from splash to balloon image
            ResetBalloonImages();
            // show all balloons remaining
            DisplayBalloonImages();
            // enable 'throw' button
            btnThrow.Enabled = true;
        }

        private void DisplayBalloonImages()
        {
            picOne.Visible = true;
            picTwo.Visible = true;
            picThree.Visible = true;
            picFour.Visible = true;
            picFive.Visible = true;
            picSix.Visible = true;
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

        
        private void btnThrow_Click(object sender, EventArgs e)
        {
            // call methods
            CheckDodge();
            CheckBalloon();

            // decrease counter
            Counter--;
            // reset dodge checkbox
            dodgeButton = false;
        }

        private void CheckDodge()
        {
            // check if dodge is selected
            if (ckbDodge.Checked == true)
            {
                // decrease dodges counter total
                Dodges--;
                // set dodge button to true because player has dodged
                dodgeButton = true;
                // remove 'dodge' images when they are used
                if (Dodges  == 1)
                {
                    picDodge2.Visible = false;
                }
                if (Dodges == 0)
                {
                    picDodge.Visible = false;
                    // when no dodges left
                    // disable checkbox for rest of game
                    ckbDodge.Enabled = false;
                }
                // reset checkbox back to unchecked
                ckbDodge.Checked = false;
            }
        }

        private void CheckBalloon()
        {
            // if the balloon has the paint
            if (RdmNum == Counter)
            {
                // call the method
                DetermineResult();
            }

            // if the balloon does NOT have the paint
            else 
            {
                // play splash sound
                SoundPlayer mySoundPlayer = new SoundPlayer(@"C:\Users\Jess\Dropbox\C# Projects\Project1WaterBalloons\Project1WaterBalloons\Resources\Splash.wav");
                mySoundPlayer.Play();

                // Call the next method
                ShowBalloonUsed();                
            }
        }

        private void DetermineResult()
        {
            // PLAYER WINS - paint shot misses
            if (dodgeButton == true)
            {
                // increase win counter by 1
                Wins++;
                // call the method
                EndGame();
                // play whoosh (dodge) sound
                SoundPlayer mySoundPlayer = new SoundPlayer(@"C:\Users\Jess\Dropbox\C# Projects\Project1WaterBalloons\Project1WaterBalloons\Resources\Whoosh.wav");
                mySoundPlayer.Play();
                // display the winning screen
                ShowWinningScreen();
            }
            // PLAYER LOSES - paint shot hits
            else 
            {
                // increase losses counter by 1
                Losses++;
                // call the method
                EndGame();
                // play splatter sound
                SoundPlayer mySoundPlayer = new SoundPlayer(@"C:\Users\Jess\Dropbox\C# Projects\Project1WaterBalloons\Project1WaterBalloons\Resources\Splatter.wav");
                mySoundPlayer.Play();
                // display losing screen
                ShowLosingScreen();
            }
        }

        private void ShowLosingScreen()
        {
            // display the losing pic/btn/lbl
            picLoser.Visible = true;
            btnStartAgain.Visible = true;
            lblLoser.Visible = true;
            // bring btn/lbl in front of pic
            btnStartAgain.BringToFront();
            lblLoser.BringToFront();
        }

        private void ShowWinningScreen()
        {
            // display the winning pic/btn/lbl
            picWin.Visible = true;
            btnStartAgain.Visible = true;
            lblWinner.Visible = true;
            // bring btn/lbl in front of pic
            btnStartAgain.BringToFront();
            lblWinner.BringToFront();
        }

        private void EndGame()
        {
            // display wins / losses totals
            lblWin.Text = "Wins: " + Wins;
            lblLose.Text = "Losses: " + Losses;
            // reset images (don't show any balloons)
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
            // change the image from balloon to splash if the
            // balloon had the water in it
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
            // hide winning/losing screen to display the game again
            picWin.Visible = false;
            picLoser.Visible = false;
            btnStartAgain.Visible = false;
            lblWinner.Visible = false;
            lblLoser.Visible = false;
        }
    }
}
