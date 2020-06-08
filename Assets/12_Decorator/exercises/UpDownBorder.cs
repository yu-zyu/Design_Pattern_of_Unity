using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;

namespace DecoratorPattern_exercises
{
    public class UpDownBorder : Border
    {
        private char borderChar;

        public UpDownBorder(Display display, char ch) : base(display)
        {
            this.borderChar = ch;
        }

        override public int GetColumns()
        {
            return display.GetColumns();
        }

        override public int GetRows()
        {
            return 1 + display.GetRows() + 1;
        }

        override public string GetRowText(int row)
        {
            if(row == 0 || row == GetRows() - 1)
            {
                return makeLine(borderChar, GetColumns());
            }
            else
            {
                return display.GetRowText(row - 1);
            }
        }

        private string makeLine(char ch, int count)
        {
            StringBuilder buf = new StringBuilder();
            for(int i = 0; i < count; i++)
            {
                buf.Append(ch);
            }
            return buf.ToString();
        }
    }
}
