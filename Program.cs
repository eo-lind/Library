using System;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Book newBook1 = new Book("The Amazing Adventures of Kavalier and Clay", "Michael Chabon", "Fiction");
            Book newBook2 = new Book("Rosemary's Baby", "Ira Levin", "Fiction");
            Book newBook3 = new Book("Valley of the Dolls", "Jacqueline Susann", "Fiction");
            
            LibraryMgr newLibrary = new LibraryMgr("Taco");
            Console.WriteLine($"Welcome to the {newLibrary.LibraryName} Library Management System");
            newLibrary.AddBook(newBook1);
            newLibrary.AddBook(newBook2);
            newLibrary.AddBook(newBook3);

            Console.WriteLine(newLibrary);
        }
    }
}