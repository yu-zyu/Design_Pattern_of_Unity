using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;

namespace BuilderPattern_exercises2

{
    public class TextBuilder : Builder
    {
        private StringBuilder buffer = new StringBuilder();

        override protected void BuildTitle(string title)
        {
            buffer.Append("=============================\n");
            buffer.Append("「" + title + "」\n");
            buffer.Append("\n");
        }

        override protected void BuildString(string str)
        {
            buffer.Append('■' + str + "\n");
            buffer.Append("\n");
        }

        override protected void BuildItems(string[] items)
        {
            for(int i = 0; i < items.Length; i++)
            {
                buffer.Append("　・" + items[i] + "\n");
            }
            buffer.Append("\n");
        }
        
        override protected void BuildDone()
        {
            buffer.Append("=============================\n");
        }

        public string getResult()
        {
            return buffer.ToString();
        }
    }
}
