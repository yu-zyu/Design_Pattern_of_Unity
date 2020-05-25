using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DecoratorPattern 
{
    public abstract class Border : Display 
    {
        protected Display display;
        protected Border(Display display)
        {
            this.display = display;
        }
    }
}
