using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

namespace FacadePattern_pagemaker_exercises2
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

        public static void makeLinkPage(string filename)
        {
            try
            {
                filename = Application.dataPath + @"\Resources\" + filename;
                HtmlWriter writer = new HtmlWriter(new StreamWriter(filename));
                writer.title("Link page");
                Dictionary<string, string> mailprops = Database.getProperties("maildata");
               // enum en = mailprop;
                foreach (KeyValuePair<string, string> mailprop in mailprops)
                {
                    writer.mailto(mailprop.Key, mailprop.Value);
                }
                writer.close();
                Debug.Log(filename + " is created.");

            }catch(IOException e)
            {
                Debug.Log(e.StackTrace.ToString());
            }
        }
    }
}
