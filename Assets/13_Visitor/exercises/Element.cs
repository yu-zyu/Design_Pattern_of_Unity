using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VisitorPattern_exercises
{
    public interface Element
    {
        void Accept(Visitor v);
    }
}
