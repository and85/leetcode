using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public int MinDiffInBST(TreeNode root)
        {
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            var min = int.MaxValue;

            while (queue.Count > 0)
            {
                var node = queue.Dequeue();
                min = Math.Min(min, GetDiff(node));

                if (node.left != null)
                {
                    queue.Enqueue(node.left);
                }

                if (node.right != null)
                {                    
                    queue.Enqueue(node.right);
                }
            }

            return min;
        }

        private int GetDiff(TreeNode root)
        {
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            var min = int.MaxValue;
            int rootValue = root.val;

            while (queue.Count > 0)
            {
                var node = queue.Dequeue();

                if (node.left != null)
                {
                    min = Math.Min(min, Math.Abs(rootValue - node.left.val));
                    queue.Enqueue(node.left);
                }

                if (node.right != null)
                {
                    min = Math.Min(min, Math.Abs(rootValue - node.right.val));
                    queue.Enqueue(node.right);
                }
            }

            return min;
        }
    }
}
