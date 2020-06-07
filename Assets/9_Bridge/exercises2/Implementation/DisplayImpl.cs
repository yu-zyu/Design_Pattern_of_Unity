using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BridgePattern_exercises2
{
    public abstract class DisplayImpl
    {
        public abstract void rawOpen();
        public abstract void rawPrint();
        public abstract void rawClose();
    }
}
