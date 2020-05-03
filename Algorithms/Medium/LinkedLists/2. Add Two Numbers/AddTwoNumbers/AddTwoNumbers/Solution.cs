using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTwoNumbers
{
    // https://leetcode.com/problems/add-two-numbers/
    /*
     You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order and each of their nodes contain a single digit. Add the two numbers and return it as a linked list.

You may assume the two numbers do not contain any leading zero, except the number 0 itself.

Example:

Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
Output: 7 -> 0 -> 8
Explanation: 342 + 465 = 807. 
     */
    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode dummyHead = new ListNode(0);
            ListNode resultTail = dummyHead;
            int currentNumber;
            int previousBitRemainder = 0;
            while (l1 != null || l2 != null)
            {
                currentNumber = ((l1 != null) ? l1.val : 0) + ((l2 != null) ? l2.val : 0) + previousBitRemainder;

                resultTail.next = new ListNode(currentNumber % 10);
                resultTail = resultTail.next;

                previousBitRemainder = currentNumber / 10;
                l1 = l1?.next;
                l2 = l2?.next;
            }

            if (previousBitRemainder == 1)
                resultTail.next = new ListNode(previousBitRemainder);

            return dummyHead.next;
        }
    }
}
