using System;

using System;

namespace Library
{
    public class LibraryMgr
    {
        public string LibraryName { get; set; }
        private List<Book> _books = new List<Book>();

        public LibraryMgr(string libraryName)
        {
            LibraryName = libraryName;
        }

        public override string ToString()
        {
            string bookString = "";

            foreach (Book book in _books)
            {
                bookString += $"|  {book.Title}, by {book.Author}  |  ";
            };
            return bookString;
        }
        
        public void AddBook(Book book)
        {
            _books.Add(book);
        }

    }

}