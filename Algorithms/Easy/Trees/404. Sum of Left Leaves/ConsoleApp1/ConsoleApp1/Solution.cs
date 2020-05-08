using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // https://leetcode.com/problems/sum-of-left-leaves/
    public class Solution
    {
        private int _sum = 0; 

        public int SumOfLeftLeaves(TreeNode root)
        {
            TraverseTree(root, false);

            return _sum;
        }

        private void TraverseTree(TreeNode root, bool isLeft)
        {
            if (root == null)
                return;

            if (root.left == null && root.right == null && isLeft)
                _sum += root.val;

            TraverseTree(root.left, true);
            TraverseTree(root.right, false);
        }
    }
}
