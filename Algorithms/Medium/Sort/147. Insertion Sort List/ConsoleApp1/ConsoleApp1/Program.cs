using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            var node6 = new ListNode(6);
            var node5 = new ListNode(5);
            var node3 = new ListNode(3);
            var node1 = new ListNode(1);
            var node8 = new ListNode(8);
            var node7 = new ListNode(7);
            var node2 = new ListNode(2);
            var node4 = new ListNode(4);

            node6.next = node5;
            node5.next = node3;
            node3.next = node1;
            node1.next = node8;
            node8.next = node7;
            node7.next = node2;
            node2.next = node4;

            var node = solution.InsertionSortList(node6);

            Console.ReadLine();
        }
    }
}
