using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public bool IsCousins(TreeNode root, int x, int y)
        {
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            int level = 0;
            while (queue.Count != 0)
            {
                int levelSize = queue.Count();

                int xp = 0, yp = 0;
                for (int i = 0; i < levelSize; i++)
                {
                    var node = queue.Dequeue();

                    if (node.left != null)
                    {
                        if (node.left.val == x) xp = node.val;
                        if (node.left.val == y) yp = node.val;

                        queue.Enqueue(node.left);
                    }
                    if (node.right != null)
                    {
                        if (node.right.val == x) xp = node.val;
                        if (node.right.val == y) yp = node.val;

                        queue.Enqueue(node.right);
                    }

                    if (xp != 0 && yp != 0)
                        return xp != yp;

                    
                }

                if ((xp != 0 && yp == 0) || (yp != 0 && xp == 0)) return false;
                level++;

            }

            return false;
        }
    }
}
