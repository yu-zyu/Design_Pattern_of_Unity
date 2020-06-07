using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StrategyPattern_exercises4
{
    public class SortAndPrint
    {
        string[] data;
        Sorter sorter;

        public SortAndPrint(string[] data, Sorter sorter)
        {
            this.data = data;
            this.sorter = sorter;
        }

        public void execute()
        {
            print();
            sorter.sort(data);
            print();
        }

        public void print()
        {
            for(int i = 0; i < data.Length; i++)
            {
                Debug.Log(data[i] + ", ");
            }

            Debug.Log("");
        }
    }
}
