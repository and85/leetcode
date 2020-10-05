using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var node4 = new ListNode(4);
            var node2 = new ListNode(2);
            var node1 = new ListNode(1);
            var node3 = new ListNode(3);
            node4.next = node2;
            node2.next = node1;
            node1.next = node3;

            var solution = new Solution();
            solution.SortList(node4);

            Console.ReadLine();
        }
    }
}
