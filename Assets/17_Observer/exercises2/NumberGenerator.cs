using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObserverPattern_exercises2
{
    public abstract class NumberGenerator
    {
        private ArrayList observers = new ArrayList();
        
        public void addObsever(Observer observer)
        {
            observers.Add(observer);
        }

        public void deleteObserver(Observer observer)
        {
            observers.Remove(observer);
        }

        public void notifyObservers()
        {
            IEnumerator it = observers.GetEnumerator();
            while (it.MoveNext())
            {
                Observer o = (Observer)it.Current;
                o.update(this);
            }
        }

        public abstract int getNumber();
        public abstract void execute();
    }
}
