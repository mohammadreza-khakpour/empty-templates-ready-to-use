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
            DeleteFelekeMoalemLibrary();
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
            Book book2 = new Book() { Title = "Bees Colony", Library = library };
            db.Books.Add(book);
            db.Books.Add(book2);
            Book book3 = new Book() { Title = "life of pi", Library = library2 };
            db.Books.Add(book3);
            db.SaveChanges();
            Console.WriteLine("AddLibrariesWithBooks done.");
        }
        static void DeleteFelekeMoalemLibrary()
        {
            var theLibrary = db.Libraries.Where(_=>_.Address== "feleke moalem").Single();
            db.Libraries.Remove(theLibrary);
            db.SaveChanges();
            Console.WriteLine("DeleteFelekeMoalemLibrary done.");
        }
        static void DeleteFelekeMoalemBooks()
        {
            var books = db.Books.Where(_ => _.Library.Address == "feleke moalem").ToList();
            db.Books.RemoveRange(books);
            db.SaveChanges();
            Console.WriteLine("DeleteFelekeMoalemBooks done.");
        }
    }
}
