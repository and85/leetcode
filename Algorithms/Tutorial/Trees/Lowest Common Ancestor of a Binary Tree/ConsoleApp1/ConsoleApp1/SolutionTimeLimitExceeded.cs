using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SolutionTimeLimitExceeded
    {
        private TreeNode _lowestCommonAncestor;
        private int _lowestLevel = -1;

        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            FindLowestCommonAncestor(root, p, q, 0);
            return _lowestCommonAncestor;
        }

        private TreeNode FindLowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q, int curLevel)
        {
            if (root == null)
                return null;

            TreeNode lowestCommonAncestor = null;

            if (ContainsNode(root, p) && ContainsNode(root, q))
            {
                if (curLevel > _lowestLevel)
                {
                    lowestCommonAncestor = root;
                    _lowestCommonAncestor = root;
                }
            }

            if (FindLowestCommonAncestor(root.left, p, q, curLevel + 1) != null)
            {
                lowestCommonAncestor = root.left;
                return lowestCommonAncestor;
            }

            if (FindLowestCommonAncestor(root.right, p, q, curLevel + 1) != null)
            {
                lowestCommonAncestor = root.right;
                return lowestCommonAncestor;
            }

            return lowestCommonAncestor;
        }

        private bool ContainsNode(TreeNode root, TreeNode node)
        {
            var stack = new Stack<TreeNode>();
            stack.Push(root);

            while (stack.Count > 0)
            {
                var cur = stack.Pop();

                if (cur.val == node.val)
                    return true;

                if (cur.right != null)
                    stack.Push(cur.right);
                if (cur.left != null)
                    stack.Push(cur.left);
            }

            return false;
        }
    }
}
