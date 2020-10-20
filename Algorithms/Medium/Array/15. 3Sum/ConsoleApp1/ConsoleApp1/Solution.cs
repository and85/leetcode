using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    // somehow my original solution could pass time limit, the most similar one is this one
    // copypasted from jiannian

    public class Solution
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            Array.Sort(nums);
            var res = new List<IList<int>>();
            var hs = new HashSet<IList<int>>(new SequenceComparer<int>());
            for (int i = 0; i < nums.Length && nums[i] <= 0; i++)
            {
                TwoSumII2(nums, i, hs);
            }
            res = hs.ToList();
            return res;
        }

        public void TwoSumII2(int[] nums, int i, HashSet<IList<int>> hs)
        {
            int lo = i + 1, hi = nums.Length - 1;
            while (lo < hi)
            {
                int sum = nums[i] + nums[lo] + nums[hi];
                if (sum < 0)
                {
                    ++lo;
                }
                else if (sum > 0)
                {
                    --hi;
                }
                else
                {
                    hs.Add(new List<int>() { nums[i], nums[lo++], nums[hi--] });
                }
            }
        }
    }

    class SequenceComparer<T> : IEqualityComparer<IEnumerable<T>>
    {
        public bool Equals(IEnumerable<T> seq1, IEnumerable<T> seq2)
        {
            return seq1.SequenceEqual(seq2);
        }

        public int GetHashCode(IEnumerable<T> seq)
        {
            int hash = 1234567;
            foreach (T elem in seq)
                hash = hash * 37 + elem.GetHashCode();
            return hash;
        }
    }
}
