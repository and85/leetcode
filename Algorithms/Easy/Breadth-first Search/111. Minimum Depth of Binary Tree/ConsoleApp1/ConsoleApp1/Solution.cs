using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public int MinDepth(TreeNode root)
        {
            if (root == null)
                return 0;

            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            int depth = 0;
            while (queue.Count > 0)
            {
                int levelLenght = queue.Count;
                depth++;
                for (int i = 0; i < levelLenght; i++)
                {
                    var node = queue.Dequeue();

                    if (node.left == null && node.right == null)
                        return depth;

                    if (node.left != null)
                        queue.Enqueue(node.left);
                    if (node.right != null)
                        queue.Enqueue(node.right);
                }
            }

            return depth;
        }
    }
}
