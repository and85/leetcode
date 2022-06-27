using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            int l = 0, r = numbers.Length - 1;

            while (l < r)
            {
                 if (numbers[l] + numbers[r] > target)
                {
                    r--;
                }
                else if (numbers[l] + numbers[r] < target)
                {
                    l++;
                }
                else
                {
                    break;
                }
            }

            return new int[] { l + 1, r + 1 };
        }

        public int[] TwoSum_Attempt1(int[] numbers, int target)
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
