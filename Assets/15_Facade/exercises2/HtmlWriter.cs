using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

namespace FacadePattern_pagemaker_exercises2
{
    public class HtmlWriter
    {
        private StreamWriter writer;
        public HtmlWriter(StreamWriter writer)
        {
            this.writer = writer;
        }

        public void title(string title)
        {
            writer.WriteLine("<html>");
            writer.WriteLine("<head>");
            writer.WriteLine("<title>" + title + "</title>");
            writer.WriteLine("</head>");
            writer.WriteLine("<body>\n");
            writer.WriteLine("<h1>" + title + "</h1>\n");
        }

        public void paragraph(string msg)
        {
            writer.WriteLine("<p>" + msg + "</p>\n");
        }

        public void link(string href, string caption)
        {
            paragraph("<a href=\"" + href + "\">" + caption + "</a>");
        }

        public void mailto(string mailaddr, string username)
        {
            link("mailto:" + mailaddr, username);
        }

        public void close()
        {
            writer.WriteLine("</body>");
            writer.WriteLine("</html>\n");
            writer.Close();
        }

    }
}
