using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObserverPattern
{
    public interface Observer
    {
        void update(NumberGenerator generator);
    }
}
