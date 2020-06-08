using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;

namespace DecoratorPattern_exercises2
{
    public class MultiStringDisplay : Display
    {
        private ArrayList body = new ArrayList();
        private int columns = 0;

        public void add(string msg)
        {
            body.Add(msg);
            updateColumn(msg);
        }

        override public int GetColumns()
        {
            return columns;
        }

        override public int GetRows()
        {
            return body.Count;
        }

        override public string GetRowText(int row)
        {
            return (string)body[row];
        }

        private void updateColumn(string msg)
        {
            if(Encoding.GetEncoding("utf-8").GetByteCount(msg) > columns)
            {
                columns = Encoding.GetEncoding("utf-8").GetByteCount(msg);
            }
            for(int row = 0; row < body.Count; row++)
            {
                int fills = columns - Encoding.GetEncoding("utf-8").GetByteCount((string)body[row]);
                if(fills > 0)
                {
                    body[row] = body[row] + spaces(fills);
                }
            }
        }

        private string spaces(int count)
        {
            StringBuilder buf = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                buf.Append(' ');
            }
            return buf.ToString();
        }
    }
}
