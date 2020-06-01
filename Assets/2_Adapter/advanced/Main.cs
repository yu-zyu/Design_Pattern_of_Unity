using UnityEngine;
using System;
namespace AdapterPattern_advanced

{
    public class Main : MonoBehaviour
    {
        void Start()
        {
            FileIO f = new FileProperties();
            try
            {
                f.readFromFile("input.txt");
                f.setValue("year", "2004");
                f.setValue("month", "4");
                f.setValue("day", "21");
                f.writeToFile("newfile.txt");
            }
            catch (Exception ex)
            {
                Debug.Log(ex.StackTrace.ToString());
            }
        }
    }
}
