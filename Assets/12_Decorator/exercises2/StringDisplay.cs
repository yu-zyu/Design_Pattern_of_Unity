using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;

namespace DecoratorPattern_exercises2
{
    public class StringDisplay : Display
    {
        private string str;
        public StringDisplay(string str)
        {
            this.str = str;
        }

        override public int GetColumns()
        {
            return Encoding.GetEncoding("utf-8").GetByteCount(str);
        }

        override public int GetRows()
        {
            return 1;
        }

        override public string GetRowText(int row)
        {
            if (row == 0)
            {
                return str;
            }
            else
            {
                return null;
            }
        }

    }
}
