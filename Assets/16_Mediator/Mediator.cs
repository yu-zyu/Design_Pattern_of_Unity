using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MediatorPattern
{
    public interface Mediator
    {
         void CreateColleagues();
         void ColleagueChanged(string name);
    }
}
