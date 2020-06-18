using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InterPreterPattern_language_exercises1
{
    public abstract class Node : Executor
    {
        public abstract void execute();
        public abstract void parse(Context context);

    }
}
