using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CommandPattern_command;

namespace CommandPattern_drawer
{
    public class DrawCommand : Command
    {
        protected Drawable drawable;
        private Vector3 position;

        public DrawCommand(Drawable Drawable, Vector3 Position)
        {
            this.drawable = Drawable;
            this.position = Position;
        }
        
        public void Execute()
        {
            drawable.Draw(position.x, position.y);
        }
    }
}
