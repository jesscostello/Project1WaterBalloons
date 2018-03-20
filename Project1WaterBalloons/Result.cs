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
        public Form3 mainForm;

        public Result(Form3 form3)
        {
            mainForm = form3;
        }
        

        //PictureBox picWin = new PictureBox();
        //PictureBox picLoser = new PictureBox();
        //Button btnStartAgain = new Button();
        //Label lblWinner = new Label();
        //Label lblLoser = new Label();

        // setting properties 
        public int Wins { get; set; } = 0;
        public int Losses { get; set; } = 0;

        /// <summary>
        /// Screen That Displays When Player Wins
        /// </summary>
        public void ShowWinningScreen()
        {
            // display the winning pic/btn/lbl
            mainForm.picWin.Visible = true;
            mainForm.btnStartAgain.Visible = true;
            mainForm.lblWinner.Visible = true;
            // bring btn/lbl in front of pic
            mainForm.btnStartAgain.BringToFront();
            mainForm.lblWinner.BringToFront();
        }

        /// <summary>
        /// Screen That Displays When Player Loses
        /// </summary>
        public void ShowLosingScreen()
        {
            // display the losing pic/btn/lbl
            mainForm.picLoser.Visible = true;
            mainForm.btnStartAgain.Visible = true;
            mainForm.lblLoser.Visible = true;
            // bring btn/lbl in front of pic
            mainForm.btnStartAgain.BringToFront();
            mainForm.lblLoser.BringToFront();
        }
    }
}