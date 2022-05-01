using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        private int _sum = 0;
        public int FindTilt(TreeNode root)
        {
            if (root == null) return 0;

            _sum += Math.Abs(Sum(root.left) - Sum(root.right)); 
            
            if (root.left != null)
            {
                FindTilt(root.left);
            }

            if (root.right != null)
            {
                FindTilt(root.right);
            }

            return _sum;
        }

        private int Sum(TreeNode root)
        {
            if (root == null) return 0;
            int sum = 0;
            
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var node = queue.Dequeue();
                sum += node.val;

                if (node.left != null)
                {
                    queue.Enqueue(node.left);
                }

                if (node.right != null)
                {
                    queue.Enqueue(node.right);
                }
            }

            return sum;
        }
    }
}
