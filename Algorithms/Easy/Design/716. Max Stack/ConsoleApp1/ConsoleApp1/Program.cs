using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Method1();
            //Method2();
            //Method3();
            //Method4();
            Method5();

            Console.ReadLine();
        }

        private static void Method1()
        {
            MaxStack stack = new MaxStack();
            stack.Push(5);
            stack.Push(1);
            stack.Push(5);
            stack.Top(); //-> 5
            stack.PopMax(); //-> 5
            stack.Top(); //-> 1
            stack.PeekMax(); //-> 5
            stack.Pop(); //-> 1
            stack.Top(); //-> 5
        }

        private static void Method2()
        {
            MaxStack stack = new MaxStack();
            stack.Push(5);
            stack.Push(1);
            
            stack.PopMax(); //-> 5
            stack.PeekMax(); //-> 1
        }

        private static void Method3()
        {

            MaxStack stack = new MaxStack();
            stack.Push(74);
            stack.PopMax();
            stack.Push(89);
            stack.Push(67);
            stack.PopMax();
            stack.Pop();
            stack.Push(61);
            stack.Push(-77);
            stack.PeekMax();
            stack.PopMax();
        }

        private static void Method4()
        {
            MaxStack stack = new MaxStack();
            stack.Push(5);
            stack.PeekMax();
            stack.Pop();
        }

        private static void Method5()
        {
            MaxStack stack = new MaxStack();
            stack.Push(5);
            stack.Push(1);
            stack.PopMax();
            stack.PeekMax();
        }
    }
}
