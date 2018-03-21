using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1WaterBalloons
{
    class Result
    {
        // setting properties 
        public int Wins { get; set; } = 0;
        public int Losses { get; set; } = 0;

        public int IncreaseWinTotal()
        {
            Wins++;
            return Wins;
        }

        public int IncreaseLossTotal()
        {
            Losses++;
            return Losses;
        }
        
    }
}

//PictureBox picWin = new PictureBox();
//PictureBox picLoser = new PictureBox();
//Button btnStartAgain = new Button();
//Label lblWinner = new Label();
//Label lblLoser = new Label();
//public void ShowWinningScreen()
//{
//    // display the winning pic/btn/lbl
//    mainForm.picWin.Visible = true;
//    mainForm.btnStartAgain.Visible = true;
//    mainForm.lblWinner.Visible = true;
//    // bring btn/lbl in front of pic
//    mainForm.btnStartAgain.BringToFront();
//    mainForm.lblWinner.BringToFront();
//}

///// <summary>
///// Screen That Displays When Player Loses
///// </summary>
//public void ShowLosingScreen()
//{
//    // display the losing pic/btn/lbl
//    mainForm.picLoser.Visible = true;
//    mainForm.btnStartAgain.Visible = true;
//    mainForm.lblLoser.Visible = true;
//    // bring btn/lbl in front of pic
//    mainForm.btnStartAgain.BringToFront();
//    mainForm.lblLoser.BringToFront();
//}

//public void DetermineResult()
//{
//    //Result myResult = new Result(this);
//    // PLAYER WINS - paint shot misses
//    if (mainForm.dodgeButton == true)
//    {
//        // increase win counter by 1
//        Wins++;
//        // call the method
//        mainForm.EndGame();
//        // play whoosh (dodge) sound
//        SoundPlayer mySoundPlayer = new SoundPlayer(@"C:\Users\Jess\Dropbox\C# Projects\Project1WaterBalloons\Project1WaterBalloons\Resources\Whoosh.wav");
//        mySoundPlayer.Play();
//        // display the winning screen
//        ShowWinningScreen();
//    }
//    // PLAYER LOSES - paint shot hits
//    else
//    {
//        // increase losses counter by 1
//        Losses++;
//        // call the method
//        mainForm.EndGame();
//        // play splatter sound
//        SoundPlayer mySoundPlayer = new SoundPlayer(@"C:\Users\Jess\Dropbox\C# Projects\Project1WaterBalloons\Project1WaterBalloons\Resources\Splatter.wav");
//        mySoundPlayer.Play();
//        // display losing screen
//        ShowLosingScreen();
//    }
//}