using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BridgePattern_exercises2
{
    public class CountDisplay : Display
    {
        public CountDisplay(DisplayImpl impl):base(impl)
        {

        }

        public void multiDisplay(int times)
        {
            open();
            for(int i = 0; i < times; i++)
            {
                print();
            }
            close();
        }
    }
}
