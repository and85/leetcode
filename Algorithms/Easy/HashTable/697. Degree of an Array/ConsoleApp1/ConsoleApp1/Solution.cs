using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {

        private class Entry
        {
            public int Start { get; set; }
            public int End { get; set; }
            public int Degree { get; set; }

        }

        public int FindShortestSubArray(int[] nums)
        {
            int minLen = nums.Length;
            int maxDegree = MaxDegree(nums, 0, nums.Length - 1);

            var dict = new Dictionary<int, Entry>();
            for (int i = 0; i < nums.Length; i++)
            {
                int key = nums[i];
                if (!dict.ContainsKey(key))
                {
                    dict.Add(key, new Entry() { Start = i, End = i, Degree = 1});
                }
                else
                {
                    dict[key].End = i;
                    dict[key].Degree++;
                }

            }

            foreach (var e in dict)
            {
                if (e.Value.Degree != maxDegree) continue;

                minLen = Math.Min(minLen, e.Value.End - e.Value.Start + 1);
            }

            return minLen;
        }        

        private int MaxDegree(int[] nums, int start, int end)
        {
            int max = 0;
            var dict = new Dictionary<int, int>();
            for (int i = start; i <= end; i++)
            {
                if (!dict.ContainsKey(nums[i]))
                {
                    dict.Add(nums[i], 1);
                    max = Math.Max(max, 1);
                }
                else
                {
                    dict[nums[i]]++;
                    max = Math.Max(max, dict[nums[i]]);
                }
            }

            return max;
        }
    }
}
