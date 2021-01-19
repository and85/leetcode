using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class CustomStack
    {
        private LinkedList<int> _list = new LinkedList<int>();
        
        private int _maxSize;

        public CustomStack(int maxSize)
        {
            _maxSize = maxSize;
        }

        public void Push(int x)
        {
            if (_list.Count == _maxSize)
                return;
            
            _list.AddLast(x);
        }

        public int Pop()
        {
            if (_list.Count == 0)
                return -1;

            var last = _list.Last;
            _list.RemoveLast();
            return last.Value;
        }

        public void Increment(int k, int val)
        {
            var node = _list.First;

            for (int i = 0; i < Math.Min(k, _list.Count); i++)
            {
                node.Value += val;
                node = node.Next;
            }
        }
    }
}
