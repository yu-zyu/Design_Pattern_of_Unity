using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InterPreterPattern
{
    public class RepeatCommandNode : Node
    {
        private int number;
        private Node commandListNode;

        override public void parse(Context context)
        {
            context.skipToken("repeat");
            number = context.currentNumber();
            context.nextToken();
            commandListNode = new CommandListNode();
            commandListNode.parse(context);
        }

        override public string ToString()
        {
            return "[repeat " + number + " " + commandListNode.ToString() + "]";
        }
        
    }
}
