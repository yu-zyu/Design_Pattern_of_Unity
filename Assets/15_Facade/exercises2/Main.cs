using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FacadePattern_pagemaker_exercises2
{
    public class Main : MonoBehaviour
    {
        void Start()
        {
            PageMaker.makeLinkPage("linkpage.html");
        }
    }
}
