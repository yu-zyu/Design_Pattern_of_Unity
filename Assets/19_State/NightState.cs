using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StatePattern
{
    public class NightState : State
    {
        private static NightState singleton = new NightState();
        private NightState()
        {

        }

        public static State GetInstance()
        {
            return singleton;
        }

        public void DoClock(Context context, int hour)
        {
            if(9 <= hour && hour < 17)
            {
                context.ChangeState(DayState.GetInstance());
            }
        }
            
        public void DoUse(Context context)
        {
            context.CallSecurityCenter("非常：夜間の金庫使用！");
        }

        public void DoAlarm(Context context)
        {
            context.RecordLog("非常ベル（夜間）");
        }

        public void DoPhone(Context context)
        {
            context.RecordLog("夜間の通話録音");
        }

        public string toString()
        {
            return "[夜間]";
        }
    }
}
