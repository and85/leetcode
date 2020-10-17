using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var node7 = new Node(7);
            var node13 = new Node(13);
            var node11 = new Node(11);
            var node10 = new Node(10);
            var node1 = new Node(1);

            node7.next = node13;
            node7.random = null;

            node13.next = node11;
            node13.random = node7;

            node11.next = node10;
            node11.random = node1;

            node10.next = node1;
            node10.random = node11;

            var solution = new Solution();
            var clone = solution.CopyRandomList(node7);

            Console.ReadLine();
        }
    }
}
