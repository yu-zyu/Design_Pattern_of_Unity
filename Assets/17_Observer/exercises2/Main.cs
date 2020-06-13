using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObserverPattern_exercises2
{
    public class Main : MonoBehaviour
    {
        void Start()
        {
            NumberGenerator generator = new IncrementalNumberGenerator(10, 50, 5);
            Observer observer1 = new DigitObserver();
            Observer observer2 = new GraphObserver();
            Observer observer3 = new FrameObserver();
            generator.addObsever(observer1);
            generator.addObsever(observer2);
            generator.addObsever(observer3);
            generator.execute();
        }
    }
}
