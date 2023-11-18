using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            int r = 0, w = 0, counter = 1;


            while (r < nums.Length)
            {
                if (nums[r] != nums[w]) 
                {
                    nums[++w] = nums[r];
                    counter++;
                }

                r++;
            }

            return counter;
        }
    }
}
