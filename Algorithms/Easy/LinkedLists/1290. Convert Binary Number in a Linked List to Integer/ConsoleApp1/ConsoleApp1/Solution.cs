using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public int GetDecimalValue(ListNode head)
        {
            ListNode reversed = ReverseList(head);

            int i = 0, result = 0;
            ListNode curr = reversed;

            while (curr != null)
            {
                result += curr.val == 1 ? (int)Math.Pow(2, i) : 0; 
                i++;
                curr = curr.next;
            }

            return result;
        }

        private ListNode ReverseList(ListNode head)
        {
            ListNode curr = head, next, prev = null;

            while (curr != null)
            {
                next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }

            return prev;
        }
    }
}
