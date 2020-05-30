using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MediatorPattern
{
    public class LoginFrame : MonoBehaviour, Mediator
    {
        public GameObject gameObject;
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
        private LoginFrame lf;

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
        }

        public LoginFrame(string title)
        {
//            CreateColleagues();
            
        }

        public void CreateColleagues()
        {
            //    CheckboxGroup g = new CheckboxGroup();
            //    checkGuest = new ColleagueCheckbox("Guest", g, true);
            //    checkLogin = new ColleagueCheckbox("Lofin", g, false);
            //    textUser = new ColleagueTextField("", 10);
            //    textPass = new ColleagueTextField("", 10);
            //    textPass.setEchoChar('*');
            //    buttonOk = new ColleagueButton("OK");
            //    buttonCancel = new ColleagueButton("Cancel");
            checkGuest.SetMediator(lf);
            checkLogin.SetMediator(this);
            textUser.SetMediator(this);
            textPass.SetMediator(this);
            buttonOk.SetMediator(this);
            buttonCancel.SetMediator(this);

        //    checkGuest.addItemListener(checkGuest);
        //    checkGuest.addItemListener(checkGuest);
        //    textUser.addTextListener(textUser);
        //    textPass.addTextListener(textPass);
        //    buttonOk.addActionListener(this);
        //    buttonCancel.addActionListener(this);
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
            //Debug.Log(e.toString());
        }
    }
}
