using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InterPreterPattern_language_exercises1;

namespace InterPreterPattern_turtle_exercises1
{
    public class TurtleCanvas : MonoBehaviour, ExecutorFactory
    {
        public const int UNIT_LENGTH = 1;
        const int DIRECTION_UP = 0;
        const int DIRECTION_RIGHT = 3;
        const int DIRECTION_DOWN = 6;
        const int DIRECTION_LEFT = 9;
        const int RELATIVE_DIRECTION_RIGHT = 3;
        const int RELATIVE_DIRECTION_LEFT = -3;
        private int direction = 0;
        private Vector3 position;
        private Executor executor;

        // Start is called before the first frame update
        void Start()
        {

        }

        public void setExecutor(Executor executor)
        {
            this.executor = executor;
        }

       public void setRelativeDirection(int relativeDirection)
        {
            setDirection(direction + relativeDirection);
        }

        public void setDirection(int direction)
        {
            if (direction < 0)
            {
                direction = 12 - (-direction) % 12;
            }
            else
            {
                direction = direction % 12;
            }
            this.direction = direction % 12;
        }

       public void go(int length)
        {
            float newx = position.x;
            float newy = position.y;

            var cube = GameObject.CreatePrimitive(PrimitiveType.Cube);

            switch (direction)
            {
                case DIRECTION_UP:
                    newy += length;
                    break;
                case DIRECTION_RIGHT:
                    newx += length;
                    break;
                case DIRECTION_DOWN:
                    newy -= length;
                    break;
                case DIRECTION_LEFT:
                    newx -= length;
                    break;
                default:
                    break;
            }
            cube.transform.position = new Vector3(newx, newy, 0);

          //  Graphics g = getGraphics();
          //  if (g != null)
          //  {
          //      g.drawLine(position.x, position.y, newx, newy);
          //      g.fillOval(newx - RADIUS, newy - RADIUS, RADIUS * 2 + 1, RADIUS * 2 + 1);
          //  }
            position.x = newx;
            position.y = newy;
        }

        public Executor createExecutor(string name)
        {
            if (name.Equals("go"))
            {
                return new GoExecutor(this);
            } else if (name.Equals("right"))
            {
                return new DirectionExecutor(this, RELATIVE_DIRECTION_RIGHT);
            } else if (name.Equals("left"))
            {

                return new DirectionExecutor(this, RELATIVE_DIRECTION_LEFT);
            }
            else
            {
                return null;
            }
        }

        public void Initialized()
        {
        //    Vector2 size = getSize();
        //    position = new Vector3(size.x / 2, size.y / 2);
        //    direction = 0;
        //    setForeground(Color.red);
        //    setBackground(Color.white);
        //    Graphics g = new getGraphics();
        //    if (g != null)
        //    {
        //        g.clearRect(0, 0, size.width, size.height);
        //    }
        }

        public void paint()
        {
            Initialized();
            if (executor != null)
            {
                try
                {
                    executor.execute();
                } catch (ExecuteException e)
                {
                    Debug.Log(e.StackTrace.ToString());
                }
            }
        }
    }

        abstract class TurtleExecutor : Executor
        {
            protected TurtleCanvas canvas;

            public TurtleExecutor(TurtleCanvas canvas)
            {
                this.canvas = canvas;
            }

            public abstract void execute();
        }

        class GoExecutor : TurtleExecutor
        {
            public GoExecutor(TurtleCanvas canvas):base(canvas)
            {
                base.canvas = canvas;
            }

           override public void execute()
            {
                canvas.go(TurtleCanvas.UNIT_LENGTH);
            }
        }

        class DirectionExecutor : TurtleExecutor
        {
            private int relativeDirection;

            public DirectionExecutor(TurtleCanvas canvas, int relativeDirection) :base(canvas)
            {
                this.relativeDirection = relativeDirection;
            }

            override public void execute()
            {
                canvas.setRelativeDirection(relativeDirection);
            }
        }
}
