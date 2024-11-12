using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Interface.LooselyCoupled
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack(new ArrayStack());
            stack.Pop();
            stack.Push(5);

            Console.ReadKey();

        }
    }
}
