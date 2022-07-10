using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public bool IsSubtree(TreeNode root, TreeNode subRoot)
        {
            if (root == null) return false;

            return MatchTree(root, subRoot) || IsSubtree(root.left, subRoot) || IsSubtree(root.right, subRoot);
        }

        private bool MatchTree(TreeNode root, TreeNode subRoot)
        {
            if (root == null && subRoot == null) return true;

            return root?.val == subRoot?.val && MatchTree(root?.left, subRoot?.left) && MatchTree(root?.right, subRoot?.right);
        }
    }
}
