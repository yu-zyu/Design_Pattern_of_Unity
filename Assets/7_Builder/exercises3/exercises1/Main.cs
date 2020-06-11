using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BuilderPattern_exercises1
{
    public class Main : MonoBehaviour
    {
        void Start()
        {
            string[] target_list = new string[2] {
                "plain",
                "html"
            };

            string target = target_list[1];

            if ("plain" == target)
            {
                TextBuilder textbuilder = new TextBuilder();
                Director director = new Director(textbuilder);
                director.construct();
                string result = textbuilder.getResult();
                Debug.Log(result);
            }
            else if("html" == target)
            {
                HTMLBuilder htmlbuilder = new HTMLBuilder();
                Director director = new Director(htmlbuilder);
                director.construct();
                string filename = htmlbuilder.getResult();
                Debug.Log(filename + "が作成されました。");
            }
            else
            {
                usage();
            }
        }

        public static void usage()
        {
            Debug.Log("Usage: java Main plain    プレーンテキストで文書作成");
            Debug.Log("Usage: java Main html    HTMLファイルで文書作成");
        }
    }
}
