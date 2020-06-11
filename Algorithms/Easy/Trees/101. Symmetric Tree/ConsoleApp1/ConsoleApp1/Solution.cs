using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public bool IsSymmetric(TreeNode root)
        {
            return IsSymmetric(root, root);
        }

        private bool IsSymmetricRecursive(TreeNode left, TreeNode right)
        {
            if (left == null && right == null)
                return true;
            if (left == null && right != null)
                return false;
            if (left != null && right == null)
                return false;

            if (left.left?.val != right.right?.val || left.right?.val != right.left?.val)
                return false;

            return IsSymmetricRecursive(left.left, right.right) &&
                IsSymmetricRecursive(left.right, right.left);
        }

        private bool IsSymmetric(TreeNode left, TreeNode right)
        {
            var stack = new Stack<TreeNode>();
            stack.Push(left);
            stack.Push(right);

            while (stack.Count > 0)
            {
                left = stack.Pop();
                right = stack.Pop();
                if (left == null && right == null) continue;
                if (left == null || right == null) return false;
                if (left.val != right.val) return false;

                stack.Push(left.left);
                stack.Push(right.right);
                stack.Push(left.right);
                stack.Push(right.left);
            }

            return true;
        }
    }
}
