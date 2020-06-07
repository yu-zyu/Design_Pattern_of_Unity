using System.Collections;
using System.Collections.Generic;
using System;

namespace StrategyPattern_exercises
{
    public class RandomStrategy : Strategy
    {
        private Random random;
        public RandomStrategy(int seed)
        {
            random = new Random(seed);
        }

        public void Study(bool win)
        {

        }

        public Hand NextHand()
        {
            return Hand.getHand(random.Next(3));
        }

    }
}
