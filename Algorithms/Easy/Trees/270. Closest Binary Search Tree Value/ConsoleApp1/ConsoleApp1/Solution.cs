using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public int ClosestValue(TreeNode root, double target)
        {
            int result = -1;
            double minDiff = double.PositiveInfinity;

            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var curNode = queue.Dequeue();

                if (target == curNode.val) return curNode.val;

                double curDiff = Math.Abs(target - curNode.val);
                if (curDiff < minDiff)
                {
                    minDiff = curDiff;
                    result = curNode.val;
                }

                if (target < curNode.val && curNode.left != null)
                    queue.Enqueue(curNode.left);

                if (target > curNode.val && curNode.right != null)
                    queue.Enqueue(curNode.right);
            }

            return result;
        }
    }
}
