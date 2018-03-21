using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1WaterBalloons
{
    class DodgeCheckbox
    {
        public bool dodgeButton { get; set; } = false;

        public void SetToFalse()
        {
            dodgeButton = false;
        }

        public void SetToTrue()
        {
            dodgeButton = true;
        }
    }
}
