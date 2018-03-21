using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1WaterBalloons
{
    public class Result
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