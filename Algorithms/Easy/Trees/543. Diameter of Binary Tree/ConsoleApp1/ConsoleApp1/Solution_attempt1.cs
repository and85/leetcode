using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution_attempt1
    {
        private int _diameter = 0;

        public int DiameterOfBinaryTree(TreeNode root)
        {
            Traverse(root);

            return _diameter;
        }

        void Traverse(TreeNode root)
        {
            if (root == null) return;

            int d1 = GetDistance(0, root.left);
            int d2 = GetDistance(0, root.right);

            _diameter = Math.Max(_diameter, d1 + d2);

            Traverse(root.left);
            Traverse(root.right);
        }

        private int GetDistance(int d, TreeNode node)
        {
            if (node == null) return d;

            return Math.Max(GetDistance(d + 1, node.left), GetDistance(d + 1, node.right));
        }
    }
}
