using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            if (headA == null || headB == null)
                return null;
            
            ListNode beginingA = headA;
            ListNode beginingB = headB;
            int switchCounter = 0;

            while (switchCounter <= 2)
            {

                if (headA == null)
                {
                    switchCounter++;
                    headA = beginingB;
                }
                if (headB == null)
                {
                    switchCounter++;
                    headB = beginingA;
                }

                if (headA == headB)
                    return headA;

                headA = headA.next;
                headB = headB.next;


            }

            return null;
        }
    }
}
