using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VisitorPattern_exercises3
{
    public class Main : MonoBehaviour
    {
        void Start()
        {
            try
            {
                Directory root1 = new Directory("root1");
                root1.Add(new File("diary.html", 10));
                root1.Add(new File("index.html", 20));

                Directory root2 = new Directory("root2");
                root2.Add(new File("diary.html", 1000));
                root2.Add(new File("index.html", 2000));

                ElementArrayList list = new ElementArrayList();
                list.Add(root1);
                list.Add(root2);
                list.Add(new File("etc.html", 1234));

                list.Accept(new ListVisitor());
            }
            catch (FileTreatmentException e)
            {
                Debug.Log(e.StackTrace.ToString());
            }

        }

    }
}
