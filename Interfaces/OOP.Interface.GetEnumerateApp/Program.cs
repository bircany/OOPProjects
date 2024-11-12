using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Interface.GetEnumerateApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var collection = new List<Product>()
            {
                new Product()
                {
                    ProductId = 1,
                    ProductName = "Buzdolabı",
                    Price = 8500
                },
                new Product()
                {
                    ProductId = 2,
                    ProductName = "Ocak",
                    Price = 5800
                },
                new Product()
                {
                    ProductId = 3,
                    ProductName = "Kahve Makinesi",
                    Price = 300
                },
                new Product()
                {
                    ProductId = 4,
                    ProductName = "Bulaşık Makinesi",
                    Price = 4000
                },
                new Product()
                {
                    ProductId = 5,
                    ProductName = "Fırın",
                    Price = 8250
                },
            };
            foreach (var product in collection) 
            {
                Console.WriteLine($"{product.ProductId} " + $"{product.ProductName} " + $"{product.Price}");
            }

            Console.WriteLine(new string('-',25)); // same as up.
            IEnumerator<Product> enumerator = collection.GetEnumerator();
            while (enumerator.MoveNext()) 
            {
                Console.WriteLine($"{enumerator.Current.ProductId} " + $"{enumerator.Current.ProductName} " + $"{enumerator.Current.Price}");
            }

            Console.ReadKey();
        }
    }
}
