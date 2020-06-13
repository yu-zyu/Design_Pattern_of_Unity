using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Threading;

namespace ObserverPattern_exercises2
{
    public class FrameObserver : Observer 
    {

        public FrameObserver()
        {

        }

        public void actionPerformed()
        {
            Debug.Log("");
        }
        
        public void update(NumberGenerator generator)
        {
            Debug.Log("FrameObserver:");
            int count = generator.getNumber();
            for(int i = 0; i < count; i++)
            {
                var cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                cube.transform.position = new Vector3(0, i, 0);
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
