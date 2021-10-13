using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public IList<double> AverageOfLevels(TreeNode root)
        {
            var result = new List<double>();

            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                int levelSize = queue.Count();

                double sum = 0;
                for (int i = 0; i < levelSize; i++)
                {
                    var node = queue.Dequeue();
                    sum += node.val;

                    if (node.left != null)
                        queue.Enqueue(node.left);
                    if (node.right != null)
                        queue.Enqueue(node.right);
                }

                result.Add(sum / levelSize);
            }

            return result;
        }
    }
}
