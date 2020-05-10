﻿using UnityEngine;

namespace IteratorPattern{

    public class Main : MonoBehaviour
    {
    // Start is called before the first frame update
        void Start()
        {
            BookShelf bookShelf = new BookShelf(4);
            bookShelf.appendBook(new Book("Around the World in  Days"));
            bookShelf.appendBook(new Book("Bible"));
            bookShelf.appendBook(new Book("Ciderella"));
            bookShelf.appendBook(new Book("Daddy-Long-Legs"));
            Iterator it = bookShelf.iterator();
            while (it.hasNext())
            {
                Book book = (Book)it.next();
                Debug.Log(book.getName());
            }
        }
    }
}