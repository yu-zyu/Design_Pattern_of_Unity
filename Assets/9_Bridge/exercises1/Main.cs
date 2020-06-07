using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BridgePattern_exercises
{
    public class Main : MonoBehaviour
    {
        void Start()
        {
            RandomCountDisplay d = new RandomCountDisplay(new StringDisplayImpl("Hello, Japan"));
            d.randomDisplay(10);
        }
    }
}
