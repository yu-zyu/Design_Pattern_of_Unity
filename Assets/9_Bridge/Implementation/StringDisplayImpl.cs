using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;

namespace BridgePattern
{
    public class StringDisplayImpl : DisplayImpl
    {
        private string str;
        private int width;
        public StringDisplayImpl(string str)
        {
            this.str = str;
            this.width = Encoding.GetEncoding("utf-8").GetByteCount(str);
        }

        override public void rawOpen()
        {
            printLine();
        }

        override public void rawPrint()
        {
            Debug.Log("|" + str + "|");
        }

        override public void rawClose()
        {
            printLine();
        }

        public void printLine()
        {
            Debug.Log("+");
            for(int i = 0; i < width; i++)
            {
                Debug.Log("-");
            }
            Debug.Log("+");
        }
    }
}
