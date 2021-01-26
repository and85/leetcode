using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {

        private TreeNode _res;

        public TreeNode SearchBST(TreeNode root, int val)
        {

            if (root.val == val)
            {
                _res = root;
                return _res;
            }

            if (root.val > val && root.left != null)
                SearchBST(root.left, val);

            if (root.val < val && root.right != null)
                SearchBST(root.right, val);

            return _res;
        }
    }
}
