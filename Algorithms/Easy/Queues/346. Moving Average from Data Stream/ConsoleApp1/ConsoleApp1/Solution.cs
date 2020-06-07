using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class MovingAverage
    {
        private int _sum = 0;
        private int _size;
        private Queue<int> _nums;

        public MovingAverage(int size)
        {
            _size = size;
            _nums = new Queue<int>(size);

        }

		//
        public double Next(int val)
        {
            _sum += val;
            _nums.Enqueue(val);

            if (_nums.Count > _size)
            {
                _sum -= _nums.Dequeue();
            }

            return (double)_sum / _nums.Count;
        }
    }
}
