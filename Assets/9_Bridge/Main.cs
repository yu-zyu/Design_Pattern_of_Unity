using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BridgePattern
{
    public class Main : MonoBehaviour
    {
        void Start()
        {
            Display d1 = new Display(new StringDisplayImpl("Hello, Japan."));
            Display d2 = new CountDisplay(new StringDisplayImpl("Hello, World."));
            CountDisplay d3 = new CountDisplay(new StringDisplayImpl("Hello, Universe."));
            d1.display();
            d2.display();
            d3.display();
            d3.multiDisplay(5);
        }
    }
}
