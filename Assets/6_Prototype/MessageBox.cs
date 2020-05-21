using UnityEngine;
using System.Text;
using System;
using PrototypePattern_framework;

namespace PrototypePattern
{
    public class MessageBox : Product
    {
        private char decochar; 
        public MessageBox(char decochar)
        {
            this.decochar = decochar;
        }

        public void Use(string s)
        {
            int length = Encoding.ASCII.GetByteCount(s);
            for(int i = 0; i < length + 4; i++)
            {
                Debug.Log(decochar);
            }
            Debug.Log("");
            Debug.Log(decochar + " " + s + " " + decochar);
            for(int i = 0; i < length + 4; i++)
            {
                Debug.Log(decochar);
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
            return (Product)p;
        }

        public object Clone()
        {
            return this;
        }
    }
}