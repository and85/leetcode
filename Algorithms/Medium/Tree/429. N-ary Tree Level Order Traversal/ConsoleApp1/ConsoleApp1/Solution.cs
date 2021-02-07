using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public class Level
        {
            public Level(Node node, int height)
            {
                Node = node;
                Height = height;
            }

            public Node Node { get; set; }
            public int Height { get; set; }
        }

        public IList<IList<int>> LevelOrder(Node root)
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

                    foreach (var child in curNode.Node.children)
                    {
                        queue.Enqueue(new Level(child, height + 1));
                    }

                    level.Add(curNode.Node.val);
                }

                height++;

                result.Add(level);
            }

            return result;
        }
    }
}
