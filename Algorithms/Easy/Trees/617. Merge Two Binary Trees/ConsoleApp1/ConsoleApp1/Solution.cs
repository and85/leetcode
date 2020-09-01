using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public TreeNode MergeTrees(TreeNode t1, TreeNode t2)
        {
            if (t1 == null && t2 == null)
                return null;

            TreeNode newTree = new TreeNode();
            newTree.val = (t1?.val ?? 0) + (t2?.val ?? 0);

            newTree.left = MergeTrees(t1?.left, t2?.left);
            newTree.right = MergeTrees(t1?.right, t2?.right);

            return newTree;
        }
    }
}
