using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TroublePattern_exercises4
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
            for(Support obj = this; true; obj = obj.next)
            {
                if (obj.Resolve(trouble))
                {
                    obj.done(trouble);
                    break;
                }
                else if(obj.next == null)
                {
                    obj.fail(trouble);
                    break;
                }
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
