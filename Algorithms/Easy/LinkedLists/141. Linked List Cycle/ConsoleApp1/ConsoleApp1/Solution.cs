using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x)
            {
                val = x;
                next = null;
            }
        }

        public bool HasCycle(ListNode head)
        {
            ListNode slow = head?.next;
            ListNode fast = head?.next?.next;

            while (fast != null)
            {
                if (fast == slow) 
                    return true;

                slow = slow.next;
                fast = fast.next?.next;
            }

            return false;
        }

        public bool HasCycle_Attempt1(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head;

            while (slow != null && fast != null)
            {
                slow = slow?.next;
                fast = fast?.next?.next;

                if (fast == slow && fast != null)
                    return true;
            }

            return false;
        }
    }
}
