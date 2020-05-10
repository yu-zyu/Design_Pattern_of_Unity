using UnityEngine;

namespace IteratorPattern_advanced
{
    public interface Iterator
    {
        bool hasNext();
        Object next();
    }
}
