using System;

using System;

namespace Library
{
    public class LibraryMgr
    {
        public string Taco { get; set; }
        public List<Book> bookList = new List<Book>();

        public LibraryMgr(string taco)
        {
            Taco = taco;
        }

        public void AddBook(Book book)
        {
            bookList.Add(book);
        }
    }

}