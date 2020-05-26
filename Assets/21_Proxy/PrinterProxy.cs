using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProxyPattern
{
    public class PrinterProxy : Printable
    {
        private string name;
        private Printer real;

        public PrinterProxy(string name)
        {
            this.name = name;
        }

        public void SetPrinterName(string name)
        {
            if (real != null)
            {
                real.SetPrinterName(name);
            }
            this.name = name;
        }

        public string GetPrinterName()
        {
            return name;
        }

        public void Print(string str)
        {
            realize();
            real.Print(str);
        }

        private void realize()
        {
            if (real == null)
            {
                real = new Printer(name);
            }
        }

    }
}
