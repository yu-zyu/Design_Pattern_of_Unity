using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using InterPreterPattern_language_exercises1;
using InterPreterPattern_turtle_exercises1;
using UnityEngine.UI;

namespace InterPreterPattern_exercises1
{
    public class Main : MonoBehaviour
    {
        public TurtleCanvas canvas;
        public  InterpreterFacade facade;
        public Text programTextField;
        public Button button;

        void Start()
        {
            facade = new InterpreterFacade(canvas);
            canvas.setExecutor(facade);
            programTextField.text = "program repeat 3 go right go left end end";
            button.onClick.AddListener(() => { actionPerFormed(); });
       }
   
        public void actionPerFormed()
        {
            parseAndExecute();
        }

        private void parseAndExecute()
        {
            string programText = programTextField.text;
            Debug.Log("programText = " + programText);
            facade.parse(programText);
            canvas.paint();
        }

    }
}
