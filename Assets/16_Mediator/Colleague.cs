using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MediatorPattern
{
    public interface Colleague
    {
        void SetMediator(Mediator mediator);
        void SetColleagueEnabled(bool enabled);
    }
}
