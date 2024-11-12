using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Interface.IEnumerableApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Define an custom array
            var CustomArr = new Array(1,3,5,7,9);
            var arr = new int[] { 1, 3, 5, 7 };

            //predefined
            foreach(var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------------------");
            foreach (var item in CustomArr)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
