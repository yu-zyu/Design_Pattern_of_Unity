using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VisitorPattern_exercises2
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
            SizeVisitor v = new SizeVisitor();
            Accept(v);
            return v.getSize();
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
