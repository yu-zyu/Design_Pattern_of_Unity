using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CompositePattern2
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
