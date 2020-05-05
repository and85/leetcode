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
            if (root == null) return true;

            if (root.left == null && root.right == null )
                return true;

            if (root.left == null || root.right == null) 
                return false;

            if (root.left.left == null && root.right.right == null && root.left.right == null && root.right.left == null)
                return root.left.val == root.right.val;

            if (root.left.left?.val != root.right.right?.val || root.left.right?.val != root.right.left?.val)
                return false;

            return IsSymmetric(root.left) && IsSymmetric(root.right);
        }
    }
}
