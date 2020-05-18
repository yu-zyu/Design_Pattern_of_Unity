using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IteratorPattern_advanced
{
    public class Main : MonoBehaviour
    {
    // Start is called before the first frame update
        void Start()
        {
            BookShelf bookShelf = new BookShelf();
            bookShelf.appendBook(new Book("Around the World in  Days"));
            bookShelf.appendBook(new Book("Bible"));
            bookShelf.appendBook(new Book("Ciderella"));
            bookShelf.appendBook(new Book("Daddy-Long-Legs"));
            bookShelf.appendBook(new Book("End"));
            Iterator it = bookShelf.iterator();
            float positonX = 0;
            float positonY = 0;
            float positonZ = 0;
            while (it.hasNext())
            {
                Book book = (Book)it.next();
                book.setPosition(new Vector3(positonX, positonY, positonZ));
                Debug.Log(book.getName());
                positonZ += 1.5f;
            }
        }
    }
}