using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AbstractFactoryPattern_factory_exercises;
using System.Text;

namespace AbstractFactoryPattern_listfactory_exercises
{
    public class ListPage : Page
    {
        public ListPage(string title, string author) : base(title, author)
        {
            
        }

        override public string makeHTML()
        {
            StringBuilder buffer = new StringBuilder();
            buffer.Append("<html><head><title>" + title + "</title></head>\n");
            buffer.Append("<body>\n");
            buffer.Append("<h1>" + title + "</h1>\n");
            buffer.Append("<ul>\n");
            IEnumerator it = content.GetEnumerator();
            while (it.MoveNext())
            {
                Item item = (Item)it.Current;
                buffer.Append(item.MakeHTML());
            }
            buffer.Append("</ul>\n");
            buffer.Append("<hr><address>" + author + "</address>");
            buffer.Append("</body></html>\n");
            return buffer.ToString();
        }
    }
}
