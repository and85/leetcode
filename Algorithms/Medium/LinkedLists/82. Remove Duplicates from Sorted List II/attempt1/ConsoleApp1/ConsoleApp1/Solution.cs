using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            ListNode curr = head;
            ListNode sentitelHead = new ListNode(0);
            sentitelHead.next = head;
            ListNode prev = sentitelHead;

            while (curr != null)
            {
                if (curr.next?.val == curr.val)
                {
                    var skip = curr;

                    while (skip?.val == curr.val)
                    {
                        skip = skip?.next;
                    }

                    prev.next = skip;
                    curr = prev;
                }

                prev = curr;
                curr = curr.next;
            }

            return sentitelHead.next;
        }
    }
}
