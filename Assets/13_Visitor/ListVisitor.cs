using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VisitorPattern
{
    public class ListVisitor : Visitor
    {
        private string currentdir = "";
        override public void Visit(File file)
        {
            Debug.Log(currentdir + "/" + file.toString());
        }

        override public void Visit(Directory directory)
        {
            Debug.Log(currentdir + "/" + directory.toString());
            string savedir = currentdir;
            currentdir = currentdir + "/" + directory.getName();
            IEnumerator it = directory.Iterator();
            while (it.MoveNext())
            {
                Entry entry = (Entry)it.Current;
                entry.Accept(this);
            }
            currentdir = savedir;
        }
    }
}
