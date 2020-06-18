using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InterPreterPattern_language_exercises1
{
    public class InterpreterFacade : Executor 
    {
        private ExecutorFactory factory;
        private Context context;
        private Node programNode;

        public InterpreterFacade(ExecutorFactory factory)
        {
            this.factory = factory;
        }

        public bool parse(string text)
        {
            bool ok = true;
            this.context = new Context(text);
            this.context.setExecutorFactory(factory);
            this.programNode = new ProgramNode();
            try
            {
                programNode.parse(context);
                Debug.Log(programNode.ToString());
            }catch(ParseException e)
            {
                Debug.Log(e.StackTrace.ToString());
                ok = false;
            }
        return ok;
        }

        public void execute()
        {
            try
            {
                programNode.execute();
            }
            catch (ExecuteException e)
            {
                Debug.Log(e);
            }
        }
    }
}
