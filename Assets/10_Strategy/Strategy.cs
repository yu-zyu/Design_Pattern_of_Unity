using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StrategyPattern
{
    public interface Strategy
    {
         Hand NextHand();
         void Study(bool win);
    }
}
