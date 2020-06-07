using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;

namespace AbstractFactoryPattern_factory_exercises
{
    public abstract class Page
    {
        protected string title;
        protected string author;
        protected ArrayList content = new ArrayList();
        public Page(string title, string author)
        {
            this.title = title;
            this.author = author;
        }

        public void add(Item item)
        {
            content.Add(item);
        }

        public void output()
        {
            string filename = Application.dataPath + @"/Resources/" + title + ".html";
            using (StreamWriter writer = new StreamWriter(filename, true, Encoding.GetEncoding("utf-8")))
                writer.Write(this.makeHTML());
                Debug.Log(filename + "　を作成しました。");
        }

        public abstract string makeHTML();
    }
}
