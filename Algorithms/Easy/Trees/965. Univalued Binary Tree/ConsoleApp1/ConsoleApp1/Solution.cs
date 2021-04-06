using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public bool IsUnivalTree(TreeNode root)
        {
            var queue = new Queue<TreeNode>();
            int value = root.val;
            queue.Enqueue(root);
            TreeNode node;
            while (queue.Count > 0)
            {
                node = queue.Dequeue();

                if (node.val != value)
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
