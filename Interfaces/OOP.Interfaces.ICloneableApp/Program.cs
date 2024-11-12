using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Interfaces.ICloneableApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var book1 = new Book()
            {
                Id = 1,
                Title = "Suç ve Ceza",
                Price = 25.5
            };
            var book2 = (Book)book1.Clone();
            book2.Id = 2;
            book2.Title = "Sefiller";
            Console.WriteLine(book1.Id + " " + book1.Title);
            Console.WriteLine(book2.Id + " " + book2.Title); 

            Console.ReadKey();
        }
    }
}
