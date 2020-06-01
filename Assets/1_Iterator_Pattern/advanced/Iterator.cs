using UnityEngine;

namespace IteratorPattern_advanced
{
    public interface Iterator
    {
        bool hasNext();
        object next();
    }
}
