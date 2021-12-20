using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var n1 = new ListNode(1);
            var n2 = new ListNode(2);
            var n3 = new ListNode(3);
            var n4 = new ListNode(4);
            var n5 = new ListNode(5);
            var n6 = new ListNode(6);
            //n1.next = n2;
            //n2.next = n3;
            //n3.next = n4;
            //n4.next = n5;
            //n5.next = n6;

            var s = new Solution();
            s.MiddleNode(n1);

            Console.ReadLine();
        }
    }
}
