using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CommandPattern_command_exercises1;

namespace CommandPattern_drawer_exercises1
{
    public class DrawCanvas : MonoBehaviour, Drawable
    {
        public GameObject canvas;
        private Color color;
        private MacroCommand history;

        public void CanvasStart(int width, int height, MacroCommand history)
        {
            canvas.transform.localScale = new Vector3(width, 1, height);
            this.history = history;
        }

        public void paint(Graphics g)
        {
            history.Execute();
        }

        public void init()
        {
            color = Color.red;
            history.append(new ColorCommand(this, color));
        }

        public void Draw(float x, float y)
        {
            var cube = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            cube.GetComponent<Renderer>().material.color = color;
            cube.transform.localScale = new Vector3(1, 1, 1);
            cube.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(x, y, 10));
        }

        public void setColor(Color color)
        {
            this.color = color;
        }
    }
}
