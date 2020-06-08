using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VisitorPattern_exercises3
{
    public class Directory : Entry
    {
        private string name;
        private ArrayList dir = new ArrayList();
        public Directory(string name)
        {
            this.name = name;
        }

        override public string getName()
        {
            return name;
        }

        override public int getSize()
        {
            int size = 0;
            IEnumerator it = dir.GetEnumerator();
            while (it.MoveNext())
            {
                Entry entry = (Entry)it.Current;
                size += entry.getSize();
            }
            return size;
        }

        public Entry Add(Entry entry)
        {
            dir.Add(entry);
            return this;
        }

        public IEnumerator Iterator()
        {
            return dir.GetEnumerator();
        }

        override public void Accept(Visitor v)
        {
            v.Visit(this);
        }
    }
}
