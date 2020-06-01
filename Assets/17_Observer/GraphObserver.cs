using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Threading;

namespace ObserverPattern
{
    public class GraphObserver : Observer 
    {
        public void update(NumberGenerator generator)
        {
            Debug.Log("GraphObserver:");
            int count = generator.getNumber();
            for(int i = 0; i < count; i++)
            {
                Debug.Log("*");
            }
            Debug.Log("");
            try
            {
                Thread.Sleep(100);
            }
            catch (Exception)
            {

            }
        }
    }
}
