using UnityEngine;
using FactoryMethodPattern_exercises_framework;

namespace FactoryMethodPattern_exercises_idcard
{
    public class IDCard : Product
    {
        private string owner;
        private int serial;

        public IDCard(string owner , int serial)
        {
            Debug.Log(owner + "("+ serial +")" + "のカードを作ります。");
            this.owner = owner;
            this.serial = serial;
        }

        override public void Use()
        {
            Debug.Log(owner + "(" + serial + ")" + "のカードを使います。");
        }

        public string getOwner()
        {
            return owner;
        }

        public int getSerial()
        {
            return serial;
        }



    }
}
