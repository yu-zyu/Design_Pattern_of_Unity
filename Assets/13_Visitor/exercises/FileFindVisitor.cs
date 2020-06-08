using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VisitorPattern_exercises
{
    public class FileFindVisitor : Visitor
    {
        private string filetype;
        private ArrayList found = new ArrayList();
        public FileFindVisitor(string filetype)
        {
            this.filetype = filetype;
        }

        public IEnumerator getFoundFiles()
        {
            return found.GetEnumerator();
        }

        override public void Visit(File file)
        {
            if (file.getName().EndsWith(filetype))
            {
                found.Add(file);
            }
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
