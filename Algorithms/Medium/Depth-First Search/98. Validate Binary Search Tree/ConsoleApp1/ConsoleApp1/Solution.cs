using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public bool IsValidBST(TreeNode root)
        {
            if (root == null)
                return true;

            return AllLessThan(root, root.left) && AllGreaterThan(root, root.right) &&
                IsValidBST(root.left) && IsValidBST(root.right);
        }

        private bool AllLessThan(TreeNode root, TreeNode left)
        {
            if (left == null)
                return true;

            var queue = new Queue<TreeNode>();
            queue.Enqueue(left);

            while (queue.Count > 0)
            {
                var node = queue.Dequeue();

                if (node.val >= root.val)
                    return false;

                if (node.left != null)
                    queue.Enqueue(node.left);
                if (node.right != null)
                    queue.Enqueue(node.right);

            }

            return true;
        }

        private bool AllGreaterThan(TreeNode root, TreeNode right)
        {
            if (right == null)
                return true;

            var queue = new Queue<TreeNode>();
            queue.Enqueue(right);

            while (queue.Count > 0)
            {
                var node = queue.Dequeue();

                if (node.val <= root.val)
                    return false;

                if (node.left != null)
                    queue.Enqueue(node.left);
                if (node.right != null)
                    queue.Enqueue(node.right);

            }

            return true;
        }
    }
}
