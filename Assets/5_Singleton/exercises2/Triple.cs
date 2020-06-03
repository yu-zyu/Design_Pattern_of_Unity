using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SingletonPattern_exercises2
{
    public class Triple
    {
        private static Triple[] triple = new Triple[]
        {
            new Triple(0),
            new Triple(1),
            new Triple(2),
        };

        private int id;

        private Triple(int id)
        {
            Debug.Log("The instance " + id + " is created.");
            this.id = id;
        }

        public static Triple getInstance(int id)
        {
            return triple[id];
        }

        public string toString()
        {
            return "[Triple id=" + id + "]";
        }
    }
}
