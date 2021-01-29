using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public ListNode DetectCycle(ListNode head)
        {


            //return HashSetSolution(head);

            ListNode curr = head;

            while (curr != null)
            {
                if (curr.val > 100000)
                {
                    curr.val -= 200001;
                    return curr;
                }

                // mark as visited
                curr.val += 200001;

                curr = curr.next;
            }

            return null;


        }

        private static ListNode HashSetSolution(ListNode head)
        {
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
