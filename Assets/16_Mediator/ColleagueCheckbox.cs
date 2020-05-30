using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace MediatorPattern
{
    public class ColleagueCheckbox : MonoBehaviour, Colleague 
    {
        [SerializeField]
        private Mediator mediator;
        public Toggle toggle;

        public ColleagueCheckbox(string caption, bool state) 
        {

        }

        public void SetMediator(Mediator mediator)
        {
            this.mediator = mediator;
        }

        public void SetColleagueEnabled(bool enabled)
        {
            toggle.interactable = enabled;
        }

        public void itemStateChanged()
        {
            if(true == toggle.isOn)
            {
                mediator.ColleagueChanged(gameObject.name);
            }

        }
    }
}
