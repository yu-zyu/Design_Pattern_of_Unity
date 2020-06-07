using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AbstractFactoryPattern_factory_exercises;
using System.Text;

namespace AbstractFactoryPattern_tablefactory_exercises
{


    public class TableTray : Tray
    {
        public TableTray(string caption) : base(caption)
        {

        }

        override public string MakeHTML()
        {
            StringBuilder buffer = new StringBuilder();
            buffer.Append("<td>");
            buffer.Append("<table width=\"100%\" border=\"1\"><tr>");
            buffer.Append("<td bgcolor=\"#ccccc\" align=\"center\" colspan=\"" + tray.Count + "\"><b>" + caption + "</b></td>");
            buffer.Append("</tr>\n");
            buffer.Append("<tr>\n");
            IEnumerator it = tray.GetEnumerator();
            while (it.MoveNext())
            {
                Item item = (Item)it.Current;
                buffer.Append(item.MakeHTML());
            }
            buffer.Append("</tr></tabke>");
            buffer.Append("</td>");
            return buffer.ToString();
        }
    }
}
