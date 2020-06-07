using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BridgePattern_exercises3
{
    public class IncreaseDisplay : CountDisplay
    {
        private int step;

        public IncreaseDisplay(DisplayImpl impl, int step) : base(impl)
        {
           this.step = step; 
        }

        public void increaseDisplay(int level)
        {
            int count = 0;
            for (int i = 0; i < level; i++)
            {
                multiDisplay(count);
                count += step;
            }
        }
    }
}
