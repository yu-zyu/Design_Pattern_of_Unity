using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FlyweightPattern_exercises1
{
    public class Main : MonoBehaviour
    {
        void Start()
        {
            string str = "1212123";
            BigString bs = new BigString(str, false);
            bs.print();
            bs = new BigString(str, true);
            bs.print();
        }
    }
}
