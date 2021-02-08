using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class MyLinkedList
    {
        class ListNode
        {
            public ListNode(int val)
            {
                Val = val;
            }

            public int Val { get; set; }
            public ListNode Next { get; set; }

            public ListNode Prev { get; set; }
        }


        private ListNode _head;
        private int _length;


        /** Initialize your data structure here. */
        public MyLinkedList()
        {

        }

        /** Get the value of the index-th node in the linked list. If the index is invalid, return -1. */
        public int Get(int index)
        {
            if (index >= _length)
                return -1;

            ListNode curr = _head;

            int i = 0;

            while (curr != null && i < index)
            {
                curr = curr.Next;
                i++;
            }

            return curr.Val;
        }

        /** Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
        public void AddAtHead(int val)
        {
            AddAtIndex(0, val);
        }

        /** Append a node of value val to the last element of the linked list. */
        public void AddAtTail(int val)
        {
            AddAtIndex(_length, val);
        }

        /** Add a node of value val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
        public void AddAtIndex(int index, int val)
        {
            var newNode = new ListNode(val);

            if (_head == null)
            {
                _head = newNode;
                _length++;
                return;
            }

            if (index == 0)
            {
                newNode.Next = _head;
                _head.Prev = newNode;
                _head = newNode;
                _length++;
                return;
            }

            ListNode curr = _head, prev = _head;

            int i = 0;

            while (curr != null && i < index)
            {
                prev = curr;
                curr = curr.Next;
                i++;
            }

            prev.Next = newNode;
            newNode.Prev = prev;
            newNode.Next = curr;
            
            if (curr != null)
                curr.Prev = newNode;

            _length++;
            
        }

        /** Delete the index-th node in the linked list, if the index is valid. */
        public void DeleteAtIndex(int index)
        {
            if (index == 0)
            {
                _head = _head.Next;

                if (_head != null)
                    _head.Prev = null;

                _length--;
                return;
            }

            ListNode curr = _head;

            int i = 0;

            while (curr != null && i < index)
            {
                curr = curr.Next;
                i++;
            }


            if (curr != null)
            {
                ListNode prev = curr.Prev;
                ListNode next = curr.Next;
                if (next != null)
                    next.Prev = prev;

                prev.Next = next;
                _length--;
            }
        }
    }

    /**
     * Your MyLinkedList object will be instantiated and called as such:
     * MyLinkedList obj = new MyLinkedList();
     * int param_1 = obj.Get(index);
     * obj.AddAtHead(val);
     * obj.AddAtTail(val);
     * obj.AddAtIndex(index,val);
     * obj.DeleteAtIndex(index);
     */
}
