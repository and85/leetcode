using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public class Level
        {
            public Level(TreeNode node, int height)
            {
                Node = node;
                Height = height;
            }

            public TreeNode Node { get; set; }
            public int Height { get; set; }
        }

        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            var result = new List<IList<int>>();
            if (root == null)
                return result;

            var queue = new Queue<Level>();
            int height = 1;
            queue.Enqueue(new Level(root, height));

            while (queue.Count > 0)
            {
                var level = new List<int>();
                
                while (queue.Count > 0 && queue.Peek().Height == height)
                {
                    var curNode = queue.Dequeue();

                    if (curNode.Node.left != null)
                        queue.Enqueue(new Level(curNode.Node.left, height + 1));
                    if (curNode.Node.right != null)
                        queue.Enqueue(new Level(curNode.Node.right, height + 1));
                    
                    level.Add(curNode.Node.val);
                }

                height++;

                result.Add(level);
            }

            return result;
        }
    }
}
