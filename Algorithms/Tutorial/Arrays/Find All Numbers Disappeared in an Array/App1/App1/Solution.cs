using System;
using System.Collections.Generic;
using System.Text;

namespace App1
{
    // optimal solution taken from the problem
    public class Solution
    {
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            // Iterate over each of the elements in the original array
            for (int i = 0; i < nums.Length; i++)
            {

                // Treat the value as the new index
                int newIndex = Math.Abs(nums[i]) - 1;

                // Check the magnitude of value at this new index
                // If the magnitude is positive, make it negative 
                // thus indicating that the number nums[i] has 
                // appeared or has been visited.
                if (nums[newIndex] > 0)
                {
                    nums[newIndex] *= -1;
                }
            }

            // Response array that would contain the missing numbers
            List<int> result = new List<int>();

            // Iterate over the numbers from 1 to N and add all those
            // that have positive magnitude in the array
            for (int i = 1; i <= nums.Length; i++)
            {

                if (nums[i - 1] > 0)
                {
                    result.Add(i);
                }
            }

            return result;
        }
    }
}
