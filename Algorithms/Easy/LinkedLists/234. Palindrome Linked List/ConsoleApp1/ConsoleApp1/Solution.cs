using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    /**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
    public class Solution
    {
        public bool IsPalindrome(ListNode head)
        {
            int lenght = GetListLenght(head);
            if (lenght < 2)
                return true;

            int median = lenght / 2;

            ListNode lastNode = GetNthNode(head, lenght - 1);
            if (head.val != lastNode.val)
                return false;

            ListNode prev = GetNthNode(head, median);
            ListNode firstAfterMedian = GetNthNode(head, median + 1);
            ListNode curr = firstAfterMedian;
            ListNode next;
            while (curr != null)
            {
                next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }

            int counter = 0;
            while (counter++ < median)
            {
                if (head.val != prev.val)
                    return false;

                head = head.next;
                prev = prev.next;
            }

            return true;
        }

        private ListNode GetNthNode(ListNode head, int firstAfterMedianIndex)
        {
            int counter = 0;
            ListNode curr = head;

            while (counter != firstAfterMedianIndex)
            {
                counter++;
                curr = curr.next;
            }

            return curr;
        }

        private int GetListLenght(ListNode head)
        {
            int result = 0;
            ListNode curr = head;

            while (curr != null)
            {
                result++;
                curr = curr.next;
            }

            return result;
        }
    }
}
