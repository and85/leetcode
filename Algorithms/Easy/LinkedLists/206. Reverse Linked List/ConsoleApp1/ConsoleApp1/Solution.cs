using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /*
    Reverse a singly linked list.

    Example:

    Input: 1->2->3->4->5->NULL
    Output: 5->4->3->2->1->NULL
    Follow up:

    A linked list can be reversed either iteratively or recursively. Could you implement both?
    */
    public class Solution
    {
        public ListNode ReverseList(ListNode head)
        {
            var listNodeStack = new Stack<int>();
            while (head != null)
            {
                listNodeStack.Push(head.val);
                head = head.next;
            }

            ListNode res = null;
            ListNode node = null;
            ListNode prevNode = null;
            while (listNodeStack.Count != 0)
            {
                int val = listNodeStack.Pop();
                node = new ListNode(val);
                
                if (prevNode != null)
                    prevNode.next = node;
                prevNode = node;

                if (res == null)
                    res = node;
            }

            return res;
        }
    }
}
