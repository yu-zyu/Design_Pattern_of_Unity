using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace InterPreterPattern_language_exercises1
{
    public class ParseException :  Exception
    {
        public ParseException(string msg):base(msg)
        {
            Debug.Log(msg);
        }
        
    }
}
