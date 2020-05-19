using UnityEngine;

namespace TemplateMethodPattern
{
    public class CharDisplay : AbstractDisplay 
    {
        private char ch;
        public CharDisplay(char ch)
        {
            this.ch = ch;
        }
        
        override public void Open()
        {
            Debug.Log("<<");
        }
        
        override public void Print()
        {
            Debug.Log(ch);
        }

        override public void Close()
        {
            Debug.Log(">>");
        }
    }
}
