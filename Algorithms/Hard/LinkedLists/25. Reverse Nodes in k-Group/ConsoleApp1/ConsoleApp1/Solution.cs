using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public ListNode ReverseKGroup(ListNode head, int k)
        {
            int length = GetListLenght(head);
            int groupNumber = length / k;
            int groupCounter = 0, nodeCounter = 0;

            ListNode curr = head, next, prev = null, nodeStart = head;

            while (groupCounter < groupNumber)
            {
                next = curr.next;

                if (nodeCounter == 0)
                    nodeStart = curr;
                if (nodeCounter == k - 1)
                {
                    nodeStart.next = next;
                    nodeCounter = 0;
                    groupCounter++;
                }

                curr.next = prev;
                prev = curr;
                curr = next;
                nodeCounter++;
            }

            return null;
        }

        private int GetListLenght(ListNode head)
        {
            int lenght = 0;

            ListNode curr = head;
            while (curr != null)
            {
                lenght++;
                curr = curr.next;
            }

            return lenght;
        }
    }
}
