using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            var result = new List<IList<int>>();

            if (root == null)
                return result;
            
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            bool leftRight = true;

            while (queue.Count > 0)
            {
                int queueSize = queue.Count;
                var curList = new List<int>();
                for (int i = 0; i < queueSize; i++)
                {
                    var node = queue.Dequeue();
                    curList.Add(node.val);

                    PopulateQueue(node.left, queue);
                    PopulateQueue(node.right, queue);
                }

                if (!leftRight)
                {
                    curList.Reverse();
                }

                leftRight = !leftRight;
                result.Add(curList);
            }

            return result;
        }

        private void PopulateQueue(TreeNode node, 
            Queue<TreeNode> stack)
        {
            if (node != null)
            {
                stack.Enqueue(node);
            }
        }
    }
}
