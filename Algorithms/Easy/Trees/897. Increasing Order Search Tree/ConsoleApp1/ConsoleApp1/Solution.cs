using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public TreeNode IncreasingBST(TreeNode root)
        {
            var list = new List<TreeNode>();
            TraverseBST(root, list);

            TreeNode sentinelHead = new TreeNode();
            TreeNode curr = sentinelHead;
            foreach (var node in list)
            {
                curr.right = new TreeNode(node.val);
                curr = curr.right;
            }

            return sentinelHead.right;
        }

        private void TraverseBST(TreeNode root, List<TreeNode> list)
        {
            if (root.left != null)
                TraverseBST(root.left, list);

            list.Add(root);

            if (root.right != null)
                TraverseBST(root.right, list);
        }

    }
}
