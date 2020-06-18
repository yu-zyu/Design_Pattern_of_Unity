using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InterPreterPattern_language_exercises1
{
    public class PrimitiveCommandNode : Node
    {
        private string name;
        private Executor executor;

        override public void parse(Context context)
        {
            name = context.currentToken();
            context.skipToken(name);
            executor = context.createExecutor(name);
        }

        override public void execute()
        {
            if(executor == null)
            {
                throw new ExecuteException(name + ": is not defined");
            }
            else
            {
                executor.execute();
            }
        }

        override public string ToString()
        {
            return name;
        }
    }
}
