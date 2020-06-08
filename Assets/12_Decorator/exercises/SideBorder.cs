using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DecoratorPattern_exercises
{
    public class SideBorder : Border 
    {
        private char borderChar;
        public SideBorder(Display display, char ch):base(display)
        {
            this.borderChar = ch;
        }

        override public int GetColumns()
        {
            return 1 + display.GetColumns() + 1;
        }

        override public int GetRows()
        {
            return display.GetRows();
        }

        override public string GetRowText(int row)
        {
            return borderChar + display.GetRowText(row) + borderChar;
        }
    }
}
