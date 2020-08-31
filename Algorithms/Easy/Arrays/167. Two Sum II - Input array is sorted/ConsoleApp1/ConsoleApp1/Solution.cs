using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            var positions = new Dictionary<int, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (positions.ContainsKey(target - numbers[i]))
                    return new[] { positions[target - numbers[i]], i + 1 };
                else
                {
                    if (!positions.ContainsKey(numbers[i]))
                        positions.Add(numbers[i], i + 1);
                }
            }

            return null;
        }
    }
}
