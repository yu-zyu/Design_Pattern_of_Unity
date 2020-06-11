using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProxyPattern_exercises1
{
    public interface Printable
    {
        void SetPrinterName(string name);
        string GetPrinterName();
        void Print(string str);
    }
}
