using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TroublePattern
{
    public class SpeciaSupport : Support
    {
        private int number;
        public SpeciaSupport(string name, int number):base(name)
        {
            this.number = number;
        }

       override protected bool Resolve(Trouble trouble)
        {
            if(trouble.getNumber() == number)
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
