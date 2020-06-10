using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObserverPattern_exercises1
{
    public class IncrementalNumberGenerator : NumberGenerator
    {
        private int number;
        private int end;
        private int inc;

        public IncrementalNumberGenerator(int start, int end, int inc)
        {
            this.number = start;
            this.end = end;
            this.inc = inc;
        }

       override public int getNumber()
        {
            return number;
        }

       override public void execute()
        {
            while(number < end)
            {
                notifyObservers();
                number += inc;
            }
        }
    }
}
