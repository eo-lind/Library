using System;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Book newBook1 = new Book("The Amazing Adventures of Kavalier and Clay", "Michael Chabon", "Fiction");

                Console.WriteLine($"{newBook1.Title} by {newBook1.Author} ({newBook1.Genre}");
        }
    }
}