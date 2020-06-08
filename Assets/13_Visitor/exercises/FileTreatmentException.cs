using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VisitorPattern_exercises
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
