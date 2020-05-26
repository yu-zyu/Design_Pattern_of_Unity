using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObserverPattern
{
    public class Main : MonoBehaviour
    {
        void Start()
        {
            NumberGenerator generator = new RandomNumberGenerator();
            Observer observer1 = new DigitObserver();
            Observer observer2 = new GraphObserver();
            generator.addObsever(observer1);
            generator.addObsever(observer2);
            generator.execute();
        }
    }
}
