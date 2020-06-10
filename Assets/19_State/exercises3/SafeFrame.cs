using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace StatePattern_exercises3
{
    public class SafeFrame : MonoBehaviour, Context
    {
        [SerializeField]
        private Text textClock;
        [SerializeField]
        private Text textScreen;
        [SerializeField]
        private Button buttonUse;
        [SerializeField]
        private Button buttonAlarm;
        [SerializeField]
        private Button buttonPhone;
        [SerializeField]
        private Button buttonExit;


        private State state = DayState.GetInstance();

        // Start is called before the first frame update
        void Awake()
        {
            state = DayState.GetInstance();
            buttonUse.onClick.AddListener(() => { ActionPerformed(buttonUse); });
            buttonAlarm.onClick.AddListener(() => { ActionPerformed(buttonAlarm); });
            buttonPhone.onClick.AddListener(() => { ActionPerformed(buttonPhone); });
            buttonExit.onClick.AddListener(() => { ActionPerformed(buttonExit); });
        }

        public SafeFrame(string title)
        {

        }

        public void ActionPerformed(Object button)
        {
            Debug.Log(button.ToString());
            if (button == buttonUse)
            {
                state.DoUse(this);
            }
            else if (button == buttonAlarm)
            {
                state.DoAlarm(this);
            }
            else if (button == buttonPhone)
            {
                state.DoPhone(this);
            }
            else if (button == buttonExit)
            {
                UnityEditor.EditorApplication.isPlaying = false;
            }
            else
            {
                Debug.Log("?");
            }
        }

        public void SetClock(int hour)
        {
            string clockstring = "現在時刻は";
            if (hour < 10)
            {
                clockstring += "0" + hour + ":00";
            }
            else
            {
                clockstring += hour + ":00";
            }
            Debug.Log(clockstring);
            textClock.text = clockstring;
            state.DoClock(this, hour);
        }

        public void ChangeState(State state)
        {
            Debug.Log(this.state + "から" + state + "へ状態が変化しました。");
            this.state = state;
        }

        public void CallSecurityCenter(string msg)
        {
            textScreen.text +=   "\n" + "call! " + msg ;
        }

        public void RecordLog(string msg)
        {
            textScreen.text += "\n" + "record ... " + msg;
        }

    }
}
