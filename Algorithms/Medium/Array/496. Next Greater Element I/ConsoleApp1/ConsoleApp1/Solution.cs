using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            var nextGreater = new Dictionary<int, int>();
            var stack = new Stack<int>();

            for (int i = nums2.Length - 1; i >=0; i--)
            {
                if (stack.Count == 0)
                {
                    nextGreater.Add(nums2[i], -1);
                    stack.Push(nums2[i]);
                }
                else
                {
                    while (stack.Count > 0 && stack.Peek() < nums2[i])
                    {
                        stack.Pop();
                    }

                    if (stack.Count == 0)
                        nextGreater.Add(nums2[i], -1);
                    else
                        nextGreater.Add(nums2[i], stack.Peek());

                    stack.Push(nums2[i]);
                }
            }

            for (int i = 0; i < nums1.Length; i++)
            {
                nums1[i] = nextGreater[nums1[i]];
            }

            return nums1;
        }
    }
}
