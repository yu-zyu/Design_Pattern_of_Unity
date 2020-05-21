using UnityEngine;
using PrototypePattern_framework;
using System.Text;
using System;

namespace PrototypePattern
{
    public class UnderlinePen : Product
    {
        private char ulchar;
        public UnderlinePen(char ulchar)
        {
            this.ulchar = ulchar;
        }

        public void Use(string s)
        {
            int length = Encoding.ASCII.GetByteCount(s);
            Debug.Log("\"" + s + "\"");
            Debug.Log(" ");
            for(int i = 0; i < length; i++)
            {
                Debug.Log(ulchar);
            }
            Debug.Log("");
        }

        public Product CreateClone()
        {
            Product p = null;
            try
            {
                p = (Product)this.Clone();
            }
            catch (NotSupportedException e)
            {
                Debug.Log(e.StackTrace.ToString()); 
            }
            return p;
        }

        public object Clone()
        {
            return this;
        }
    }
}
