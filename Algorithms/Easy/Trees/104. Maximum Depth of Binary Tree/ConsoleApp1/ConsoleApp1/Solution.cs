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
        private int _maxDepth = 0;

        public int MaxDepth(TreeNode root)
        {
            // return Bfs(root);
            return Dfs(root, 0);                        
        }

        private int Dfs(TreeNode root, int height)
        {
            if (root == null) return height;
            
            return Math.Max(Dfs(root.left, height + 1), Dfs(root.right, height + 1));
        }

        private int Bfs(TreeNode root)
        {
            if (root == null) return 0;

            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            int levelSize;
            int levels = 0;

            while (queue.Count > 0)
            {
                levelSize = queue.Count;
                levels++;

                for (int i = 0; i < levelSize; i++)
                {
                    var node = queue.Dequeue();

                    if (node.left != null)
                        queue.Enqueue(node.left);
                    if (node.right != null)
                        queue.Enqueue(node.right);
                }
            }

            return levels;
        }

        public int MaxDepth_Attempt1(TreeNode root)
        {
            TraverseTree(root, 0);

            return _maxDepth;
        }

        private void TraverseTree(TreeNode root, int depth)
        {
            if (root == null)
                return;
            
            depth++;

            _maxDepth = Math.Max(_maxDepth, depth);

            TraverseTree(root.left, depth);
            TraverseTree(root.right, depth);
        }
    }
}
