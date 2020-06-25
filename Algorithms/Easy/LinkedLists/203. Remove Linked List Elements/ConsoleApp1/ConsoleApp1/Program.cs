using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();
            var l1 = new ListNode(1);
            l1.next = new ListNode(1);

            var n = s.RemoveElements(l1, 1);

            Console.WriteLine("Hello World!");
        }
    }
}
