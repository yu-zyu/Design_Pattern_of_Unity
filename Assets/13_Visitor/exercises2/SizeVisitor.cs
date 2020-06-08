using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VisitorPattern_exercises2
{
    public class SizeVisitor : Visitor
    {
        private int size = 0;

        public int getSize()
        {
            return size;
        }

        override public void Visit(File file)
        {
            size += file.getSize();
        }

       override public void Visit(Directory directory)
        {
            IEnumerator it = directory.Iterator();
            while (it.MoveNext())
            {
                Entry entry = (Entry)it.Current;
                entry.Accept(this);
            }
        }
    }
}
