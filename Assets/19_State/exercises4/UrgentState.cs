using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StatePattern_exercises4
{
    public class UrgentState : State 
    {
        private static UrgentState singleton = new UrgentState();

        private UrgentState()
        {

        }

        public static State GetInstance()
        {
            return singleton;
        }

        public void DoClock(Context context, int hour)
        {
            
        }

        public void DoUse(Context context)
        {
            context.RecordLog("非常：非常時の金庫使用！");
        }

        public void DoAlarm(Context context)
        {
            context.CallSecurityCenter("非常ベル（非常時）");
        }

        public void DoPhone(Context context)
        {
            context.CallSecurityCenter("通常の通話（非常時）");
        }

        public string toString()
        {
            return "[非常時]";
        }
    }
}
