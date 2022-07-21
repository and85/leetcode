using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Solution_Leetcode
    {
        public IList<IList<int>> PermuteUnique(int[] nums)
        {
            var results = new List<IList<int>>();

            // count the occurrence of each number
            var counter = new Dictionary<int, int>();
            foreach (int num in nums)
            {
                if (!counter.ContainsKey(num))
                {
                    counter.Add(num, 0);
                }
                counter[num]++;
            }

            var comb = new LinkedList<int>();
            Backtrack(comb, nums.Length, counter, results);
            return results;
        }

        private void Backtrack(LinkedList<int> comb, int N, Dictionary<int, int> counter, List<IList<int>> results)
        {

            if (comb.Count == N)
            {
                // make a deep copy of the resulting permutation,
                // since the permutation would be backtracked later.
                results.Add(comb.ToList());
                return;
            }

            foreach (var entry in counter.ToList())
            {
                int num = entry.Key;
                int count = entry.Value;
                if (count == 0)
                    continue;
                // add this number into the current combination
                comb.AddLast(num);
                counter[num] =  count - 1;

                // continue the exploration
                Backtrack(comb, N, counter, results);

                // revert the choice for the next exploration
                comb.RemoveLast();
                counter[num] = count;
            }
        }
    }
}
