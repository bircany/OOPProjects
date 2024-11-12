using System;
using System.Collections.Generic;

namespace LibraryApp
{
    public class Member
    {
        public String Name { get; set; }
        public int MemberId { get; set; }
        private List<Book> borrowedBooks = new List<Book>();

        public void BorrowBook(Book book)
        {
            borrowedBooks.Add(book);
            Console.WriteLine($"{Name} adlı üye , {book.Title} kitabını ödünç aldı.");

        }
        public void ReturnBook(Book book)
        {
            borrowedBooks.Remove(book);
            Console.WriteLine($"{Name} adlı üye , {book.Title} kitabını geri getirdi.");

        }
    }
}
