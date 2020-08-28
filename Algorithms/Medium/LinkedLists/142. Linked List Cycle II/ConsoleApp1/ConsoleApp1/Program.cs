using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var node3 = new ListNode(3);
            var node2 = new ListNode(2);
            var node0 = new ListNode(0);
            var nodem4 = new ListNode(-4);

            node3.next = node2;
            node2.next = node0;
            node0.next = nodem4;
            nodem4.next = node2;

            var solution = new Solution();
            solution.DetectCycle(node3);

            Console.ReadLine();
        }
    }
}
