using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VisitorPattern_exercises
{
    public class Main : MonoBehaviour
    {
        void Start()
        {
            try
            {
                Debug.Log("Making root entries...");
                Directory rootdir = new Directory("root");
                Directory bindir = new Directory("bin");
                Directory tmpdir = new Directory("tmp");
                Directory usrdir = new Directory("usr");
                rootdir.Add(bindir);
                rootdir.Add(tmpdir);
                rootdir.Add(usrdir);
                bindir.Add(new File("vi", 10000));
                bindir.Add(new File("latex", 20000));
                rootdir.Accept(new ListVisitor());

                Debug.Log("");
                Debug.Log("Making user entries...");
                Directory yuki = new Directory("yuki");
                Directory hanako = new Directory("hanako");
                Directory tomura = new Directory("tomura");
                usrdir.Add(yuki);
                usrdir.Add(hanako);
                usrdir.Add(tomura);
                yuki.Add(new File("diary.html", 100));
                yuki.Add(new File("Compsite.java", 200));
                hanako.Add(new File("memo.tex", 300));
                hanako.Add(new File("index.html", 350));
                tomura.Add(new File("game.doc", 400));
                tomura.Add(new File("junk.mail", 500));

                FileFindVisitor ffv = new FileFindVisitor(".html");
                rootdir.Accept(ffv);

                Debug.Log("HTML files are:");

                IEnumerator it = ffv.getFoundFiles();
                while (it.MoveNext())
                {
                    File file = (File)it.Current;
                    Debug.Log(file.toString());
                }

            }
            catch (FileTreatmentException e)
            {
                Debug.Log(e.StackTrace.ToString());
            }

        }

    }
}
