using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class TreeNode {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
 
    public class Solution
    {
        private int _counter = 0;

        public int GoodNodes(TreeNode root)
        {
            Traverse(root, root.val);

            return _counter;         
        }

        private void Traverse(TreeNode root, int currPathMax)
        {
            if (root == null)
                return;

            if (IsGoodNode(root, currPathMax))
                _counter++;

            if (root.left != null)
                Traverse(root.left, Math.Max(root.left.val, currPathMax));

            if (root.right != null)
                Traverse(root.right, Math.Max(root.right.val, currPathMax));
        }

        private static bool IsGoodNode(TreeNode root, int currPathMax)
        {
            return root.val >= currPathMax;
        }
    }
}
