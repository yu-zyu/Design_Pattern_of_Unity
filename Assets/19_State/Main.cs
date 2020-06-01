using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using System;

namespace StatePattern
{
    public class Main : MonoBehaviour
    {
       public SafeFrame frame;

        private void Start()
        {
            StartCoroutine("Delay");

//          for (int hour = 0; hour < 24; hour++)
//            {
//                frame.SetClock(hour);
//                    System.Threading.Thread.Sleep(1000);
//                try
//                {
//                }
//                catch (Exception e)
//                {
//
//                }
//            }
   
        }

        void Update()
        {
            //InvokeRepeating("Delay", 3);
            //StartCoroutine("Delay");
           
        }

        IEnumerator Delay()
        {
            for (int hour = 0; hour < 24; hour++)
            {
                    frame.SetClock(hour);
                //Debug.Log("a");
            yield return new WaitForSeconds(1.0f);
                //System.Threading.Thread.Sleep(1000);
                try
                {
                }
                catch (Exception)
                {

                }
            }            
        }
    }
}
