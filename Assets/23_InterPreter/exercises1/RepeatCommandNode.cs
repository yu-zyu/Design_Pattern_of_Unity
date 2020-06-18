using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InterPreterPattern_language_exercises1
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

        override public void execute()
        {
            for(int i = 0; i < number; i++)
            {
                commandListNode.execute();
            }
        }

        override public string ToString()
        {
            return "[repeat " + number + " " + commandListNode.ToString() + "]";
        }
        
    }
}
