using UnityEngine;

namespace IteratorPattern
{
    public interface Iterator
    {
        bool hasNext();
        Object next();
    }
}
