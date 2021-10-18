using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public ListNode RotateRight(ListNode head, int k)
        {
            if (head == null) return head;

            int l = GetListLenght(head, out ListNode tail);
            k = k % l;

            if (k == 0) return head;

            ListNode cur = head;
            for (int i = 0; i < l - k - 1; i++)
            {
                cur = cur.next;
            }

            var newHead = cur.next;
            tail.next = head;
            cur.next = null;
            
            return newHead;
        }

        private int GetListLenght(ListNode head, out ListNode tail)
        {
            tail = null;
            int result = 0;

            var cur = head;
            
            while (cur != null)
            {
                tail = cur;
                result++;
                cur = cur.next;
            }

            return result;
        }
    }
}
