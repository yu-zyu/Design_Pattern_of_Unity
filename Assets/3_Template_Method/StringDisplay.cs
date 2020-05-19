using UnityEngine;
using System.Text;
namespace TemplateMethodPattern
{
    public class StringDisplay : AbstractDisplay
    {
        private string str;
        private int width;
        public StringDisplay(string str)
        {
            this.str = str;
            this.width = Encoding.ASCII.GetByteCount(str);
        }

        override public void Open()
        {
            printLine();
        }

        override public void Print()
        {
            Debug.Log("|" + str + "|");
        }

        override public void Close()
        {
            printLine();
        }

        private void printLine()
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
