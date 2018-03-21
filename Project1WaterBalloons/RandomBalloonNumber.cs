using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1WaterBalloons
{
    class RandomBalloonNumber
    {
        public int RdmNum { get; set; }

        public string GenerateRandom()
        {
            RdmNum = GetRandom();
            return RdmNum.ToString();
        }

        public int GetRandom()
        {
            // generate a random number from 1-6
            Random myRandomNumber = new Random();
            int rnd = myRandomNumber.Next(1, 7);
            // return the random number
            return rnd;
        }
    }
}
