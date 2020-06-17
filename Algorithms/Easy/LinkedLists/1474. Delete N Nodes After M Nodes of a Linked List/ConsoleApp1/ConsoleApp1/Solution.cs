using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public ListNode DeleteNodes(ListNode head, int m, int n)
        {
            ListNode curr = head;

            int keepCounter = 0, removeCounter = 0;
            while (curr != null)
            {
                keepCounter++;

                if (keepCounter == m)
                {
                    while (removeCounter++ != n)
                    {
                        curr.next = curr.next?.next;
                    }

                    keepCounter = 0;
                    removeCounter = 0;
                }

                curr = curr.next;
            }

            return head;
        }
    }
}
