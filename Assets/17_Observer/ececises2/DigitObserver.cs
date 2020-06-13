using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Threading;

namespace ObserverPattern_exercises2
{
    public class DigitObserver : Observer
    {
        public void update(NumberGenerator generator)
        {
            Debug.Log("DigitObserver:" + generator.getNumber());
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
