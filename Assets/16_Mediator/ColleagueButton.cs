using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace MediatorPattern
{
    public class ColleagueButton : MonoBehaviour, Colleague
    {
        [SerializeField]
        private Mediator mediator;
        public Button button;
        public ColleagueButton(string caption)
        {

        }

        public void SetMediator(Mediator mediator)
        {
            this.mediator = mediator;
        }

        public void SetColleagueEnabled(bool enabled)
        {
            button.interactable = enabled;
        }
    }
}
