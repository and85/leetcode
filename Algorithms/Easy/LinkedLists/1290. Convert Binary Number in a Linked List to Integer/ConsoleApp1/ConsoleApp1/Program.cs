using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4))));
            var solution = new Solution();
            solution.GetDecimalValue(head);
            Console.ReadLine();
        }
    }
}
