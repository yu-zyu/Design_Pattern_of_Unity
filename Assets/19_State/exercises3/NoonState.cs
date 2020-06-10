using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StatePattern_exercises3
{
    public class NoonState : State 
    {
        private static NoonState singleton = new NoonState();

        private NoonState()
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
            }else if(9 <= hour && hour < 12 || 13 <= hour && hour < 17)
            {
                context.ChangeState(DayState.GetInstance());
            }
        }

        public void DoUse(Context context)
        {
            context.RecordLog("非常：昼食事の金庫使用！");
        }

        public void DoAlarm(Context context)
        {
            context.CallSecurityCenter("非常ベル（昼食事）");
        }

        public void DoPhone(Context context)
        {
            context.CallSecurityCenter("昼食事の通話録音");
        }

        public string toString()
        {
            return "[昼食事]";
        }
    }
}
