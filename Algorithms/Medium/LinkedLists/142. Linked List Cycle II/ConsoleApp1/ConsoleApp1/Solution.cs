using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public ListNode DetectCycle(ListNode head)
        {
            //ListNode slow = head;
            //ListNode fast = head;

            //while (slow != null && fast != null)
            //{

            //    slow = slow.next;
            //    fast = fast.next?.next;

            //    if (slow == fast)
            //        return slow;
            //}

            ListNode slow = head;
            HashSet<ListNode> hashSet = new HashSet<ListNode>();

            while (slow != null)
            {
                if (!hashSet.Contains(slow))
                    hashSet.Add(slow);
                else
                    return slow;

                slow = slow.next;
            }

            return null;
        }
    }
}
