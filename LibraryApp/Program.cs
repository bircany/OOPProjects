using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fiction fiction1 = new Fiction { Title = "1984", Author = "George Orwell", Genre = "Distopya" };
            Fiction fiction2 = new Fiction { Title = "Moby Dick", Author = "Herman Melville", Genre = "Macera" };
            NonFiction nonFiction1 = new NonFiction { Title = "Sapiens", Author = "Yuval Noah Harari", Subject = "Tarih" };
            NonFiction nonFiction2 = new NonFiction { Title = "Cosmos", Author = "Carl Sagan", Subject = "Bilim" };
            Member member = new Member { Name = "Ahmet", MemberId = 1 };
            Librarian librarian = new Librarian { EmployeeId = 101 };

            librarian.AddBook(fiction1);
            librarian.AddBook(fiction2);
            librarian.AddBook(nonFiction1);
            librarian.AddBook(nonFiction2);
            Console.WriteLine("-------------------------");
            librarian.ShowLibraryBooks();
            Console.WriteLine("-------------------------");

            //Ahmet fiction1 kitabını ödünç aldı ve kütüphaneden kitap çıkarıldı.
            member.BorrowBook(fiction1);
            librarian.RemoveBook(fiction1); 
            Console.WriteLine("-------------------------");
            librarian.ShowLibraryBooks();

            Console.WriteLine("-------------------------");
            //Ahmet kitabı geri getirdi ve kütüphaneye kitap eklendi.
            member.ReturnBook(fiction1);
            librarian.AddBook(fiction1);
            Console.WriteLine("-------------------------");
            librarian.ShowLibraryBooks();

            Console.ReadKey();
        }
    }
}
