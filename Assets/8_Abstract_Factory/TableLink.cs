using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AbstractFactoryPattern_factory;

namespace AbstractFactoryPattern_tablefactory
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
