using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TroublePattern
{
    public class Trouble
    {
        private int number;
        public Trouble(int number)
        {
            this.number = number;
        }

        public int getNumber()
        {
            return number;
        }

        public string toString()
        {
            return "[Trouble " + number + "]";
        }
    }
}
