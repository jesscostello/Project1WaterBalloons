using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1WaterBalloons
{
    class Result
    {
        PictureBox picWin = new PictureBox();
        PictureBox picLoser = new PictureBox();
        Button btnStartAgain = new Button();
        Label lblWinner = new Label();
        Label lblLoser = new Label();

        // setting properties 
        public int Wins { get; set; } = 0;
        public int Losses { get; set; } = 0;

        /// <summary>
        /// Screen That Displays When Player Wins
        /// </summary>
        public void ShowWinningScreen()
        {
            // display the winning pic/btn/lbl
            picWin.Visible = true;
            btnStartAgain.Visible = true;
            lblWinner.Visible = true;
            // bring btn/lbl in front of pic
            btnStartAgain.BringToFront();
            lblWinner.BringToFront();
        }

        /// <summary>
        /// Screen That Displays When Player Loses
        /// </summary>
        public void ShowLosingScreen()
        {
            // display the losing pic/btn/lbl
            picLoser.Visible = true;
            btnStartAgain.Visible = true;
            lblLoser.Visible = true;
            // bring btn/lbl in front of pic
            btnStartAgain.BringToFront();
            lblLoser.BringToFront();
        }
    }
}