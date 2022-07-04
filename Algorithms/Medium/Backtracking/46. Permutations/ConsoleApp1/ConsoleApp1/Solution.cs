using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        private IList<IList<int>> _result = new List<IList<int>>();
        private IList<int> _current = new List<int>();

        public IList<IList<int>> Permute(int[] nums)
        {
            Backtrack(nums);
            return _result;
        }

        private void Backtrack(int[] nums)
        {
            if (_current.Count == nums.Length)
            {
                _result.Add(_current.ToList());
                return;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (!_current.Contains(nums[i]))
                {
                    _current.Add(nums[i]);
                    Backtrack(nums);
                    _current.Remove(nums[i]);
                }                               
            }
        }
    }
}
