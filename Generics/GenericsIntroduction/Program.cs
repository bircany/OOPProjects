using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Generics.ArrayApp  //namespace are diff carefully!.
{
    internal class Program
    {
        public static void Swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;

        }
        static void Main(string[] args)
        {
            var arr1 = new Array<Book>(
                new Book(1, "Sefiller", 30),
                new Book(2, "Suç ve Ceza", 40),
                new Book(3, "Devlet", 50)
            );
            var arr2 = new Array<Company>(
            new Company() { Id = 1, Name = "Aselsan", Country = "Türkiye" },
                new Company() { Id = 2, Name = "Trendyol", Country = "Türkiye" },
                new Company() { Id = 3, Name = "Sahibinden", Country = "Türkiye" }
            );
            foreach (var item in arr1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------------------------");
            foreach (var item in arr2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------");


            int a = 2;
            int b = 3;
            Console.WriteLine($"a = {a} , b = {b}");
            Swap<int>(ref a, ref b);
            Console.WriteLine($"a = {a} , b = {b}");
            Console.WriteLine("---------------------------------------");
            char c1 = 'A', c2 = 'B';
            Console.WriteLine($"c1 = {c1} , c2 = {c2}");
            Swap<char>(ref c1, ref c2);
            Console.WriteLine($"c1 = {c1} , c2 = {c2}");
            Console.WriteLine("---------------------------------------");
            string n1 = "Ahmet", n2 = "Mehmet";
            Console.WriteLine($"n1 = {n1} , n2 = {n2}");
            Swap<string>(ref n1, ref n2);
            Console.WriteLine($"n1 = {n1} , n2 = {n2}");

            Console.ReadKey();
        }
            
        
    }
}
