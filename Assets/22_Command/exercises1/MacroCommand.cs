using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommandPattern_command_exercises1
{
    public class MacroCommand : Command
    {
        private Stack commands = new Stack();

        public void Execute()
        {
            IEnumerator it = commands.GetEnumerator();
            while (it.MoveNext())
            {
                ((Command)it.Current).Execute();
            }
        }

        public void append(Command cmd)
        {
            if(cmd != this)
            {
                commands.Push(cmd);
                Debug.Log("命令履歴数　" + commands.Count);
            }
        }

        public void undo()
        {
            if (commands.Count != 0)
            {
                commands.Pop();
            }
        }

        public void clear()
        {
            commands.Clear();
        }
    }
}
