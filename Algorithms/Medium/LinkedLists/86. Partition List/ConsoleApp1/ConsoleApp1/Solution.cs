using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public ListNode Partition(ListNode head, int x)
        {
            ListNode lessNodesDummyHead = new ListNode();
            ListNode greaterNodesDummyHead = new ListNode();
            ListNode lessNodes = lessNodesDummyHead;
            ListNode greaterOrEqualNodes = greaterNodesDummyHead;
            ListNode curr = head;

            while (curr != null)
            {
                var dummy = new ListNode(curr.val);

                if (curr.val < x)
                {
                    lessNodes.next = dummy;
                    lessNodes = lessNodes.next;
                }
                else
                {
                    greaterOrEqualNodes.next = dummy;
                    greaterOrEqualNodes = greaterOrEqualNodes.next;
                }

                curr = curr.next;
            }

            lessNodes.next = greaterNodesDummyHead.next;

            return lessNodesDummyHead.next;
        }
    }
}
