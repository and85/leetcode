using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public bool IsBalanced(TreeNode root)
        {
            if (root == null || (root.left == null && root.right == null))
                return true;

            return Math.Abs(GetHeight(root.left) - GetHeight(root.right)) <= 1
                && IsBalanced(root.left)
                && IsBalanced(root.right);
        }

        private int GetHeight(TreeNode root)
        {
            if (root == null)
                return -1;

            return Math.Max(GetHeight(root.left), GetHeight(root.right)) + 1;
        }
    }

}
