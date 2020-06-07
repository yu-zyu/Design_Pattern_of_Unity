using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CompositePattern2
{
    public class Main : MonoBehaviour
    {
        void Start()
        {
            try
            {
                Directory rootdir = new Directory("root");

                Directory usrdir = new Directory("usr");
                rootdir.Add(usrdir);

                Directory yuki = new Directory("yuki");
                usrdir.Add(yuki);

                File file = new File("Composite.cs", 100);
                yuki.Add(file);
                rootdir.printList();

                Debug.Log("");
                Debug.Log("file = " + file.getFullName());
                Debug.Log("yuki = " + yuki.getFullName());
            }
            catch (FileTreatmentException e)
            {
                Debug.Log(e.StackTrace.ToString());
            }
        }
    }
}
