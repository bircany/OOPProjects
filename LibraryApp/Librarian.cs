using System;
using System.Collections.Generic;

namespace LibraryApp
{
    public class Librarian
    {
        public int EmployeeId { get; set; }
        private List<Book> libraryBooks = new List<Book>();
        public void AddBook(Book book) 
        {
            libraryBooks.Add(book);
            Console.WriteLine($"{book.Title} kütüphaneye eklendi.");

        }
        public void RemoveBook(Book book)
        {
            libraryBooks.Remove(book);
            Console.WriteLine($"{book.Title} kütüphaneden çıkarıldı.");
        }
        public void ShowLibraryBooks()
        {
            Console.WriteLine("Kütüphanedeki Kitaplar : ");
            foreach (Book book in libraryBooks)
            {
                Console.WriteLine(book.GetDescription());
            }
        }
    }
}
