using System.Collections;
using System.Collections.Generic;
using System;

namespace BridgePattern_exercises
{
    public class RandomCountDisplay : CountDisplay
    {
        private Random random = new Random();
        
        public RandomCountDisplay(DisplayImpl impl) : base(impl)
        {

        }

        public void randomDisplay(int times)
        {
            multiDisplay(random.Next(times));
        }
    }
}
