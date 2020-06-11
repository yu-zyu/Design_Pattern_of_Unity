using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProxyPattern_exercises1
{
    public class Main : MonoBehaviour
    {
        void Start()
        {
            string className = "ProxyPattern_exercises1.Printer";
            Printable p = new PrinterProxy("Alice", className);
            Debug.Log("名前は現在" + p.GetPrinterName() + "です。");
            p.SetPrinterName("Bob");
            Debug.Log("名前は現在" + p.GetPrinterName() + "です");
            p.Print("Hello, world");
        }
    }
}
