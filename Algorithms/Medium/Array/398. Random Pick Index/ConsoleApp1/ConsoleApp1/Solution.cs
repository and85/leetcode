using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        private int[] _nums;
        private Dictionary<int, int> _entries = new Dictionary<int, int>();

        public Solution(int[] nums)
        {
            _nums = nums;
            foreach (int num in nums)
            {
                if (_entries.ContainsKey(num))
                    _entries[num]++;
                else
                    _entries.Add(num, 1);
            }
        }

        public int Pick(int target)
        {
            int count = _entries[target];
            int random = new Random().Next(count);

            int counter = 0;
            for (int i = 0; i < _nums.Length; i++)
            {
                if (_nums[i] == target)
                {
                    if (counter++ == random)
                        return i;
                }
            }

            return -1;
        }
    }
}
