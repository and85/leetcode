using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public TreeNode MergeTrees(TreeNode t1, TreeNode t2)
        {
            if (t1 == null)
                return t2;

            var queue = new Queue<(TreeNode, TreeNode)>();
            queue.Enqueue((t1, t2));

            while (queue.Count != 0)
            {
                var pair = queue.Dequeue();

                if (pair.Item1 == null || pair.Item2 == null)
                {
                    continue;
                }

                pair.Item1.val += pair.Item2?.val ?? 0;
                

                if (pair.Item1?.left == null)
                {
                    //if (pair.Item1 == null) pair.Item1 = new TreeNode();
                    pair.Item1.left = pair.Item2?.left;
                }
                else
                {
                    queue.Enqueue((pair.Item1?.left, pair.Item2?.left));
                }

                if (pair.Item1?.right == null)
                {
                    //if (pair.Item1 == null) pair.Item1 = new TreeNode();
                    pair.Item1.right = pair.Item2?.right;
                }
                else
                {
                    queue.Enqueue((pair.Item1?.right, pair.Item2?.right));
                }
            }


            return t1;
        }

        public TreeNode MergeTrees_attempt3(TreeNode t1, TreeNode t2)
        {
            if (t1 == null && t2 == null) return null;
            
            int mergedValue = (t1?.val ?? 0) + (t2?.val ?? 0);

            TreeNode node = new TreeNode(mergedValue);
            node.left = MergeTrees(t1?.left, t2?.left);
            node.right = MergeTrees(t1?.right, t2?.right);

            return node;
        }

        public TreeNode MergeTrees_attempt1(TreeNode t1, TreeNode t2)
        {
            if (t1 == null && t2 == null)
                return null;

            TreeNode newTree = new TreeNode();
            newTree.val = (t1?.val ?? 0) + (t2?.val ?? 0);

            newTree.left = MergeTrees_attempt1(t1?.left, t2?.left);
            newTree.right = MergeTrees_attempt1(t1?.right, t2?.right);

            return newTree;
        }

        public TreeNode MergeTrees_attempt2(TreeNode t1, TreeNode t2)
        {
            if (t1 == null && t2 != null) return t2;

            if (t1 == null && t2 == null) return null;

            t1.val += t2?.val ?? 0;

            t1.left = MergeTrees(t1.left, t2?.left);
            t1.right = MergeTrees(t1.right, t2?.right);

            return t1;
        }
    }
}
