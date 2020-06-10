using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FlyweightPattern_exercises1
{
    public class BigString
    {
        private BigChar[] bigchars;

        public BigString(string str)
        {
            initShared(str);
        }

        public BigString(string str, bool shared)
        {
            if (shared)
            {
                initShared(str);
            }
            else
            {
                initUnshared(str);
            }
        }

        public void initShared(string str)
        {
            bigchars = new BigChar[str.Length];
            BigCharFactory factory = BigCharFactory.getInstance();
            for(int i=0; i < bigchars.Length; i++)
            {
                bigchars[i] = factory.GetBigChar(str[i]);
            }
        }

        public void initUnshared(string str)
        {
            bigchars = new BigChar[str.Length];
            for(int i = 0; i < bigchars.Length; i++)
            {
                bigchars[i] = new BigChar(str[i]);
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
