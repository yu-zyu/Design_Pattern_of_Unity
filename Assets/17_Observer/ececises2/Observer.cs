using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObserverPattern_exercises2
{
    public interface Observer
    {
        void update(NumberGenerator generator);
    }
}
