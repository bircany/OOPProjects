using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Interface.LooselyCoupled
{
    public class Stack : IStack
    {
        private readonly IStack _stack;

        public Stack(IStack stack)
        {
            _stack = stack;  //DI
        }

        public void Pop()
        {
            _stack.Pop();
        }

        public void Push(int item)
        {
            _stack.Push(item);
        }
    }
}
