using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FacadePattern_pagemaker
{
    public class Main : MonoBehaviour
    {
        void Start()
        {
            PageMaker.makeWelcomePage("hyuki@hyuki.com", "welcome.html");
        }
    }
}
