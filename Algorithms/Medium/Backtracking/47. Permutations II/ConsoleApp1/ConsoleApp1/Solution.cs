using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        private IList<IList<int>> _result = new List<IList<int>>();
        private LinkedList<int> _current = new LinkedList<int>();

        public IList<IList<int>> PermuteUnique(int[] nums)
        {
            Backtrack(nums);
            return _result;
        }

        private void Backtrack(int[] nums)
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


            for (int i = 0; i < nums.Length; i++)
            {
                if (_current.Contains(i)) continue;
                
                _current.AddLast(i);

                Backtrack(nums);

                _current.RemoveLast();
            }

        }

        private bool ContainsList(List<int> list)
        {
            return _result.Any(r => Enumerable.SequenceEqual(r, list));
        }
    }
}
