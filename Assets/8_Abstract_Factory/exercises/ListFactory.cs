using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AbstractFactoryPattern_factory_exercises;

namespace AbstractFactoryPattern_listfactory_exercises
{
    public class ListFactory : Factory 
    {
        override public Link createLink(string caption, string url)
        {
            return new ListLink(caption, url);
        }

        override public Tray createTray(string caption)
        {
            return new ListTray(caption);
        }

        override public Page createPage(string title, string author)
        {
            return new ListPage(title, author);
        }
    }
}
