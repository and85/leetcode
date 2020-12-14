using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        // sum(i,j)=sum(0,j)-sum(0,i), where sum(i,j) represents the sum of all the elements from index i to j-1. Can we use this property to optimize it?
        public int SubarraySum(int[] nums, int k)
        {
            int count = 0;
            int[] sum = new int[nums.Length + 1];
            sum[0] = 0;
            for (int i = 1; i <= nums.Length; i++)
                sum[i] = sum[i - 1] + nums[i - 1];
            for (int start = 0; start < nums.Length; start++)
            {
                for (int end = start + 1; end <= nums.Length; end++)
                {
                    if (sum[end] - sum[start] == k)
                        count++;
                }
            }
            return count;
        }

        public int SubarraySum_TimeLimit(int[] nums, int k)
        {
            int[] sums = new int[nums.Length];
            int sumsIndex = 0;
            int res = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j <= sumsIndex; j++)
                {
                    sums[j] = sums[j] + nums[i];
                    if (sums[j] == k)
                        res++;
                }

                sumsIndex++;
            }

            return res;
        }
    }
}
