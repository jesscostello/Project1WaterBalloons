using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1WaterBalloons
{
    public class Dodges
    {
        public int dodges { get; set; } = 2;

        public int DecreaseDodgeTotal()
        {
            dodges--;
            return dodges;
        }
    }
}
