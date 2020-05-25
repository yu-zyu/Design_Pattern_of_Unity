using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TroublePattern
{
    public class OddSupport : Support 
    {
        public OddSupport(string name) : base(name)
        {

        }

        override protected bool Resolve(Trouble trouble)
        {
            if(trouble.getNumber() % 2 == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
