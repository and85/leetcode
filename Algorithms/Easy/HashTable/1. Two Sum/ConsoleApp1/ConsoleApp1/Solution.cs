using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // https://leetcode.com/problems/two-sum/
    /*
    Given an array of integers, return indices of the two numbers such that they add up to a specific target.

    You may assume that each input would have exactly one solution, and you may not use the same element twice.

    Example:

    Given nums = [2, 7, 11, 15], target = 9,

    Because nums[0] + nums[1] = 2 + 7 = 9,
    return [0, 1].
    */
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            // here MultiValueDictionary collection would pay off, but it can't be used by leetcode platform
            var possibleNums = new Dictionary<int, List<int>>();
            for (int index = 0; index < nums.Length; index++)
            {
                if (!possibleNums.ContainsKey(nums[index]))
                {
                    possibleNums.Add(nums[index], new List<int>() { index});
                }
                else
                {
                    possibleNums[nums[index]].Add(index);
                }
            }

            foreach (var num in possibleNums)
            {
                int firstCandidateIndex = num.Value.First();
                int diff = target - num.Key;
                if (possibleNums.ContainsKey(diff))
                {
                    if (possibleNums[diff].Count > 1)
                        return new int[] { possibleNums[diff][0], possibleNums[diff][1] };
                    
                    int secondIndex = possibleNums[diff].Single();
                    if (firstCandidateIndex == secondIndex)
                        continue;

                    return new int[] { firstCandidateIndex, secondIndex };
                }

            }

            return null;
        }
    }
}
