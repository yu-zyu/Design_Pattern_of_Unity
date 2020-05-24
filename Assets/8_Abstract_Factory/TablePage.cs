using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AbstractFactoryPattern_factory;
using System.Text;

namespace AbstractFactoryPattern_tablefactory
{
    public class TablePage : Page 
    {
        public TablePage(string title, string author):base(title, author)
        {

        }

        override public string makeHTML()
        {
            StringBuilder buffer = new StringBuilder();
            buffer.Append("<html><head><title>" + title + "</title></head>\n");
            buffer.Append("<body>\n");
            buffer.Append("<h1>" + title + "</h1>\n");
            buffer.Append("<table width=\"80%\" border=\"3\">\n");
            IEnumerator it = content.GetEnumerator();
            while (it.MoveNext())
            {
                Item item = (Item)it.Current;
                buffer.Append("<tr>" + item.MakeHTML() + "</tr>");
            }
            buffer.Append("</table>\n");
            buffer.Append("<hr><address>" + author + "</address>");
            buffer.Append("</body></html>\n");
            return buffer.ToString();
        }
    }
}
