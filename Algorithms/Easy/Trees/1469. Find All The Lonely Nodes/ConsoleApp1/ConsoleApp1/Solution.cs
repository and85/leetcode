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
        public IList<int> GetLonelyNodes(TreeNode root)
        {
            var lonelyNodes = new List<int>();

            Traverse(root, lonelyNodes);

            return lonelyNodes;
        }

        private void Traverse(TreeNode root, IList<int> lonelyNodes)
        {
            if (root == null)
                return;

            if (root.left != null && root.right == null)
                lonelyNodes.Add(root.left.val);

            if (root.right != null && root.left == null)
                lonelyNodes.Add(root.right.val);

            Traverse(root.left, lonelyNodes);
            Traverse(root.right, lonelyNodes);
        }
    }
}
