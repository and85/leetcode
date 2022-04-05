using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class Solution
    {

        private Dictionary<int, List<(int, int)>> _dict = new Dictionary<int, List<(int, int)>>();

        private int _counter = 0;

        public IList<IList<int>> VerticalOrder(TreeNode root)
        {            
            var result = new List<IList<int>>();

            if (root == null) return result;

            Bfs(root);

            foreach (var level in _dict.OrderBy(i => i.Key))
            {
                result.Add(level.Value.OrderBy(v => v.Item2).Select(v => v.Item1).ToList());
            }
            
            return result;
        }

        private void Bfs(TreeNode root)
        {            
            var queue = new Queue<(TreeNode, int)>();
            queue.Enqueue((root, 0));

            while (queue.Count > 0)
            {
                int levelSize = queue.Count;

                for (int i = 0; i < levelSize; i++)
                {
                    var node = queue.Dequeue();
                    VisitNode(node.Item1, node.Item2);

                    if (node.Item1.left != null)
                    {
                        queue.Enqueue((node.Item1.left, node.Item2 - 1));
                    }

                    if (node.Item1.right != null)
                    {
                        queue.Enqueue((node.Item1.right, node.Item2 + 1));
                    }
                }
            }
        }

        private void VisitNode(TreeNode root, int index)
        {
            if (!_dict.ContainsKey(index))
            {
                _dict.Add(index, new List<(int, int)>());
            }

            _dict[index].Add((root.val, _counter++));
        }
    }
}
