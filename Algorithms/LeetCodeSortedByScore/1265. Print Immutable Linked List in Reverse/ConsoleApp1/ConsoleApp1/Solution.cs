using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
    // This is the ImmutableListNode's API interface.
    // You should not implement it, or speculate about its implementation.
    public class ImmutableListNode 
    {
        public void PrintValue()
        {

        }

        public ImmutableListNode GetNext()
        {
            return null;
        }
    }
     

    public class Solution
    {
        public void PrintLinkedListInReverse(ImmutableListNode head)
        {
            // O(n) time, O(1) space
            if (head == null)
                return;

            const int MaxSize = 1000;
            ImmutableListNode curr = head;
            var arr = new ImmutableListNode[MaxSize];            
            int lenght = 0;
            while (curr != null)
            {
                arr[lenght++] = curr;                
                curr = curr.GetNext();
            }

            for (int i = lenght - 1; i >= 0; i--)
            {
                arr[i].PrintValue();
            }
        }

        public void PrintLinkedListInReverse_SimplestImplementation(ImmutableListNode head)
        {
            // O(n) time, O(n) space
            if (head == null)
                return;

            ImmutableListNode curr = head;
            var stack = new Stack<ImmutableListNode>();

            while (curr != null)
            {
                stack.Push(curr);
                curr = curr.GetNext();
            }

            while (stack.Count > 0)
            {
                stack.Pop().PrintValue();
            }
        }
    }
}
