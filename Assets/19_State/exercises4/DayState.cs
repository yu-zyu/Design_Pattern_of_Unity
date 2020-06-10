using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StatePattern_exercises4
{
    public class DayState : State 
    {
        private static DayState singleton = new DayState();

        private DayState()
        {

        }

        public static State GetInstance()
        {
            return singleton;
        }

        public void DoClock(Context context, int hour)
        {
            if(hour < 9 || 17 <= hour)
            {
                context.ChangeState(NightState.GetInstance());
            }
        }

        public void DoUse(Context context)
        {
            context.RecordLog("金庫仕様(昼間)");
        }

        public void DoAlarm(Context context)
        {
            context.CallSecurityCenter("非常ベル（昼間）");
            context.ChangeState(UrgentState.GetInstance());
        }

        public void DoPhone(Context context)
        {
            context.CallSecurityCenter("通常の通話（昼間）");
        }

        public string toString()
        {
            return "[昼間]";
        }
    }
}
