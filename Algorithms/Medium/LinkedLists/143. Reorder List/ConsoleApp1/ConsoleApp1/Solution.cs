using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        //Given a singly linked list L: L0→L1→…→Ln-1→Ln,
        //reorder it to: L0→Ln→L1→Ln-1→L2→Ln-2→…
        public void ReorderList(ListNode head)
        {
            if (head == null)
                return;

            Stack<ListNode> reversedNodes = GetReversedNodes(head);
            int median = reversedNodes.Count / 2;
            int i = 0;
            ListNode curr = head;
            ListNode reversedNode;
            while (i < median)
            {
                reversedNode = reversedNodes.Pop();
                reversedNode.next = curr.next;
                curr.next = reversedNode;
                curr = reversedNode.next;
                i++;
            }

            // get rid of infinitive loop
            curr.next = null;
        }

        private static Stack<ListNode> GetReversedNodes(ListNode head)
        {
            var reversedNode = new Stack<ListNode>();

            ListNode curr = head;
            while (curr != null)
            {
                reversedNode.Push(curr);
                curr = curr.next;
            }

            return reversedNode;
        }
    }
}
