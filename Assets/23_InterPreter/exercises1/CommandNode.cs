using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InterPreterPattern_language_exercises1
{
    public class CommandNode : Node 
    {
        private Node node;
        override public void parse(Context context)
        {
            if (context.currentToken().Equals("repeat"))
            {
                node = new RepeatCommandNode();
                node.parse(context);
            }
            else
            {
                node = new PrimitiveCommandNode();
                node.parse(context);
            }
        }

        override public void execute()
        {
            node.execute();
        }

        override public string ToString()
        {
            return node.ToString();
        }
        
    }
}
