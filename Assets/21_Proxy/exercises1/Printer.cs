using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Threading;

namespace ProxyPattern_exercises1
{
    public class Printer : Printable
    {
        private string name;

        public Printer()
        {
            heavyJob("Printerのインスタンスを生成中");
        }

        public Printer(string name)
        {
            this.name = name;
            heavyJob("Printerのインスタンス(" + name + ")を生成中");
        }

        public void SetPrinterName(string name)
        {
            this.name = name;
        }

        public string GetPrinterName()
        {
            return name;
        }

        public void Print(string str)
        {
            Debug.Log("=== " + name + " ===");
            Debug.Log(str);
        }

        private void heavyJob(string msg)
        {
            Debug.Log(msg);
            for(int i = 0; i < 5; i++)
            {
                try
                {
                    Thread.Sleep(1000);
                }
                catch(Exception)
                {

                }
                Debug.Log(".");
            }
            Debug.Log("完了。");
        }
    }
}
