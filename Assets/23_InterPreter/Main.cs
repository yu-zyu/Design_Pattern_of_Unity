using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

namespace InterPreterPattern
{
    public class Main : MonoBehaviour
    {
        void Start()
        {
            try
            {
                string filename = "program.txt";
                string filePath = Application.dataPath + @"\Resources\" + filename;
                string[] allText = File.ReadAllLines (filePath);
                foreach(var text_line in allText)
                {
                    Debug.Log("text = \"" + text_line + "\"");
                    Node node = new ProgramNode();
                    node.parse(new Context(text_line));
                    Debug.Log("node = " + node.ToString());
                }
            }catch(Exception e)
            {
                Debug.Log(e.StackTrace.ToString());
            }
        }
    }
}
