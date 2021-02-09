using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new MyCircularQueue(8);
            queue.EnQueue(3);
            queue.EnQueue(9);
            queue.EnQueue(5);
            queue.EnQueue(0);
            queue.DeQueue();
            queue.DeQueue();
            queue.IsEmpty();
            queue.IsEmpty();
            queue.Rear();
            queue.Rear();
            queue.DeQueue();

            Console.ReadLine();
        }
    }
}
