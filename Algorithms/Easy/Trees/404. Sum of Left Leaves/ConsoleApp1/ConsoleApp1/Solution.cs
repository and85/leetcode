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
        //private int _sum = 0; 

        public int SumOfLeftLeaves(TreeNode root)
        {
            return TraverseTree(root, false);

            //return _sum;
        }

        private int TraverseTree(TreeNode root, bool isLeft)
        {
            int sum = 0;
            if (root == null)
                return sum;

            if (root.left == null && root.right == null && isLeft)
                sum += root.val;

            sum += TraverseTree(root.left, true);
            sum += TraverseTree(root.right, false);

            return sum;
        }
    }
}
