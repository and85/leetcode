using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public bool HasCycle(ListNode head)
        {
            var slow = head;
            var fast = head?.next;

            while (fast != null) 
            {
                if (slow == fast) return true;
                
                slow = slow.next;
                fast = fast.next?.next;
            }

            return false;
        }
    }
}
