using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        bool _hasPathSum = false;

        public bool HasPathSumRecursive(TreeNode root, int sum)
        {
            if (root == null)
                return false;

            if (root.val == sum && root.left == null && root.right == null)
                _hasPathSum = true;

            HasPathSumRecursive(root.left, sum - root.val);
            HasPathSumRecursive(root.right, sum - root.val);

            return _hasPathSum;
        }

        public bool HasPathSumIterative(TreeNode root, int sum)
        {
            Stack<(TreeNode, int)> stack = new Stack<(TreeNode, int)>();
            stack.Push((root, sum));

            while (stack.Count != 0)
            {
                var element = stack.Pop();
                if (element.Item1?.val == element.Item2
                    && element.Item1?.left == null && element.Item1?.right == null)
                {
                    return true;
                }

                if (element.Item1?.left != null)
                    stack.Push((element.Item1.left,  element.Item2 - element.Item1.val));
                if (element.Item1?.right != null)
                    stack.Push((element.Item1.right, element.Item2 - element.Item1.val));
            }

            return false;
        }
    }
}
