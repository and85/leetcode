using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var node1 = new ListNode(1);
            var node4 = new ListNode(4);
            var node3 = new ListNode(3);
            var node2 = new ListNode(2);
            var node5 = new ListNode(5);
            var node22 = new ListNode(2);
            node1.next = node4;
            node4.next = node3;
            node3.next = node2;
            node2.next = node5;
            node5.next = node22;

            var solution = new Solution();
            solution.Partition(node1, 3);
        }
    }
}
