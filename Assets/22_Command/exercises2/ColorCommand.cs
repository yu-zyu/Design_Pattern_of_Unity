using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CommandPattern_command_exercises2;

namespace CommandPattern_drawer_exercises2
{
    public class ColorCommand : Command
    {
        protected Drawable drawable;
        private Color color;

        public ColorCommand(Drawable drawable, Color color)
        {
            this.drawable = drawable;
            this.color = color;
        }

        public void Execute()
        {
            drawable.setColor(color);
        }
    }
}
