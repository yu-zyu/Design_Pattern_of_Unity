using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AbstractFactoryPattern_factory_exercises;

namespace AbstractFactoryPattern_tablefactory_exercises
{
    public class TableLink : Link 
    {
        public TableLink(string caption, string url):base(caption, url)
        {
            
        }

        override public string MakeHTML()
        {
            return "<td><a href=\"" + url + "\">" + caption + "</a></td>\n";
        }
    }
}
