using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public ListNode OddEvenList(ListNode head)
        {
            if (head == null) return null;

            var curr = head;
            var sentitelOdd = new ListNode();
            var currOdd = sentitelOdd;
            var sentitelEven = new ListNode();
            var currEven = sentitelEven;

            bool isOdd = true;
            while (curr != null)
            {
                if (isOdd)
                {
                    currOdd.next = curr;
                    currOdd = currOdd.next;
                }
                else
                {
                    currEven.next = curr;
                    currEven = currEven.next;
                }

                curr = curr.next;
                isOdd = !isOdd;
            }

            currEven.next = null;
            currOdd.next = sentitelEven.next;

            return sentitelOdd.next;
        }
    }
}
