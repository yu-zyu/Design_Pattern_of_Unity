using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AbstractFactoryPattern_factory;

namespace AbstractFactoryPattern_listfactory
{
    public class ListLink : Link
    {
        public ListLink(string caption, string url):base(caption, url)
        {
            
        }

        override public string MakeHTML()
        {
            return " <li><a href=\"" + url + "\">" + caption + "</a></li>\n";
        }
    }
}
