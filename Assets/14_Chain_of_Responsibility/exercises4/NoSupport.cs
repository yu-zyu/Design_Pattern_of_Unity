using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TroublePattern_exercises4
{
    public class NoSupport : Support
    {
        public NoSupport(string name) : base(name)
        {

        }

        override protected bool Resolve(Trouble trouble)
        {
            return false;
        }
    }
}
