using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StatePattern_exercises4
{
    public interface State
    {
        void DoClock(Context context, int hour);
        void DoUse(Context context);
        void DoAlarm (Context context);
        void DoPhone(Context context);
    }
}
