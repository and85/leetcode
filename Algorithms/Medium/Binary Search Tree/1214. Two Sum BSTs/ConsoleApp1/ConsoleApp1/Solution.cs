using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public bool TwoSumBSTs(TreeNode root1, TreeNode root2, int target)
        {
            var sorted1 = new List<int>();
            var sorted2 = new List<int>();

            TraverseTree(root1, target, sorted1);
            TraverseTree(root2, target, sorted2);

            foreach (int n1 in sorted1)
            foreach (int n2 in sorted2)
            {
                if (n1 + n2 == target)
                    return true;
            }

            return false;
        }

        // get sorted lists from BST
        private void TraverseTree(TreeNode node, int target, List<int> candidates)
        {
            //if (node == null)
            //    return;

            //// since we also operate with negative values, we can't just cut values which are greater than targed
            //TraverseTree(node.left, target, candidates);

            //candidates.Add(node.val);

            //TraverseTree(node.right, target, candidates);
            var queue = new Queue<TreeNode>();
            queue.Enqueue(node);

            TreeNode curr;
            while (queue.Count > 0)
            {
                curr = queue.Dequeue();
                if (curr == null)
                    continue;

                queue.Enqueue(curr.left);
                candidates.Add(curr.val);
                queue.Enqueue(curr.right);
            }
        }
    }
}
