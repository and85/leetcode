using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();

            var n1 = new ListNode(1);
            var n2 = new ListNode(2);
            var n3 = new ListNode(3);
            var n33 = new ListNode(3);
            var n4 = new ListNode(4);
            var n44 = new ListNode(4);
            var n5 = new ListNode(5);

            n1.next = n2;
            n2.next = n3;
            n3.next = n33;
            n33.next = n4;
            n4.next = n44;
            n44.next = n5;

            s.DeleteDuplicates(n1);

            var curr = n1;

            while (curr != null)
            {
                Console.WriteLine(curr.val);
                curr = curr.next;
            }
        }
    }
}
