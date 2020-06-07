using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BridgePattern_exercises3
{
    public class Main : MonoBehaviour
    {
        void Start()
        {
            IncreaseDisplay d1 = new IncreaseDisplay(new CharDisplayImpl('<', '*', '>'), 1);
            IncreaseDisplay d2 = new IncreaseDisplay(new CharDisplayImpl('|', '#', '-'), 2);
            d1.increaseDisplay(4);
            d2.increaseDisplay(6);
        }
    }
}
