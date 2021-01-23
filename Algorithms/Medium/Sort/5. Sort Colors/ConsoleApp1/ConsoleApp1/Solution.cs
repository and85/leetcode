using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public void SortColors(int[] nums)
        {
            // counting sort
            //CountingSort(nums);

            DutchNationalFlagProblem_Dijkstra(nums);
        }

        private void DutchNationalFlagProblem_Dijkstra(int[] nums)
        {
            int p0 = 0, curr = 0;
            int p2 = nums.Length - 1;
            while (curr <= p2)
            {
                if (nums[curr] == 0)
                {
                    Swap(curr, p0, nums);
                    curr++;
                    p0++;
                }
                else if (nums[curr] == 2)
                {
                    Swap(curr, p2, nums);
                    p2--;
                }
                else
                    curr++;
            }
        }

        private void Swap(int v1, int v2, int[] nums)
        {
            int t = nums[v1];
            nums[v1] = nums[v2];
            nums[v2] = t;
        }

        private void CountingSort(int[] nums)
        {
            int[] counters = new int[3];

            for (int i = 0; i < nums.Length; i++)
            {
                counters[nums[i]]++;
            }

            for (int i = 0; i < counters[0]; i++)
                nums[i] = 0;

            for (int i = 0; i < counters[1]; i++)
                nums[counters[0] + i] = 1;

            for (int i = 0; i < counters[2]; i++)
                nums[counters[0] + counters[1] + i] = 2;
        }
    }
}
