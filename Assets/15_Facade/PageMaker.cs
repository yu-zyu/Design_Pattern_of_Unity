using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

namespace FacadePattern_pagemaker
{
    public class PageMaker
    {
        private PageMaker()
        {

        }

        public static void makeWelcomePage(string mailaddr, string filename)
        {
            try
            {
                Dictionary<string,string> mailprop = Database.getProperties("maildata");
                string username = mailprop[mailaddr];
                filename = Application.dataPath + @"\Resources\" + filename;
                HtmlWriter writer = new HtmlWriter(new StreamWriter(filename));
                writer.title("Welcome to " + username + "'s page!");
                writer.paragraph(username + "のページへようそこ。");
                writer.paragraph("メールまっていますね。");
                writer.mailto(mailaddr, username);
                writer.close();
                Debug.Log(filename + " is created for " + mailaddr + " (" + username + ")");
            } catch (IOException e)
            {
                Debug.Log(e.StackTrace.ToString());
            }
        }
    }
}
