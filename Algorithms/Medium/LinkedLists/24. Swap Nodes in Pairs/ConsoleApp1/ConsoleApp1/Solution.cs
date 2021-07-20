using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public ListNode SwapPairs(ListNode head)
        {
            ListNode dummyHead = new ListNode();
            dummyHead.next = head;

            ListNode prev = dummyHead;

            ListNode f = head;
            ListNode s = head?.next;
            ListNode next;
            ListNode fNext;
            ListNode sNext;

            while (f != null || s != null)
            {
                next = s?.next;
                fNext = f?.next?.next;
                sNext = s?.next?.next;

                if (s != null)
                    s.next = f;
                
                f.next = next;                                
                
                if (s != null)
                    prev.next = s;

                prev = f;
                f = fNext;
                s = sNext;

            }

            return dummyHead.next;
        }
    }
}
