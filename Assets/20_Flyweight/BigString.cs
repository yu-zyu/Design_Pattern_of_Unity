using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FlyweightPattern
{
    public class BigString
    {
        private BigChar[] bigchars;

        public BigString(string str)
        {
            bigchars = new BigChar[str.Length];
            BigCharFactory factory = BigCharFactory.getInstance();
            for (int i = 0; i < bigchars.Length; i++)
            {
                bigchars[i] = factory.GetBigChar(str[i]);
            }
        }


        public void print()
        {
            for (int i = 0; i < bigchars.Length; i++)
            {
                bigchars[i].print();
            }
        }
    }
}
