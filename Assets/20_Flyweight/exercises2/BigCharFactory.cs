using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FlyweightPattern_exercises2
{
    public class BigCharFactory
    {
        private Dictionary<char, BigChar> pool = new Dictionary<char, BigChar>();
        private static BigCharFactory singleton = new BigCharFactory();
        private BigCharFactory()
        {

        }

        public static BigCharFactory getInstance()
        {
            return singleton;
        }

        public BigChar GetBigChar(char charname)
        {
            BigChar bc = null;
            if (pool.ContainsKey(charname))
            {
                bc = pool[charname];
            }
            if (bc == null)
            {
                bc = new BigChar(charname);
                pool.Add(charname, bc);
            }
            return bc;

        }
    }
}
