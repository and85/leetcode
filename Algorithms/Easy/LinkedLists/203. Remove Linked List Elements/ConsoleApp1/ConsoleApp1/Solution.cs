using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public ListNode RemoveElements(ListNode head, int val)
        {
            ListNode sentinel = new ListNode(0);
            sentinel.next = head;

            ListNode prev = sentinel, curr = head;
            while (curr != null)
            {
                if (curr.val == val) prev.next = curr.next;
                else prev = curr;
                curr = curr.next;
            }
            return sentinel.next;
        }
    }
}
