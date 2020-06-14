using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommandPattern_drawer_exercises2
{
    public interface Drawable
    {
        void init();
        void Draw(float x, float y);
        void setColor(Color color);
    }
}
