using System;

namespace OOP.Interface.LooselyCoupled
{
    public class ArrayStack : IStack
    {
        public void Pop()
        {
            Console.WriteLine("Array.Pop()");
        }

        public void Push(int item)
        {
            Console.WriteLine("Array.Push()");
        }
    }
}
