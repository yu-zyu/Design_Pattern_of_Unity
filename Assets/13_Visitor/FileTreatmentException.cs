using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VisitorPattern
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
