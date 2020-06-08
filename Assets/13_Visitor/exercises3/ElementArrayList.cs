using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace VisitorPattern_exercises3
{
    public class ElementArrayList : ArrayList, Element
    {
        public void Accept(Visitor v)
        {
            IEnumerator it = GetEnumerator();
            while (it.MoveNext())
            {
                Element a = (Element)it.Current;
                a.Accept(v);
            }
        }
    }
}
