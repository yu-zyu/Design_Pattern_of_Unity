using UnityEngine;

namespace IteratorPattern_advanced
{
    public class Book
    {
        public GameObject book;
        private string name;

        public Book(string name)
        {
            book = GameObject.CreatePrimitive(PrimitiveType.Cube);
            this.name = name;
        }

        public void setPosition(Vector3 transform)
        {
            this.book.transform.position = transform; 
        }
 

        public string getName()
        {
            return name;
        }
    }
}