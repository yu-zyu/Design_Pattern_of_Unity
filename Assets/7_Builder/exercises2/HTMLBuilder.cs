using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern_exercises2
{
    public class HTMLBuilder : Builder
    {
        private string filename;

        override protected void BuildTitle(string title)
        {
            filename = Application.dataPath + @"/Resources/" + title + ".html";
            using (StreamWriter writer = File.CreateText(filename)) {
                writer.WriteLine($"<html><head><title>" + title + "</title></head><body>");
                writer.WriteLine($"<h1>" + title + "</h1>");
            }
        }

        override protected void BuildString(string str)
        {
            using (StreamWriter writer = new StreamWriter(this.filename, true, Encoding.GetEncoding("utf-8")))
            {
                writer.WriteLine($"<p>" + str + "</p>");
            }
        }

        override protected void BuildItems(string[] items)
        {
            using (StreamWriter writer = new StreamWriter(this.filename, true, Encoding.GetEncoding("utf-8")))
            {
                writer.WriteLine("<ul>");
                for (int i = 0; i < items.Length; i++)
                {
                    writer.WriteLine($"<li>" + items[i] + "</li>");
                }
                writer.WriteLine("</ul>");
            }
        }

        override protected void BuildDone()
        {
            using (StreamWriter writer = new StreamWriter(this.filename, true, Encoding.GetEncoding("utf-8")))
            {
                writer.WriteLine("</body></html>");
            }
        }

        public string GetResult()
        {
            return filename;
        }
    }
}
