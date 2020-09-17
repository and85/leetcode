using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public TreeNode SortedArrayToBST(int[] nums)
        {
            return SortedArrayToBST(nums, 0, nums.Length - 1);
        }

        public TreeNode SortedArrayToBST(int[] arr, int start, int end)
        {
            if (start > end)
            {
                return null;
            }

            int mid = (start + end) / 2;
            var node = new TreeNode(arr[mid]);

            node.left = SortedArrayToBST(arr, start, mid - 1);
            node.right = SortedArrayToBST(arr, mid + 1, end);

            return node;
        }
    }
}
