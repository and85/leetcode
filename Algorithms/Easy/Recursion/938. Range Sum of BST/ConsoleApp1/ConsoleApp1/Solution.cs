using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        int _sum = 0;
        public int RangeSumBST(TreeNode root, int L, int R)
        {
            if (root == null)
                return 0;

            _sum += (root.val >= L && root.val <= R) ? root.val : 0;

            if (root.val >= L)
                RangeSumBST(root.left, L, R);

            if (root.val <= R)
                RangeSumBST(root.right, L, R);

            return _sum;
        }
    }
}
