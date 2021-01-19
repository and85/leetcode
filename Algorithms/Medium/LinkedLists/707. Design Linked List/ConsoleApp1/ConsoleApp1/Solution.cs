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
        }


        private ListNode _head;
        private ListNode _tail;
        private int _nodeCounter = 0;

        /** Initialize your data structure here. */
        public MyLinkedList()
        {

        }

        /** Get the value of the index-th node in the linked list. If the index is invalid, return -1. */
        public int Get(int index)
        {
            var curr = _head;
            for (int i = 0; i < index; i++)
            {
                curr = curr.Next;
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
            AddAtIndex(_nodeCounter, val);
        }

        /** Add a node of value val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
        public void AddAtIndex(int index, int val)
        {
            if (index == 0 && _nodeCounter == 0)
            {
                _head = new ListNode(val);
                return;
            }

            var curr = _head;
            for (int i = 0; i < index - 1; i++)
            {
                curr = curr.Next;
            }

            var nextNode = curr?.Next;
            var newNode = new ListNode(val);
            
            curr.Next = newNode;
            curr.Next.Next = nextNode;

            if (index == _nodeCounter)
                _tail = newNode;

            _nodeCounter++;
        }

        /** Delete the index-th node in the linked list, if the index is valid. */
        public void DeleteAtIndex(int index)
        {
            if (index == 0)
            {
                _head = _head.Next;
                return;
            }

            var curr = _head;
            for (int i = 0; i < index - 1; i++)
            {
                curr = curr.Next;
            }

            curr.Next = curr.Next?.Next;

            if (index == _nodeCounter - 1)
            {
                _tail = curr;
            }

            _nodeCounter--;
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
