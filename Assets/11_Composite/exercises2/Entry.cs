using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;

namespace CompositePattern2
{
    public abstract class Entry
    {
        public Entry parent;
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

        public string getFullName()
        {
            StringBuilder fullname = new StringBuilder();
            Entry entry = this;
            do
            {
                fullname.Insert(0, "/" + entry.getName());
                entry = entry.parent;
            } while (entry != null);
            return fullname.ToString();
        }
    }
}
