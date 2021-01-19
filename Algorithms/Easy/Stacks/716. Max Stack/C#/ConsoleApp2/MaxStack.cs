using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class MaxStack
    {
        private Stack<(int, int)> _values = new Stack<(int, int)>();
        

        /** initialize your data structure here. */
        public MaxStack()
        {

        }

        // O(1)

        public void Push(int x)
        {
            if (_values.Count != 0)
            {
                _values.Push((x, Math.Max(x, _values.Peek().Item2)));
            }
            else
            {
                _values.Push((x, x));
            }
        }

        public int Pop()
        {
            return _values.Pop().Item1;
        }

        // O(1)
        public int Top()
        {
            return _values.Peek().Item1;
        }

        // O(1)
        public int PeekMax()
        {
            return _values.Peek().Item2;
        }

        // O(n)
        public int PopMax()
        {
            int max = _values.Peek().Item2;

            var temp = new Stack<int>();
            int top;
            while (_values.Peek().Item1 != max)
            {
                top = _values.Pop().Item1;
                temp.Push(top);
            }

            _values.Pop();

            while (temp.Count != 0)
            {
                Push(temp.Pop());
            }

            return max;
        }
    }
}
