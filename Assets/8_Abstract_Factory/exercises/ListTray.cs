using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AbstractFactoryPattern_factory_exercises;
using System.Text;
using System;

namespace AbstractFactoryPattern_listfactory_exercises
{
    public class ListTray : Tray 
    {
        public ListTray(string caption):base(caption)
        {

        }

        override public string MakeHTML()
        {
            StringBuilder buffer = new StringBuilder();
            buffer.Append("<li>\n");
            buffer.Append(caption + "\n");
            buffer.Append("<ul>\n");
            IEnumerator it = tray.GetEnumerator();
            while (it.MoveNext())
            {
                Item item = (Item)it.Current;
                buffer.Append(item.MakeHTML());
            }
            buffer.Append("</ul>\n");
            buffer.Append("</li>\n");
            return buffer.ToString();

        }
    }
}
