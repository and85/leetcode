using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode node1 = new ListNode(1);
            ListNode node2 = new ListNode(2);
            ListNode node3 = new ListNode(3);
            ListNode node4 = new ListNode(4);
            ListNode node5 = new ListNode(5);
            node1.next = node2;
            node2.next = node3;
            node3.next = node4;
            node4.next = node5;

            var s = new Solution();
            s.ReverseKGroup(node1, 2);

            Console.WriteLine("End");
            Console.ReadLine();
        }
    }
}
