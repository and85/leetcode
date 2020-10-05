using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        class MinNode
        {
            ListNode Node { get; set; }
            ListNode PrevNode { get; set; }

            ListNode NextNode { get; set; }
        }

        // simplest implementation O(n log n) and O(n) stace
        public ListNode SortList(ListNode head)
        {
            var values = new List<int>();
            ListNode curr = head;

            while (curr != null)
            {
                values.Add(curr.val);
                curr = curr.next;
            }

            var arrayValues = values.ToArray();
            Array.Sort(arrayValues);

            return ArrayToList(arrayValues);
        }

        private ListNode ArrayToList(int[] array)
        {
            ListNode root = null;
            for (int i = 0; i < array.Length; i++)
                root = Insert(root, array[i]);
            
            return root;
        }

        private ListNode Insert(ListNode root, int item)
        {
            ListNode temp = new ListNode();
            ListNode ptr;
            temp.val = item;
            temp.next = null;

            if (root == null)
                root = temp;
            else
            {
                ptr = root;
                while (ptr.next != null)
                    ptr = ptr.next;
                ptr.next = temp;
            }
            return root;
        }

        // follow up O(n log n) time, O(1) space?

        // ? Heap sort theoretically could give us O(n log n) and O(1) space,
        // but we need a random access to the aray which we don't have in a list
        public ListNode HeapSort(ListNode head)
        {
            ListNode curr = head;

            while (curr != null)
            {

            }

            return null;
        }

        public ListNode FindMin(ListNode curNode)
        {
            return null;
        }
    }
}
