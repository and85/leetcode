using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public int MinMoves(int[] nums)
        {
            //return BruteForce(nums);

            //return SortApproach(nums);

            return TwoPassesApproach(nums);
        }

        private int TwoPassesApproach(int[] nums)
        {
            int moveCounter = 0;
            int minIndex = FindMinIndex(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                if (i == minIndex)
                    continue;
                moveCounter += nums[i] - nums[minIndex];
            }

            return moveCounter;
        }

        private int SortApproach(int[] nums)
        {
            Array.Sort(nums);

            int moveCounter = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                moveCounter += nums[i] - nums[0];
            }

            return moveCounter;
        }

        private int BruteForce(int[] nums)
        {
            int moveCounter = 0;
            int maxIndex;
            while (!IsEqualized(nums))
            {
                maxIndex = FindMaxIndex(nums);
                IncreaseArray(nums, maxIndex);

                moveCounter++;
            }

            return moveCounter;
        }

        private int FindMinIndex(int[] nums)
        {
            int minIndex = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] < nums[minIndex])
                    minIndex = i;
            }

            return minIndex;
        }

        private int FindMaxIndex(int[] nums)
        {
            int maxIndex = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > nums[maxIndex])
                    maxIndex = i;
            }

            return maxIndex;
        }

        private bool IsEqualized(int[] nums)
        {
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1])
                    return false;
            }

            return true;
        }

        private void IncreaseArray(int[] nums, int ignoreIndex)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (i == ignoreIndex)
                    continue;
                
                nums[i]++;
            }
        }
    }
}
