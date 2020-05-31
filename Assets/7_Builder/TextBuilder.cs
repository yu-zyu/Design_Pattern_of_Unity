using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;

namespace BuilderPattern
{
    public class TextBuilder : Builder
    {
        private StringBuilder buffer = new StringBuilder();
        override public void makeTitle(string title)
        {
            buffer.Append("=============================\n");
            buffer.Append("「" + title + "」\n");
            buffer.Append("\n");
        }

        override public void makeString(string str)
        {
            buffer.Append('■' + str + "\n");
            buffer.Append("\n");
        }

        override public void makeItems(string[] items)
        {
            for(int i = 0; i < items.Length; i++)
            {
                buffer.Append("　・" + items[i] + "\n");
            }
            buffer.Append("\n");
        }
        
        override public void close()
        {
            buffer.Append("=============================\n");
        }

        public string getResult()
        {
            return buffer.ToString();
        }
    }
}
