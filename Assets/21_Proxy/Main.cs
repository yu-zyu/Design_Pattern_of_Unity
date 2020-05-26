using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProxyPattern
{
    public class Main : MonoBehaviour
    {
        void Start()
        {
            Printable p = new PrinterProxy("Alice");
            Debug.Log("名前は現在" + p.GetPrinterName() + "です。");
            p.SetPrinterName("Bob");
            Debug.Log("名前は現在" + p.GetPrinterName() + "です");
            p.Print("Hello, world");
        }
    }
}
