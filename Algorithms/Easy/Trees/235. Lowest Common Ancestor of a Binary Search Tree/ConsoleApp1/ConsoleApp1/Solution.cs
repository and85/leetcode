using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            /*
                1. if root equal to p or q -> found. root is the lowest common  ancestor
                2. if left is less, right is greater -> found. root is the lowest common  ancestor
                3. if p and q is less than root, check left sub tree
                4. if p and q is greater than root, check right subtree
            */
            if (root.val == p.val || root.val == q.val)
                return root;

            int l = Math.Min(p.val, q.val);
            int r = Math.Max(p.val, q.val);

            if (root.val > l && root.val < r)
                return root;

            if (l < root.val && r < root.val)
                return LowestCommonAncestor(root.left, p, q);

            if (l > root.val && r > root.val)
                return LowestCommonAncestor(root.right, p, q);

            return null;
        }
    }
}
