using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace VisitorPattern_exercises2
{
    public abstract class Entry : Element
    {
        public abstract string getName();
        public abstract int getSize();
        public Entry Add(Entry entry)
        {
            throw new FileTreatmentException();
        }

        public abstract void Accept(Visitor v);

        public IEnumerator Iterator()
        {
            throw new FileTreatmentException();
        }

        public string toString()
        {
            return getName() + " (" + getSize() + ")";
        }
    }
}
