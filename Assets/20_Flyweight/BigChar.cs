using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using System.IO;

namespace FlyweightPattern
{
    public class BigChar
    {
        private char charname;
        private string fontdata;

        public BigChar(char charname)
        {
            this.charname = charname;

            string filename = Application.dataPath + @"/Resources/" + "big" + charname + ".txt";
            using (var reader = new StreamReader(filename))
            {
                string line;
                StringBuilder buf = new StringBuilder();

                while ((line = reader.ReadLine()) != null)
                {
                    buf.Append(line);
                    buf.Append("\n");
                }
                this.fontdata = buf.ToString();
            }
        }

        public void print()
        {
            Debug.Log(fontdata);
        }
    }
}
