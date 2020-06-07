using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace StrategyPattern_exercises4
{
    public class SelectionSorter : Sorter
    {
        public void sort(string[] data)
        {
            for(int i = 0; i < data.Length -1; i++)
            {
                int min = i;
                for (int j = i + 1; j < data.Length; j++)
                {
                    if(data[min].CompareTo(data[j]) > 0)
                    {
                        min = j;
                    }
                }

                string passingplace = data[min];
                data[min] = data[i];
                data[i] = passingplace;
            }
        }
    }
}
