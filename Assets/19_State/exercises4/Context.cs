using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StatePattern_exercises4
{
    public interface Context
    {
        void SetClock(int hour);
        void ChangeState(State state);
        void CallSecurityCenter(string msg);
        void RecordLog(string msg);
    }
}
