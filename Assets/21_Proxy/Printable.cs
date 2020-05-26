using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProxyPattern
{
    public interface Printable
    {
        void SetPrinterName(string name);
        string GetPrinterName();
        void Print(string str);
    }
}
