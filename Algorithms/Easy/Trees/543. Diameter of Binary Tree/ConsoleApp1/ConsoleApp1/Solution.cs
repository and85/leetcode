using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        private int _maxDiameter = 0;

        public int DiameterOfBinaryTree(TreeNode root)
        {
            MaxPath(root);
            return _maxDiameter;

        }

        private int MaxPath(TreeNode root)
        {
            if (root == null) return 0;

            int leftPath = MaxPath(root.left);
            int rightPath = MaxPath(root.right);
            _maxDiameter = Math.Max(_maxDiameter, leftPath + rightPath);
            

            return Math.Max(leftPath, rightPath) + 1;
        }

        
    }
}
