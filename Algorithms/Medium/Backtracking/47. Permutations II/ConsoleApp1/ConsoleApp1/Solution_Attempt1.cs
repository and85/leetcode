using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Solution_Attempt1
    {
        private IList<IList<int>> _result = new List<IList<int>>();
        private HashSet<int> _current = new HashSet<int>();

        public IList<IList<int>> PermuteUnique(int[] nums)
        {
            Backtrack(nums, 0);
            return _result;
        }

        private void Backtrack(int[] nums, int first)
        {
            if (_current.Count == nums.Length)
            {
                var r = _current.Select(c => nums[c]).ToList();

                if (!ContainsList(r))
                {
                    _result.Add(r);
                }
                return;
            }


            int i = first;
            do
            {
                if (!_current.Contains(i))
                {

                    _current.Add(i);
                    
                    if (i + 1 < nums.Length)
                    {
                        Backtrack(nums, i + 1);
                    }
                    else
                    {
                        Backtrack(nums, 0);
                    }
                    
                    _current.Remove(i);
                }

                i++;

                if (i == nums.Length)
                {
                    i = 0;
                }
            }
            while (i != first);
        }

        private bool ContainsList(List<int> list)
        {
            return _result.Any(r => Enumerable.SequenceEqual(r, list));
        }
    }
}
