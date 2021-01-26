using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public ListNode InsertionSortList(ListNode head)
        {
            if (head == null)
                return head;

            ListNode res = new ListNode(head.val);
            ListNode curr = head.next;

            while (curr != null)
            {
                res = Insert(res, curr.val);
                curr = curr.next;
            }

            return res;
        }

        private ListNode Insert(ListNode head, int val)
        {
            var newNode = new ListNode(val);

            if (val <= head.val)
            {
                newNode.next = head;
                return newNode;
            }
            else
            {
                ListNode curr = head;
                ListNode tmp;
                while (curr.next != null)
                {
                    if (val <= curr.next.val )
                    {
                        tmp = curr.next;
                        curr.next = newNode;
                        newNode.next = tmp;

                        return head;
                    }

                    curr = curr.next;
                }

                // if we reached this point, it means we want to insert a new node as a tail
                curr.next = newNode;
            }

            return head;
        }
    }
}
