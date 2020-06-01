using UnityEngine;

namespace IteratorPattern_exercises
{
    public class Book
    {
        private string name;

        public Book(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return name;
        }
    }
}