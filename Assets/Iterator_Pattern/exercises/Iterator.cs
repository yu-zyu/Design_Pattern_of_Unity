using UnityEngine;

namespace IteratorPattern_exercises
{
    public interface Iterator
    {
        bool hasNext();
        Object next();
    }
}
