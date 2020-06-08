using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DecoratorPattern_exercises2
{
    public abstract class Display
    {
        public abstract int GetColumns();
        public abstract int GetRows();
        public abstract string GetRowText(int row);
        public void show()
        {
            for(int i = 0; i < GetRows(); i++)
            {
                Debug.Log(GetRowText(i));
            }
        }
    }
}
