using UnityEngine;

namespace TemplateMethodPattern
{
    abstract public class AbstractDisplay
    {
        abstract public void Open();
        abstract public void Print();
        abstract public void Close();
        public void display()
        {
            Open(); 
            for(int i = 0; i < 5; i++)
            {
                Print();
            }
            Close();
        }
    }
}
