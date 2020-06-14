using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CommandPattern_command_exercises2;

namespace CommandPattern_drawer_exercises2
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
            var ball = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            ball.GetComponent<Renderer>().material.color = color;
            ball.transform.localScale = new Vector3(1, 1, 1);
            ball.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(x, y, 10));
            history.ball_list.Add(ball);
        }

        public void setColor(Color color)
        {
            this.color = color;
        }
    }
}
