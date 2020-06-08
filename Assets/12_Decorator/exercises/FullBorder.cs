using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;

namespace DecoratorPattern_exercises
{
    public class FullBorder : Border 
    {
        public FullBorder(Display display):base(display)
        {
            
        }

        override public int GetColumns()
        {
            return 1 + display.GetColumns() + 1;
        }

        override public int GetRows()
        {
            return 1 + display.GetRows() + 1;
        }

        override public string GetRowText(int row)
        {
            if(row == 0)
            {
                return "+" + makeLine('-', display.GetColumns()) + "+";
            }
            else if(row == display.GetRows() + 1)
            {
                return "+" + makeLine('-', display.GetColumns()) + "+";
            }
            else
            {
                return "|" + display.GetRowText(row - 1) + "|";
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
