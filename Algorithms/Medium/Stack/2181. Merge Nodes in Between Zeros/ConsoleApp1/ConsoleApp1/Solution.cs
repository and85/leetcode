using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public ListNode MergeNodes(ListNode head)
        {
            ListNode prevZero = head, curr = head.next;
            int currSum = 0;

            while (curr != null)
            {
                if (curr.val == 0)
                {
                    curr.val = currSum;
                    currSum = 0;
                    prevZero.next = curr;
                    prevZero = curr;
                }
                else
                {
                    currSum += curr.val;
                }

                curr = curr.next;
            }
            
            return head.next;
        }
    }
}
