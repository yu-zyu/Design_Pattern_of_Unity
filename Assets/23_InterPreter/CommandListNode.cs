using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// <command list> ::= <command>* end
namespace InterPreterPattern
{
    public class CommandListNode : Node
    {
        private ArrayList list = new ArrayList();
        override public void parse(Context context)
        {
            while(true)
            {
                if (context.currentToken() == null)
                {
                    throw new ParseException("Missing 'end'");
                }
                else if (context.currentToken().Equals("end"))
                {
                    context.skipToken("end");
                    break;
                }
                else
                {
                    Node commandNode = new CommandNode();
                    commandNode.parse(context);
                    list.Add(commandNode);
                }
            }
        }

       override public string ToString()
       {
            string text = "";
            foreach(Node str in list)
            {
                text += " " + str.ToString();

            }
            text = "[" + text + "]";
            return text;
       }
    }
}
