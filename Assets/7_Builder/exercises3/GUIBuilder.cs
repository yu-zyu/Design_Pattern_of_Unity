using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using UnityEngine.UI;

namespace BuilderPattern_exercises3
{
    public class GUIBuilder : Builder
    {
        private GameObject canvas;
        private Vector3 position;

        public void makeText(string title, Vector3 position)
        {
            GameObject text = new GameObject();
            text.transform.parent = canvas.transform;
            text.transform.position = position;
            text.name = "text";
            Text textComponent = text.AddComponent<Text>();
            textComponent.text = title;
            textComponent.color = Color.black;
            textComponent.font = Resources.GetBuiltinResource(typeof(Font), "Arial.ttf") as Font;
            position = new Vector3(0, 0, 0);
        }

        public void makeTitle(string title)
        {
            canvas = new GameObject("Canvas");
            Canvas canvasComponent = canvas.AddComponent<Canvas>();
            canvasComponent.renderMode = RenderMode.ScreenSpaceOverlay;
            canvas.AddComponent<CanvasScaler>();
            canvas.AddComponent<GraphicRaycaster>();
            makeText(title, position);
        }

        public void makeString(string str)
        {
            position -= new Vector3(0, 30, 0);
            makeText(str, position);
        }

        public void makeItems(string[] items)
        {
            foreach (string item in items)
            {
                position -= new Vector3(0, 30, 0);
                makeText(item, position);
            }
        }

        public void close()
        {
            position -= new Vector3(0, 30, 0);
            makeText("end", position);

        }

        public string getResult()
        {
            return canvas.name; 
        }
    }
}
