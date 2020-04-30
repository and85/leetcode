using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MinStack
    {
        public class Node
        {
            public Node(int value, Node previous, Node next)
            {
                Value = value;
                Previous = previous;
                Next = next;
            }
            
            public int Value;
            public Node Previous;
            public Node Next;
            public int CurrentMinimum;
        }

        Node _currentListNode;

        /** initialize your data structure here. */
        public MinStack()
        {

        }

        public void Push(int x)
        {
            if (_currentListNode == null)
            {
                _currentListNode = new Node(x, null, null);
                _currentListNode.CurrentMinimum = x;
            }
            else
            {
                
                var newNode = new Node(x, _currentListNode, null);
                int newMinimum = (newNode.Previous.CurrentMinimum < x) ? newNode.Previous.CurrentMinimum : x;
                newNode.CurrentMinimum = newMinimum;

                _currentListNode.Next = newNode;
                _currentListNode = newNode;
            }
        }

        public void Pop()
        {
            if (_currentListNode != null)
            {
                Node previousNode = _currentListNode.Previous;
                if (previousNode != null)
                    previousNode.Next = null;
                
                _currentListNode = previousNode;
            }
        }

        public int Top()
        {
            return _currentListNode.Value;
        }

        public int GetMin()
        {
            return _currentListNode.CurrentMinimum;
        }
    }
}
