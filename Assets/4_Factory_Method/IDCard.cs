using UnityEngine;
using FactoryMethodPattern_framework;

namespace FactoryMethodPattern_idcard
{
    public class IDCard : Product
    {
        private string owner; 
        public IDCard(string owner)
        {
            Debug.Log(owner + "のカードを作ります。");
            this.owner = owner;
        }

        override public void Use()
        {
            Debug.Log(owner + "のカードを使います。");
        }

        public string getOwner()
        {
            return owner;
        }
    }
}
