using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FlyweightPattern
{
    public class Main : MonoBehaviour
    {
        void Start()
        {
            string str = "1212123";
            BigString bs = new BigString(str);
            bs.print();
        }
    }
}
