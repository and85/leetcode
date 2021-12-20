using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public int PivotIndex(int[] nums)
        {

            // O(n) time
            // O(n) space
            // works
            //Solution1(nums);


            // O(n) time
            // O(n) space
            // Some test cases didn't pass
            //return Solution2(nums);

            // O(n) time
            // O(1) space
            // works - taken from Solution
            return Solution3(nums);
        }


        private int Solution1(int[] nums)
        {
            int[] lefts = new int[nums.Length];
            int[] rights = new int[nums.Length];

            int l = 1, r = nums.Length - 2;
            while (l < nums.Length)
            {
                lefts[l] = lefts[l - 1] + nums[l - 1];
                rights[r] = rights[r + 1] + nums[r + 1];
                l++;
                r--;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (lefts[i] == rights[i])
                    return i;
            }

            return -1;
        }

        private int Solution3(int[] nums)
        {
            int sum = 0;
            foreach (int num in nums)
                sum += num;

            int leftSum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (leftSum == sum - leftSum - nums[i]) return i;
                leftSum += nums[i];
            }

            return -1;
        }


        private int Solution2(int[] nums)
        {
            /*
              2. solution
            use to pointers go from left and right and update existing array 

            calculate each element value as prevleft + prevleftsum or prevright + prevright sum
            when left >= right, it meanch potentially we could find a solution
            so compare new calculated value with a value calculated by the other pointer, 
            when values match, it means this is our potential answer and we need to check if 
            it's on the left from another potential ansfer

            1,   7,  3,   6,     5,   6
            0,   1,  8,  [11],  17   22
            26   25  17  [11]   6    0
            */

            int l = 0, r = nums.Length - 1, prevLeft = 0, prevLeftSum = 0, prevRight = 0, prevRightSum = 0, candidateIndex = nums.Length;
            while (l < nums.Length)
            {
                

                if (l >= r)
                {
                    // check candidates here
                    if (prevLeft + prevLeftSum == nums[l])
                        candidateIndex = Math.Min(candidateIndex, l);
                    if (prevRight + prevRightSum == nums[r])
                        candidateIndex = Math.Min(candidateIndex, r);
                }

                int tl = nums[l];
                int tr = nums[r];
                

                nums[l] = prevLeft + prevLeftSum;
                nums[r] = prevRight + prevRightSum;

                prevLeft = tl;
                prevRight = tr;

                prevLeftSum = nums[l];
                prevRightSum = nums[r];

                l++;
                r--;
            }

            return candidateIndex < nums.Length ? candidateIndex : -1;
        }

    }
}
