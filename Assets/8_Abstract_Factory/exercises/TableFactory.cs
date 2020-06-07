using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AbstractFactoryPattern_factory_exercises;

namespace AbstractFactoryPattern_tablefactory_exercises
{
    public class TableFactory : Factory 
    {
        override public Link createLink(string caption, string url)
        {
            return new TableLink(caption, url);
        }

        override public Tray createTray(string caption)
        {
            return new TableTray(caption);
        }

        override public Page createPage(string title, string author)
        {
            return new TablePage(title, author);
        }
    }
}
