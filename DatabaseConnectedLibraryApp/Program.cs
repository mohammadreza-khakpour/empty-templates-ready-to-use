using System;

namespace DatabaseConnectedLibraryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LibraryDbContext db = new LibraryDbContext();
            Library library = new Library() {Address="feleke moalem" };
            db.Libraries.Add(library);
            Book book = new Book() {Title="Armageddon", Library=library};
            db.Books.Add(book);
            db.SaveChanges();
            Console.WriteLine("Bye Bye World!\n\t... press Enter to exit ...");
            Console.ReadKey();
        }
    }
}
