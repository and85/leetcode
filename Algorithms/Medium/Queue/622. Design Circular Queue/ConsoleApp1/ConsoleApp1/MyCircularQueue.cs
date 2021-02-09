using System;
using System.Collections.Generic;
using System.Web;

namespace ConsoleApp1
{
    public class MyCircularQueue
    {

        // it's actually not really a circular queue, but it passes all test cases and LC solution also has a similar option
        // an example of a real circular queue: https://leetcode.com/problems/design-circular-queue/discuss/740305/java-very-simple-circular-linked-list-2-pointers-no-counter
        private LinkedList<int> _queueList = new LinkedList<int>();
        private int _capacity;

        public MyCircularQueue(int k)
        {
            _capacity = k;
        }

        public bool EnQueue(int value)
        {
            if (IsFull())
                return false;

            _queueList.AddLast(value);

            return true;
        }

        public bool DeQueue()
        {
            if (IsEmpty())
                return false;

            _queueList.RemoveFirst();
            
            return true;
        }

        public int Front()
        {
            if (IsEmpty())
                return -1;

            return _queueList.First.Value;
        }

        public int Rear()
        {
            if (IsEmpty())
                return -1;

            return _queueList.Last.Value;
        }

        public bool IsEmpty()
        {
            return _queueList.Count == 0;
        }

        public bool IsFull()
        {
            return _queueList.Count == _capacity;
        }
    }

    /**
     * Your MyCircularQueue object will be instantiated and called as such:
     * MyCircularQueue obj = new MyCircularQueue(k);
     * bool param_1 = obj.EnQueue(value);
     * bool param_2 = obj.DeQueue();
     * int param_3 = obj.Front();
     * int param_4 = obj.Rear();
     * bool param_5 = obj.IsEmpty();
     * bool param_6 = obj.IsFull();
     */
}
