using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TroublePattern
{
    public abstract class Support
    {
        private string name;
        private Support next;
        public Support(string name)
        {
            this.name = name;
        }

        public Support setNext(Support next)
        {
            this.next = next;
            return next;
        }

        public void support(Trouble trouble)
        {
            if (Resolve(trouble)){
                done(trouble);
            }else if (next != null)
            {
                next.support(trouble);
            }
            else
            {
                fail(trouble);
            }
        }

        public string toString()
        {
            return "[" + name + "]";
        }

        protected abstract bool Resolve(Trouble trouble);
        protected void done(Trouble trouble)
        {
            Debug.Log(trouble.toString() + " is resolved by " + this.toString() + ".");
        }

        protected void fail(Trouble trouble)
        {
            Debug.Log(trouble.toString() + " cannot be resolved.");
        }
    }
}
