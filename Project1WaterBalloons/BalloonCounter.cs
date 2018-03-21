using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1WaterBalloons
{
    public class BalloonCounter
    {
        public int Counter { get; set; } = 6;

        public int DecreaseCounterValue()
        {
            Counter--;
            return Counter;
        }
    }
}
