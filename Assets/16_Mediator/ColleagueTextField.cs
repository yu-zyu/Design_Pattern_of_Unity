using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace MediatorPattern
{
    public class ColleagueTextField : MonoBehaviour, Colleague 
    {
        [SerializeField]
        public Mediator mediator;
        public InputField inputField;

        public ColleagueTextField(string text, int columns)
        {

        }
    
        public void SetMediator(Mediator mediator)
        {
            this.mediator = mediator;
        }

        public void SetColleagueEnabled(bool enabled)
        {
            inputField.interactable = enabled;
        }

        public void textValueChanged(string text)
        {
            mediator.ColleagueChanged("");
        }
    
    }
}
