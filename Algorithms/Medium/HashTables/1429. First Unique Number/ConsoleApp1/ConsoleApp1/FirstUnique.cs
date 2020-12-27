using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class FirstUnique
    {
        private Queue<int> _queue = new Queue<int>();
        private Dictionary<int, int> _dict = new Dictionary<int, int>();

        public FirstUnique(int[] nums)
        {
            foreach (int value in nums)
            {
                AddValue(value);
            }
        }

        private void AddValue(int value)
        {
            if (_dict.ContainsKey(value))
            {
                _dict[value]++;
            }
            else
            {
                _queue.Enqueue(value);
                _dict.Add(value, 1);
            }
        }

        public int ShowFirstUnique()
        {
            foreach (var value in _queue)
            {
                if (_dict[value] == 1)
                    return _dict[value];
            }

            return -1;
        }

        public void Add(int value)
        {
            AddValue(value);
        }
    }
}
