using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class MovingAverage
    {
        private int _size;
        double _sum = 0;
        private Queue<int> _queue = new Queue<int>();

        public MovingAverage(int size)
        {
            _size = size;
        }

        public double Next(int val)
        {
            _queue.Enqueue(val);
            _sum += val; 

            if (_queue.Count > _size)
            {
                _sum -= _queue.Dequeue();
            }

            return _sum / _queue.Count;
        }
    }
}
