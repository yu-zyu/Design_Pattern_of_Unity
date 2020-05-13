using UnityEngine;

namespace IteratorPattern {
    public class BookShelfIterator : Iterator
    {
        private BookShelf bookShelf;
        private int index;

        public BookShelfIterator(BookShelf bookShelf)
        {
            this.bookShelf = bookShelf;
            this.index = 0;
        }

        public bool hasNext()
        {
            if (index < bookShelf.getLength())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Object next()
        {
            Book book = bookShelf.getBookAt(index);
            index++;
            return book;
        }
    }
}
