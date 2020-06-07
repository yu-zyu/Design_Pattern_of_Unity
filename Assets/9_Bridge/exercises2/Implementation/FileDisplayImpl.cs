using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

namespace BridgePattern_exercises2
{
    public class FileDisplayImpl : DisplayImpl
    {
        private string filename;
        private string filepath;

        public FileDisplayImpl(string filename)
        {
            this.filename = filename;
        }

        override public void rawOpen()
        {
             filepath = Application.dataPath + @"/Resources/" + filename;
                Debug.Log("=-=-=-=-=-= " + filename + " =-=-=-=-=-=");
        }

        override public void rawPrint()
        {
            using (var reader = new StreamReader(filepath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Debug.Log("> " + line);
                }
            }
        }

        override public void rawClose()
        {
            Debug.Log("=-=-=-=-=-= ");
        }
    }
}
