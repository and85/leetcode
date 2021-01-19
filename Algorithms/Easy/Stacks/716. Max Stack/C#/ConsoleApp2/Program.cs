using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new MaxStack();
            //stack.Push(5);
            stack.Push(1);
            stack.Push(5);
            stack.Push(3);
            stack.Top();
            stack.PopMax();
            stack.Top();
            stack.PeekMax();
            stack.Pop();
            stack.Top();

            Console.WriteLine();

        }
    }
}
