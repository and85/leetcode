using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            var head = new ListNode(1);
            head.next = new ListNode(2); 
            solution.RemoveNthFromEnd(head, 1);
        }
    }
}
