using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MyStack
    {
        Queue<int> _queue1 = new Queue<int>();
        Queue<int> _queue2 = new Queue<int>();
        private int _top;

        /** Initialize your data structure here. */
        public MyStack()
        {

        }

        /** Push element x onto stack. */
        public void Push(int x)
        {
            _top = x;

            if (_queue1.Count != 0)
                _queue1.Enqueue(x);
            
            if (_queue2.Count != 0)
                _queue2.Enqueue(x);

            if (_queue1.Count == 0 && _queue2.Count == 0)
                _queue1.Enqueue(x);
        }

        /** Removes the element on top of the stack and returns that element. */
        public int Pop()
        {
            bool isQ1NotEmpty = _queue1.Count != 0;
            bool isQ2NotEmpty = _queue2.Count != 0;

            if (isQ1NotEmpty)
                return PopElement(_queue1, _queue2);
            if (isQ2NotEmpty)
                return PopElement(_queue2, _queue1);

            return -1;
        }

        private int PopElement(Queue<int> nonEmpty, Queue<int> empty)
        {
            while (nonEmpty.Count != 0)
            {
                int element = nonEmpty.Dequeue();
                if (nonEmpty.Count != 0)
                {
                    _top = element;
                    empty.Enqueue(element);
                }
                else
                    return element;
            }

            return -1;
        }

        /** Get the top element. */
        public int Top()
        {
            return _top;
        }

        /** Returns whether the stack is empty. */
        public bool Empty()
        {
            return (_queue1.Count == 0 && _queue2.Count == 0);
        }
    }
}
