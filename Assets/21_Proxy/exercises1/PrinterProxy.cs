using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace ProxyPattern_exercises1
{
    public class PrinterProxy : Printable
    {
        private string name;
        private Printable real;
        private string className;

        public PrinterProxy(string name, string className)
        {
            this.name = name;
            this.className = className;
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
            try
            {
            Type type = Type.GetType(className);
            real = (Printable)Activator.CreateInstance(type);
                real.SetPrinterName(name);

            }
            catch (Exception e)
            {
                Debug.Log("クラス　" + className + "　が見つかりません。");
                Debug.Log(e.StackTrace.ToString());
            }
       
        }

    }
}
