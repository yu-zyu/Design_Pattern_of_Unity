using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObserverPattern
{
    public class RandomNumberGenerator : NumberGenerator
    {
        private System.Random random = new System.Random();
        private int number;
        override public int getNumber()
        {
            return number;
        }

        override public void execute()
        {
            for(int i = 0; i < 20; i++)
            {
                number = random.Next(50);
                notifyObservers();
            }
        }
    }
}