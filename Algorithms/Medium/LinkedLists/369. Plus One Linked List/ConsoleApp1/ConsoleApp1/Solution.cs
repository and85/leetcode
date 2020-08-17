using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public ListNode PlusOne(ListNode head)
        {
            var stack = new Stack<ListNode>();
            ListNode cur = head;
            while (cur != null)
            {
                stack.Push(cur);
                cur = cur.next;
            }

            int digit;
            int carry = -1;

            while (stack.Count != 0 && carry != 0)
            {
                digit = GetDigit(stack);
                carry = digit / 10;
            }
            
            if (carry == 1)
            {
                var newHead = new ListNode(1);
                newHead.next = head;
                head = newHead;
            }

            return head;
        }

        private static int GetDigit(Stack<ListNode> stack)
        {
            ListNode lastNode = stack.Pop();
            int digit = lastNode.val + 1;
            lastNode.val = digit % 10;
            return digit;
        }
    }
}
