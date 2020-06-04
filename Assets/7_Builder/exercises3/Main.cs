using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BuilderPattern_exercises3
{
    public class Main : MonoBehaviour
    {
        void Start()
        {
                GUIBuilder textbuilder = new GUIBuilder();
                Director director = new Director(textbuilder);
                director.construct();
                string result = textbuilder.getResult();
                Debug.Log(result + "を作成しました。");
        }
    }
}
