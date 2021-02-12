using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public int[] SmallerNumbersThanCurrent(int[] nums)
        {
            int[] copy = new int[nums.Length];
            Array.Copy(nums, copy, nums.Length);
            
            CountingSort(copy);

            var pos = new Dictionary<int, int>();

            for (int i = 0; i < copy.Length; i++)
            {
                if (pos.ContainsKey(copy[i]))
                    continue;

                pos.Add(copy[i], i);
            }

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = pos[nums[i]];
            }

            return nums;
        }

        // taken from https://www.geeksforgeeks.org/counting-sort/
        static void CountingSort(int[] arr)
        {
            int[] count = new int[101];
            int[] output = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                count[arr[i]]++;
            }
            for (int i = 1; i < count.Length; i++)
            {
                count[i] += count[i - 1];
            }
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                output[count[arr[i]] - 1] = arr[i];
                count[arr[i]]--;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = output[i];
            }
        }
    }
}
