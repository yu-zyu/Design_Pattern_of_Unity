using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MediatorPattern
{
    public class LoginFrame : MonoBehaviour, Mediator
    {
        [SerializeField]
        private ColleagueCheckbox checkGuest;
        [SerializeField]
        private ColleagueCheckbox checkLogin;
        [SerializeField]
        private ColleagueTextField textUser;
        [SerializeField]
        private ColleagueTextField textPass;
        [SerializeField]
        private ColleagueButton buttonOk;
        [SerializeField]
        private ColleagueButton buttonCancel;
        private LoginFrame lfs;

        void Start()
        {
            checkGuest.SetMediator(this);
            checkLogin.SetMediator(this);
            textUser.SetMediator(this);
            textPass.SetMediator(this);
            buttonOk.SetMediator(this);
            buttonCancel.SetMediator(this);
            textUser.SetColleagueEnabled(false);
            textPass.SetColleagueEnabled(false);
            buttonOk.SetColleagueEnabled(true);
            buttonCancel.SetColleagueEnabled(true);
        }

        public LoginFrame(string title)
        {
            
        }

        public void CreateColleagues()
        {

        }

        public void ColleagueChanged(string name)
        {
            if (name == checkGuest.gameObject.name)
            {
                textUser.SetColleagueEnabled(false);
                textPass.SetColleagueEnabled(false);
                buttonOk.SetColleagueEnabled(true);
            }
            else
            {
                textUser.SetColleagueEnabled(true);
                userpassChanged();
            }
        }

        private void userpassChanged()
        {
            if(textUser.inputField.text.Length > 0)
            {
                textPass.SetColleagueEnabled(true);
                if(textPass.inputField.text.Length > 0)
                {
                    buttonOk.SetColleagueEnabled(true);
                }
                else
                {
                    buttonOk.SetColleagueEnabled(false);
                }
            }
            else
            {
                textPass.SetColleagueEnabled(false);
                buttonOk.SetColleagueEnabled(false);
            }
        }

        public void actionPerformed()
        {

        }
    }
}
