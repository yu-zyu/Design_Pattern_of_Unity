using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObserverPattern_exercises1
{
    public class Main : MonoBehaviour
    {
        void Start()
        {
            NumberGenerator generator = new IncrementalNumberGenerator(10, 50, 5);
            Observer observer1 = new DigitObserver();
            Observer observer2 = new GraphObserver();
            generator.addObsever(observer1);
            generator.addObsever(observer2);
            generator.execute();
        }
    }
}
