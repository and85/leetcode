using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public int[] CreateTargetArray(int[] nums, int[] index)
        {
            /*
            Input: nums = [0,1,2,3,4], index = [0,1,2,2,1]
            Output: [0,4,1,3,2]

            dictionary conter for index  array
            0 - 1, range 0-0, currPosition
            1 - 2 range 1-2, currPosition
            2 -2 range 3-4, currPosition

            then go from right to left in nums array and populate target array, increase currentPosition each time when insert an item into the range
            */
        }
    }
}
