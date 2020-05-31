using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class Solution
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            if (head == null)
                return null;

            int lenght = GetListLenght(head);
            int jumpIndex = lenght - n;

            if (jumpIndex != 0)
            {
                int nodeIndex = 0;
                ListNode curr = head;
                while (curr.next != null)
                {
                    if (++nodeIndex != jumpIndex)
                        curr = curr.next;
                    else
                    {
                        curr.next = curr.next.next;
                        curr = curr.next;
                    }
                }
            }
            else
            {
                head = head.next;
            }

            return head;
        }

        private int GetListLenght(ListNode head)
        {
            int lenght = 1;
            ListNode curr = head;
            while (curr.next != null)
            {
                lenght++;
                curr = curr.next;
            }

            return lenght;
        }
    }
}