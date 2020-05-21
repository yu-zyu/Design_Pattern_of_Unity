using UnityEngine;
using System;

namespace PrototypePattern_framework
{
    public interface Product : ICloneable 
    {
         void Use(string s);
         Product CreateClone(); 

    }
}
