using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class Solution
    {
        private int _maxDepth = 0;

        public int MaxDepth(TreeNode root)
        {
            TraverseTree(root, 0);

            return _maxDepth;
        }

        private void TraverseTree(TreeNode root, int depth)
        {
            if (root == null)
                return;
            
            depth++;

            _maxDepth = Math.Max(_maxDepth, depth);

            TraverseTree(root.left, depth);
            TraverseTree(root.right, depth);
        }
    }
}
