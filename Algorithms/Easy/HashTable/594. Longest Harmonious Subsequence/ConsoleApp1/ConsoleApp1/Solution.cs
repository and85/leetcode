using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public int FindLHS(int[] nums)
        {
            var counts = nums.GroupBy(n => n).ToDictionary(n => n.Key, n => n.Count());

            int maxLen = 0;
            foreach (var count in counts)
            {
                if (counts.ContainsKey(count.Key + 1))
                {
                    maxLen = Math.Max(maxLen, count.Value + counts[count.Key + 1]);
                }
            }

            return maxLen;

            //return Sorting(nums);
        }

        private static int Sorting(int[] nums)
        {
            Array.Sort(nums);

            int min = 0, max = 0, maxLen = 0;

            while (min < nums.Length)
            {
                if (min == max)
                {
                    max++;
                }
                else if (max < nums.Length && nums[max] - nums[min] == 1)
                {
                    maxLen = Math.Max(maxLen, max - min + 1);
                    max++;
                }
                else if (max < nums.Length && nums[max] == nums[min])
                {
                    max++;
                }
                else
                {
                    min++;
                }
            }

            return maxLen;
        }
    }
}
