using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StrategyPattern_exercises
{
    public interface Strategy
    {
         Hand NextHand();
         void Study(bool win);
    }
}
