using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public string LargestNumber(int[] nums)
        {
            Array.Sort(nums, new NumAsStrComparer());

            if (nums.Any(n => n != 0))
                return string.Concat(nums);
            else
                return "0";
        }

        private class NumAsStrComparer : IComparer
        {
            public int Compare(object a, object b)
            {
                string str1 = a.ToString();
                string str2 = b.ToString();

                string firstCandidate = str2 + str1;
                string secondCandidate = str1 + str2;

                return string.Compare(firstCandidate, secondCandidate);
            }
        }
    }
}
