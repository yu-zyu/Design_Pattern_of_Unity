using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace StrategyPattern
{
    public class ProbStrategy : Strategy
    {
        private System.Random random;
        private int prevHandValue = 0;
        private int currentHandValue = 0;
        private int[,] history = new int[3, 3]
        {
            {1,1,1, },
            {1,1,1, },
            {1,1,1, },
        };

        public ProbStrategy(int seed)
        {
            random = new System.Random(seed);
        }

        public Hand NextHand()
        {
            System.Random random = new System.Random();
            int bet = random.Next(getSum(currentHandValue));
            int handvalue = 0;
            if (bet < history[currentHandValue,0])
            {
                handvalue = 0;
            }
            else if (bet < history[currentHandValue,0] + history[currentHandValue,1]){
                handvalue = 1;
            }else{
                handvalue = 2;
            }
            prevHandValue = currentHandValue;
            currentHandValue = handvalue;
            return Hand.getHand(handvalue);
        }

        public int getSum(int hv)
        {
            int sum = 0;
            for(int i = 0; i < 3; i++)
            {
                sum += history[hv,i];
            }
            return sum;
        }

        public void Study(bool win)
        {
            if (win)
            {
                history[prevHandValue,currentHandValue]++;
            }
            else
            {
                history[prevHandValue,(currentHandValue + 1) % 3]++;
                history[prevHandValue,(currentHandValue + 2) % 3]++;
            }
        }

    }
}
