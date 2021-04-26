using System;
using System.Collections.Generic;
using System.Linq;

namespace DatabaseConnectedLibraryApp
{
    class Program
    {
        static LibraryDbContext db = new LibraryDbContext();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Bye Bye World!\n\t... press Enter to exit ...");
            Console.ReadKey();
        }
        static void AddLibrariesWithBooks()
        {
            
            Library library = new Library() { Address = "feleke moalem" };
            db.Libraries.Add(library);
            Library library2 = new Library() { Address = "feleke atlasi" };
            db.Libraries.Add(library2);
            Book book = new Book() { Title = "Armageddon", Library = library };
            db.Books.Add(book);
            Book book2 = new Book() { Title = "life of pi", Library = library2 };
            db.Books.Add(book2);
            db.SaveChanges();
        }
    }
}
