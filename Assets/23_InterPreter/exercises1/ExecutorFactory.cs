using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InterPreterPattern_language_exercises1
{
    public interface ExecutorFactory
    {
        Executor createExecutor(string name);
    }
}
