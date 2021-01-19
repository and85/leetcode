using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class CustomStack_bad
    {

        public class Node
        {
            public Node(int val)
            {
                Val = val;
            }

            public int Val { get; set; }
        }

        private LinkedList<Node> _list = new LinkedList<Node>();
        private Stack<Node> _stack = new Stack<Node>();
        private int _maxSize;

        public CustomStack_bad(int maxSize)
        {
            _maxSize = maxSize;
        }

        public void Push(int x)
        {
            if (_stack.Count == _maxSize)
                return;

            var node = new Node(x);
            
            _stack.Push(node);
            _list.AddLast(node);
        }

        public int Pop()
        {
            if (_stack.Count == 0)
                return - 1;

            _list.G
            _list.RemoveLast();
            return _stack.Pop().Val;
        }

        public void Increment(int k, int val)
        {
            var node = _list.First;
            
            for (int i = 0; i < Math.Min(k, _list.Count); i++)
            {
                node.Value.Val += val;
                node = node.Next;
            }
        }
    }

    /**
     * Your CustomStack object will be instantiated and called as such:
     * CustomStack obj = new CustomStack(maxSize);
     * obj.Push(x);
     * int param_2 = obj.Pop();
     * obj.Increment(k,val);
     */
}
