using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VisitorPattern_exercises3
{
    public class File : Entry
    {
        private string name;
        private int size;
        public File(string name, int size)
        {
            this.name = name;
            this.size = size;
        }

        override public string getName()
        {
            return name;
        }

        override public int getSize()
        {
            return size;
        }

        override public void Accept(Visitor v)
        {
            v.Visit(this);
        }

    }
}
