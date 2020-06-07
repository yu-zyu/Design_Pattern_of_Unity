using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StrategyPattern_exercises
{
    public class WinningStrategy : Strategy
    {
        private System.Random random;
        private bool won = false;
        private Hand prevHand;
        public WinningStrategy(int seed)
        {
            random = new System.Random(seed);
        }

        public Hand NextHand()
        {
            if (!won)
            {
                prevHand = Hand.getHand(random.Next(3));
            }
            return prevHand;
        }

        public void Study(bool win)
        {
            won = win;
        }
    }
}
