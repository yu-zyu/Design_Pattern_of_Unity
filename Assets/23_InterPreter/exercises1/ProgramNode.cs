using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// <program> ::= program <command list>
namespace InterPreterPattern_language_exercises1
{
    public class ProgramNode : Node
    {
        private Node commandListNode;
        override public void parse(Context context) 
        {
            context.skipToken("program");
            commandListNode = new CommandListNode();
            commandListNode.parse(context);
        }

        override public void execute()
        {
            commandListNode.execute();
        }

        override public string ToString()
        {
            return "[program " + commandListNode.ToString() + "]";
        }
    }
}

