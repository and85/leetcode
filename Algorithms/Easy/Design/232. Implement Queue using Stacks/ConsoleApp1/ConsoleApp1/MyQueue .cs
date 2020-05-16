using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class MyQueue
    {
        private Stack<int> _stack1 = new Stack<int>();
        private Stack<int> _stack2 = new Stack<int>();
        private int _firstElement;

        /** Initialize your data structure here. */
        public MyQueue()
        {

        }

        /** Push element x to the back of queue. */
        public void Push(int x)
        {
            if (_stack1.Count == 0)
                _firstElement = x;

            _stack1.Push(x);
        }

        /** Removes the element from in front of queue and returns that element. */
        public int Pop()
        {
            RearangeStacks();

            return _stack2.Pop(); ;
        }

        /** Get the front element. */
        public int Peek()
        {
            if (_stack2.Count != 0)
            {
                return _stack2.Peek();
            }
            return _firstElement;
        }

        /** Returns whether the queue is empty. */
        public bool Empty()
        {
            return (_stack1.Count == 0 && _stack2.Count == 0);
        }

        private void RearangeStacks()
        {
            if (_stack2.Count == 0)
            {
                while (_stack1.Count != 0)
                    _stack2.Push(_stack1.Pop());
            }
        }
    }

    /**
     * Your MyQueue object will be instantiated and called as such:
     * MyQueue obj = new MyQueue();
     * obj.Push(x);
     * int param_2 = obj.Pop();
     * int param_3 = obj.Peek();
     * bool param_4 = obj.Empty();
     */
}
