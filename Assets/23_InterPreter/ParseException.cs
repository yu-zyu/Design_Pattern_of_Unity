using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace InterPreterPattern
{
    public class ParseException :  Exception
    {
        public ParseException(string msg):base(msg)
        {
            Debug.Log(msg);
        }
        
    }
}
