using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InterPreterPattern
{
    public class PrimitiveCommandNode : Node
    {
        private string name;
        override public void parse(Context context)
        {
            name = context.currentToken();
            context.skipToken(name);
            if(!name.Equals("go") && !name.Equals("right") && !name.Equals("left"))
            {
                throw new ParseException(name + " is undefined");
            }
        }

        override public string ToString()
        {
            return name;
        }
    }
}
