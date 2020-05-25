using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VisitorPattern
{
    public interface Element
    {
        void Accept(Visitor v);
    }
}
