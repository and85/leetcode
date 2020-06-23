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
            var l1 = new ListNode(1);
            l1.next = new ListNode(4);
            l1.next.next = new ListNode(5);

            var l2 = new ListNode(1);
            l2.next = new ListNode(3);
            l2.next.next = new ListNode(4);

            var l3 = new ListNode(2);
            l3.next = new ListNode(6);

            var solution = new Solution();
            var list = new ListNode[3] { l1, l2, l3 };
            solution.MergeKLists(list);
        }
    }
}
