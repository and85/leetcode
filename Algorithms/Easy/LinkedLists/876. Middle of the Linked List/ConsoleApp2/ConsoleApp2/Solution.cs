using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Solution
    {
        public ListNode MiddleNode(ListNode head)
        {
            var slow = head;
            var fast = head;

            while (fast?.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            return slow;
        }
    }
}
