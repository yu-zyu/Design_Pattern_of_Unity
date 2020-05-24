using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CompositePattern
{
    public class FileTreatmentException : System.Exception 
    {
        public FileTreatmentException()
        {

        }

        public FileTreatmentException(string msg):base(msg)
        {
        }
    }
}
