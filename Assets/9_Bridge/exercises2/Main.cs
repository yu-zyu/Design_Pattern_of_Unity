using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BridgePattern_exercises2
{
    public class Main : MonoBehaviour
    {
        void Start()
        {
            CountDisplay d = new CountDisplay(new FileDisplayImpl("star.txt"));
            d.multiDisplay(3);
        }
    }
}
