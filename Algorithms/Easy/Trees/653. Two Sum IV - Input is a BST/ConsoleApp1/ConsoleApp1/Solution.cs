using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public bool FindTarget(TreeNode root, int k)
        {
            var hashSet = new HashSet<int>();
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var node = queue.Dequeue();
                if (hashSet.Contains(k - node.val)) return true;

                hashSet.Add(node.val);

                if (node.left != null)
                {
                    queue.Enqueue(node.left);
                }

                if (node.right != null)
                {
                    queue.Enqueue(node.right);
                }
            }

            return false;
        }
        
    }
}
