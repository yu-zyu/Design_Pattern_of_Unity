using UnityEngine;

namespace IteratorPattern
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
