using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SingletonPattern_exercises2
{
    public class Main : MonoBehaviour
    {
        void Start()
        {
            Debug.Log("Start.");
            for(int i = 0; i < 9; i++)
            {
                Triple triple = Triple.getInstance(i % 3);
                Debug.Log(i + ":" + triple.toString());
            }
            Debug.Log("End.");
        }
    }
}
