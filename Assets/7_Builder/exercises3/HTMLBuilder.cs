using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern_exercises3
{
    public class HTMLBuilder : Builder
    {
        private string filename;
        public void makeTitle(string title)
        {
            filename = Application.dataPath + @"/Resources/" + title + ".html";
            using (StreamWriter writer = File.CreateText(filename)) {
                writer.WriteLine($"<html><head><title>" + title + "</title></head><body>");
                writer.WriteLine($"<h1>" + title + "</h1>");
            }
        }

        public void makeString(string str)
        {
            using (StreamWriter writer = new StreamWriter(this.filename, true, Encoding.GetEncoding("utf-8")))
            {
                writer.WriteLine($"<p>" + str + "</p>");
            }
        }

        public void makeItems(string[] items)
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

        public void close()
        {
            using (StreamWriter writer = new StreamWriter(this.filename, true, Encoding.GetEncoding("utf-8")))
            {
                writer.WriteLine("</body></html>");
            }
        }

        public string getResult()
        {
            return filename;
        }
    }
}
