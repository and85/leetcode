using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SolutionSolution_attempt1
    {
        public class BFS
        {
            List<IList<Node>> _levels = new List<IList<Node>>();

            public void Helper(Node node, int level)
            {
                if (_levels.Count == level)
                    _levels.Add(new List<Node>());

                _levels[level].Add(node);

                if (node.left != null)
                    Helper(node.left, level + 1);
                if (node.right != null)
                    Helper(node.right, level + 1);
            }

            public IList<IList<Node>> LevelOrder(Node root)
            {
                if (root == null)
                    return _levels;

                Helper(root, 0);

                return _levels;
            }
        }

        public Node Connect(Node root)
        {
            var bfs = new BFS();
            var levels = bfs.LevelOrder(root);
            foreach (var level in levels)
            {
                for (int i = 0; i < level.Count - 1; i++)
                {
                    level[i].next = level[i + 1];
                }

            }

            return root;
        }
    }
}
