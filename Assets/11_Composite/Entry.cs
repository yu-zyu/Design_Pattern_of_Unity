using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CompositePattern
{
    public abstract class Entry
    {
        public abstract string getName();
        public abstract int getSize();
        public Entry Add(Entry entry)
        {
            throw new FileTreatmentException();
        }

        public void printList()
        {
            printList("");
        }

        public abstract void printList(string prefix);

        public string toString()
        {
            return getName() + " (" + getSize() + ")";
        }
    }
}
