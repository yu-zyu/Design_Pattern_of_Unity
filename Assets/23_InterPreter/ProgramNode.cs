using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// <program> ::= program <command list>
namespace InterPreterPattern
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

        override public string ToString()
        {
            return "[program " + commandListNode.ToString() + "]";
        }
    }
}

