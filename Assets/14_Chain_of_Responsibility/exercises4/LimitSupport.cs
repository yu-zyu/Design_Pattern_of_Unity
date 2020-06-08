using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TroublePattern_exercises4
{
    public class LimitSupport : Support
    {
        private int limit;
        public LimitSupport(string name, int limit) : base(name)
        {
            this.limit = limit;
        }

       override protected bool Resolve(Trouble trouble)
        {
            if(trouble.getNumber() < limit)
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
