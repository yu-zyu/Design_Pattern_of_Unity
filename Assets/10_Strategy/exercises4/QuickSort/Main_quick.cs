﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StrategyPattern_exercises4
{
    public class Main_quick : MonoBehaviour
    {
        void Start()
        {
            string[] data =
            {
                "Dumpty", "Bowman", "Carroll", "Elfland", "Alice",
            };
            SortAndPrint sap = new SortAndPrint(data, new QuickSorter());
            sap.execute();
        }
    }
}
