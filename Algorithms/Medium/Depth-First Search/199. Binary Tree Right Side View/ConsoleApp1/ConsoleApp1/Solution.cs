using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public IList<int> RightSideView(TreeNode root)
        {
            if (root == null)
                return new List<int>();

            //return Bfs(root);
            return Dfs(root, 0, new List<int>());
        }

        // return right most element for each level
        private IList<int> Bfs(TreeNode root)
        {
            var result = new List<int>();
            var queue = new Queue<TreeNode>();

            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                int levelLength = queue.Count;
                for (int i = 0; i < levelLength; i++)
                {
                    var node = queue.Dequeue();

                    if (IsTheMostRightElementReached(i, levelLength))
                        result.Add(node.val);

                    if (node.left != null)
                        queue.Enqueue(node.left);
                    if (node.right != null)
                        queue.Enqueue(node.right);
                }
            }

            return result;
        }

        private bool IsTheMostRightElementReached(int i, int count)
        {
            return i == count - 1;
        }

        private IList<int> Dfs(TreeNode root, int level, List<int> result)
        {
            if (root == null)
                return result;

            if (result.Count == level)
                result.Add(root.val);

            if (root.right != null)
            {
                Dfs(root.right, level + 1, result);
            }

            if (root.left != null)
            {
                Dfs(root.left, level + 1, result);
            }

            return result;
        }
    }
}
