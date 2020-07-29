using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public TreeNode MergeTrees(TreeNode t1, TreeNode t2)
        {
            TreeNode newTree = t1;
            Traverse(t1, t2);

            return newTree;
        }

        private void Traverse(TreeNode t1, TreeNode t2)
        {
            
        }
    }
}
