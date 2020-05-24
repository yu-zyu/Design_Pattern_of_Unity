using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace AbstractFactoryPattern_factory
{
    public abstract class Tray : Item
    {
        protected ArrayList tray = new ArrayList();
        public Tray(string caption):base(caption) 
        {
            base.caption = caption;
        }

        public void add(Item item)
        {
            tray.Add(item);
        }
    }
}
