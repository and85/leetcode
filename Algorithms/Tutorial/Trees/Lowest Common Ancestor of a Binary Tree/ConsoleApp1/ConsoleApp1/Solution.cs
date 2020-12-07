using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // taken from the solutuion to debug
    class Solution
    {

        private TreeNode ans;

        public Solution()
        {
            // Variable to store LCA node.
            this.ans = null;
        }
        private bool RecurseTree(TreeNode currentNode, TreeNode p, TreeNode q)
        {

            // If reached the end of a branch, return false.
            if (currentNode == null)
            {
                return false;
            }

            // Left Recursion. If left recursion returns true, set left = 1 else 0
            int left = this.RecurseTree(currentNode.left, p, q) ? 1 : 0;

            // Right Recursion
            int right = this.RecurseTree(currentNode.right, p, q) ? 1 : 0;

            // If the current node is one of p or q
            int mid = (currentNode == p || currentNode == q) ? 1 : 0;


            // If any two of the flags left, right or mid become True
            if (mid + left + right >= 2)
            {
                this.ans = currentNode;
            }

            // Return true if any one of the three bool values is True.
            return (mid + left + right > 0);
        }

        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            // Traverse the tree
            this.RecurseTree(root, p, q);
            return this.ans;
        }
    }
}
