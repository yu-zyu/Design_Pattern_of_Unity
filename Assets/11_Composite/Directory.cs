using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace CompositePattern
{
    public class Directory : Entry 
    {
        private string name;
        private ArrayList directory = new ArrayList();
        public Directory(string name)
        {
            this.name = name;
        }

        override public string getName()
        {
            return name;
        }

        public override int getSize()
        {
            int size = 0;
            IEnumerator it = directory.GetEnumerator();
            while (it.MoveNext())
            {
                Entry entry = (Entry)it.Current;
                size += entry.getSize();
            }
            return size;
        }

        public Entry Add(Entry entry)
        {
            directory.Add(entry);
            return this;
        }

        override public void printList(string prefix)
        {
            Debug.Log(prefix + "/" + this.toString());
            IEnumerator it = directory.GetEnumerator();
            while (it.MoveNext())
            {
                Entry entry = (Entry)it.Current;
                entry.printList(prefix + "/" + name);
            }
        }
    }
}
