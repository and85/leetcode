using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class RecentCounter
    {

        Queue<int> _queue;
        public RecentCounter()
        {
            _queue = new Queue<int>();
        }

        public int Ping(int t)
        {
            _queue.Enqueue(t);
            while (_queue.Peek() < t - 3000)
                _queue.Dequeue();
            return _queue.Count;
        }
    }
}
